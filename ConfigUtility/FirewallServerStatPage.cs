using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Elegant.Ui.Samples.ControlsSample.Common;

namespace Elegant.Ui.Samples.ControlsSample
{
    public partial class FirewallServerStatPage : Elegant.Ui.Samples.ControlsSample.SamplePageBase
    {

        private ServerCheckManager _checker;

        private Boolean isXP = SystemInfo.IsWindowsXPOrHigher;
        private RichTextBox _loggingBox;
        private delegate void AddTextDelegate(string strText);
        private AddTextDelegate _addText = null;

        public FirewallServerStatPage()
        {
            InitializeComponent();
            InitializeClientChecker();
        }

        public void InitializeClientChecker()
        {
            try
            {
                _checker = new ServerCheckManager();
                _checker.LogWriteHandler += this.OnLogWrite;
            }
            catch (Exception ex)
            {
                LogWrite(ex.ToString());
            }
        }

        private void OnLogWrite(object sender, StringEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                LogWrite(e.EventString);
            });
        }

        private void TabControlCheckTask_SelectedTabPageChanged(object sender, TabPageChangedEventArgs e)
        {
            if (TabControlCheckTask.SelectedTabPage == TabPageMySQLServer)
            {
                CheckInitMySqlStatus();
            }
            else if (TabControlCheckTask.SelectedTabPage == TabPageServer)
            {
                CheckInitServerStatus();
            }
        }

        /// <summary>
        /// 서버 로그창에 로그 쓰기 및 로그파일에 쓰기
        /// </summary>
        /// <param name="svrLog"></param>
        public void LogWrite(string svrLog)
        {
            try
            {
                _loggingBox = GetWorkingRichTextBox();
                if (_loggingBox == null)
                {
                    MsgrLogger.WriteLog(svrLog);
                }
                else
                {
                    _addText = new AddTextDelegate(writeLogBox);
                    svrLog = "[" + DateTime.Now.ToString() + "] " + svrLog + "\r\n";
                    if (_loggingBox.InvokeRequired)
                    {
                        Invoke(_addText, svrLog);
                        MsgrLogger.WriteLog(svrLog);
                    }
                    else
                    {
                        _loggingBox.AppendText(svrLog);
                        MsgrLogger.WriteLog(svrLog);
                    }
                }
            }
            catch (Exception exception)
            {
                MsgrLogger.WriteLog(exception.ToString());
            }
        }

        private void FirewallStatPage_Load(object sender, EventArgs e)
        {
            CheckInitMySqlStatus();
        }

        /// <summary>
        /// 1. 서비스 기동확인
        /// 2. 포트 기동확인
        /// 3. 방화벽 등록확인
        /// </summary>
        private void CheckInitMySqlStatus()
        {
            //1. 서비스 기동확인
            CheckMySqlService();

            //2. 포트 기동확인
            CheckMySqlPort();
            
            //3. 방화벽 등록 확인
            CheckMySqlFirewallStatus();
        }

        /// <summary>
        /// 1. 포트확인
        ///   8881
        ///   8885
        ///   8886
        /// 2. 방화벽 동록 확인
        /// </summary>
        private void CheckInitServerStatus()
        {
            //1. 포트 기동확인
            CheckServerMainPort();
            CheckHealthCheckPort();
            CheckCrmPort();

            //2. 방화벽 등록 확인
            CheckServerFirewallStatus();
        }

        private void writeLogBox(string str)
        {
            _loggingBox.AppendText(str);
        }

        private RichTextBox GetWorkingRichTextBox()
        {
            RichTextBox result = null;
            switch (_checker.GetCheckStep())
            {
                case ServerCheckStep.MySqlPing:
                    result = this.RTBoxMySqlPing;
                    break;
                case ServerCheckStep.MySqlComCd:
                    result = this.RTBoxMySqlComCdCheck;
                    break;
                case ServerCheckStep.WDServerPing:
                    result = this.RTBoxServerBasicTest;
                    break;
                default:
                    //
                    break;
            }
            return result;
        }

        private void ButtonMySqlStart_Click(object sender, EventArgs e)
        {
            if (_checker.StartMySql())
            {
                MessageBox.Show(this, "MySql 서비스를 기동했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CheckMySqlService();
            }
            else
            {
                MessageBox.Show(this, "MySql 서비스 기동에 실패했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonMySqlStop_Click(object sender, EventArgs e)
        {
            if (_checker.StopMySql())
            {
                MessageBox.Show(this, "MySql 서비스를 중지했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CheckMySqlService();
            }
            else
            {
                MessageBox.Show(this, "MySql 서비스 중지에 실패했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonPortCheck_Click(object sender, EventArgs e)
        {
            CheckMySqlPort();
        }

        private void CheckMySqlService()
        {
            //1. 서비스 기동확인
            TextBoxMySqlServiceStatus.Text = _checker.CheckMySqlService();
        }

        /// <summary>
        /// MySql 포트 기동확인
        /// </summary>
        private void CheckMySqlPort()
        {
            TextBoxMySqlPortStatus.Text = _checker.CheckMySqlPort(Convert.ToInt16(TextBoxMySqlPort.Text)) ? "포트 기동상태" : "포트 없음";

        }

        private void CheckMySqlFirewallStatus()
        {
            TextBoxMySQLServerFirewall.Text = _checker.IsFirewallEnabled() ? "방화벽 활성화상태(ON)" : "방화벽 비활성화상태(OFF)";

            string result = _checker.CheckMySqlFirewallStatus();

            if (result == null)
            {
                TextBoxMySQLServerFirewall.Text += Environment.NewLine + "비등록상태";
            }
            else
            {
                TextBoxMySQLServerFirewall.Text += Environment.NewLine + string.Format("{0}으로 등록상태", result);
            }
        }
        
        /// <summary>
        /// UDP 기본메시지 수신 포트 확인 8881
        /// </summary>
        private void CheckServerMainPort()
        {
            TextBoxMainPortStatus.Text = _checker.CheckUdpPort(Convert.ToInt16(TextBoxMainPort.Text)) ? "포트 기동상태" : "포트 없음";
        }

        /// <summary>
        /// UDP 헬스체크 포트 확인 8885
        /// </summary>
        private void CheckHealthCheckPort()
        {
            TextBoxHealthCheckPortStatus.Text = _checker.CheckUdpPort(Convert.ToInt16(TextBoxHealthCheckPort.Text)) ? "포트 기동상태" : "포트 없음";
        }

        /// <summary>
        /// TCP CRM수신 포트 확인 8886
        /// </summary>
        private void CheckCrmPort()
        {
            TextBoxCrmPortStatus.Text = _checker.CheckTcpPort(Convert.ToInt16(TextBoxCrmPort.Text)) ? "포트 기동상태" : "포트 없음";
        }
        
        private void CheckServerFirewallStatus()
        {
            TextBoxServerFirewall.Text = _checker.IsFirewallEnabled() ? "방화벽 활성화상태(ON)." : "방화벽 비활성화상태(OFF).";

            string result = _checker.CheckWDServerFirewallStatus();

            if (result == null)
            {
                TextBoxServerFirewall.Text += Environment.NewLine + "비등록상태";
            }
            else
            {
                TextBoxServerFirewall.Text += Environment.NewLine + string.Format("{0}으로 등록상태", result);
            }
        }

        private void ButtonMySqlFirewallAdd_Click(object sender, EventArgs e)
        {
            if (_checker.SetMySqlFirewall())
            {
                MessageBox.Show(this, "방화벽 예외등록에 성공했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CheckMySqlFirewallStatus();
            }
            else
            {
                MessageBox.Show(this, "방화벽 예외등록에 실패했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonMySqlFirewallRemove_Click(object sender, EventArgs e)
        {
            if (_checker.ReleaseMySqlFirewall())
            {
                MessageBox.Show(this, "방화벽 예외등록해제에 성공했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CheckMySqlFirewallStatus();
            }
            else
            {
                MessageBox.Show(this, "방화벽 예외등록해제에 실패했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonMySqlPing_Click(object sender, EventArgs e)
        {
            RTBoxMySqlPing.Clear();
            _checker.CheckMySqlConnection();
        }

        private void ButtonMySqlComcdCheck_Click(object sender, EventArgs e)
        {
            RTBoxMySqlComCdCheck.Clear();
            _checker.GetCompanyCd();
        }

        private void ButtonMainPortCheck_Click(object sender, EventArgs e)
        {
            CheckServerMainPort();
        }

        private void ButtonHealthCheckPortCheck_Click(object sender, EventArgs e)
        {
            CheckHealthCheckPort();
        }

        private void ButtonCrmPortCheck_Click(object sender, EventArgs e)
        {
            CheckCrmPort();
        }

        private void ButtonServerFirewallAdd_Click(object sender, EventArgs e)
        {
            if (_checker.SetWDServerFirewall())
            {
                MessageBox.Show(this, "방화벽 예외등록에 성공했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CheckServerFirewallStatus();
            }
            else
            {
                MessageBox.Show(this, "방화벽 예외등록에 실패했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonServerFirewallRemove_Click(object sender, EventArgs e)
        {
            if (_checker.ReleaseWDServerFirewall())
            {
                MessageBox.Show(this, "방화벽 예외등록해제에 성공했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CheckServerFirewallStatus();
            }
            else
            {
                MessageBox.Show(this, "방화벽 예외등록해제에 실패했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonServerBasicTest_Click(object sender, EventArgs e)
        {
            RTBoxServerBasicTest.Clear();
            _checker.CheckBasicConnection();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _checker.RunMySqlClient();
        }




    }
    
    public enum ServerCheckStep
    {
        None,
        MySqlPing,
        MySqlComCd,
        MySqlServiceCheck,
        MySqlPortCheck,
        MySqlFirewallCheck,
        WDServerFirewallCheck,
        WDServerPortCheck,
        WDServerPing
    }
}
