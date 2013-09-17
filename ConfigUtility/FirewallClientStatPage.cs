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
    public partial class FirewallClientStatPage : Elegant.Ui.Samples.ControlsSample.SamplePageBase
    {

        private ClientCheckManager _checker;
        private Boolean isXP = SystemInfo.IsWindowsXPOrHigher;
        private RichTextBox _loggingBox;
        private delegate void AddTextDelegate(string strText);
        private AddTextDelegate _addText = null;

        public FirewallClientStatPage()
        {
            InitializeComponent();
            InitializeClientChecker();
        }

        public void InitializeClientChecker()
        {
            try
            {
                _checker = new ClientCheckManager();
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
            if (TabControlCheckTask.SelectedTabPage == TabPageMsgr)
            {
                SetMsgrFireWallStatus();
            }
            else if (TabControlCheckTask.SelectedTabPage == TabPageMySQLMsgr)
            {
                SetMySqlFireWallStatus();
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

        private void writeLogBox(string str)
        {
            _loggingBox.AppendText(str);
        }

        private void FirewallStatPage_Load(object sender, EventArgs e)
        {
            SetMsgrFireWallStatus();
        }

        private void SetMsgrFireWallStatus()
        {
            TextBoxMsgrFirewall.Text = _checker.IsFirewallEnabled() ? "방화벽 활성화상태(ON)." : "방화벽 비활성화상태(OFF).";

            string result = _checker.CheckMsgrFirewallStatus();
            if (result == null)
            {
                TextBoxMsgrFirewall.Text += Environment.NewLine + "비등록상태";
            }
            else
            {
                TextBoxMsgrFirewall.Text += Environment.NewLine + string.Format("{0}으로 등록상태", result);
            }
        }

        private void SetMySqlFireWallStatus()
        {
            TextBoxMySqlFirewall.Text = _checker.IsFirewallEnabled() ? "방화벽 활성화상태(ON)." : "방화벽 비활성화상태(OFF).";

            string result = _checker.CheckMySqlFirewallStatus();
            if (result == null)
            {
                TextBoxMySqlFirewall.Text += Environment.NewLine + "비등록상태";
            }
            else
            {
                TextBoxMySqlFirewall.Text += Environment.NewLine + string.Format("{0}으로 등록상태", result);
            }
        }
        
        private void ButtonMsgrFirewallAdd_Click(object sender, EventArgs e)
        {
            if (_checker.SetMsgrFirewall())
            {
                MessageBox.Show(this, "방화벽 예외등록에 성공했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SetMsgrFireWallStatus();
            }
            else
            {
                MessageBox.Show(this, "방화벽 예외등록에 실패했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonMsgrFirewallRemove_Click(object sender, EventArgs e)
        {
            if (_checker.ReleaseMsgrFirewall())
            {
                MessageBox.Show(this, "방화벽 예외등록해제에 성공했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SetMsgrFireWallStatus();
            }
            else
            {
                MessageBox.Show(this, "방화벽 예외등록해제에 실패했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonMsgrBasicTest_Click(object sender, EventArgs e)
        {
            RTBoxMsgrBasicTest.Clear();
            _checker.CheckBasicConnection();
        }

        private void ButtonMsgrHealthCheck_Click(object sender, EventArgs e)
        {
            RTBoxMsgrHealthCheck.Clear();
            _checker.CheckHealthConnection();
        }

        private void ButtonMsgrCRMTest_Click(object sender, EventArgs e)
        {
            RTBoxMsgrCRMTest.Clear();
            _checker.CheckCRMConnection();
        }

        private void ButtonMsgrFTPTest_Click(object sender, EventArgs e)
        {
            RTBoxMsgrFTPTest.Clear();
            _checker.CheckFTPConnection();
        }

        private RichTextBox GetWorkingRichTextBox()
        {
            RichTextBox result = null;
            switch (_checker.GetCheckStep())
            {
                case ClientCheckStep.MsgrBasicTest:
                    result = this.RTBoxMsgrBasicTest;
                    break;
                case ClientCheckStep.MsgrHealthCheck:
                    result = this.RTBoxMsgrHealthCheck;
                    break;
                case ClientCheckStep.MsgrFTPTest:
                    result = this.RTBoxMsgrFTPTest;
                    break;
                case ClientCheckStep.MsgrCRMTest:
                    result = this.RTBoxMsgrCRMTest;
                    break;
                case ClientCheckStep.MySqlBasicTest:
                    result = this.RTBoxMySqlBasicTest;
                    break;
                case ClientCheckStep.MySqlCompanyCdTest:
                    result = this.RTBoxCompanyCdTest;
                    break;
                default:
                    //
                    break;
            }
            return result;
        }

        private void ButtonMySqlBasicTest_Click(object sender, EventArgs e)
        {
            RTBoxMySqlBasicTest.Clear();
            _checker.CheckMySqlConnection();
        }

        private void ButtonCompanyCdTest_Click(object sender, EventArgs e)
        {
            RTBoxCompanyCdTest.Clear();
            _checker.GetCompanyCd();
        }

        private void ButtonMySqlFirewallAdd_Click(object sender, EventArgs e)
        {
            if (_checker.SetMySqlFirewall())
            {
                MessageBox.Show(this, "방화벽 예외등록에 성공했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SetMySqlFireWallStatus();
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
                SetMySqlFireWallStatus();
            }
            else
            {
                MessageBox.Show(this, "방화벽 예외등록해제에 실패했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    
    public enum ClientCheckStep
    {
        None,
        MsgrFirewallCheck,
        MsgrBasicTest,
        MsgrHealthCheck,
        MsgrCRMTest,
        MsgrFTPTest,
        MySqlBasicTest,
        MySqlCompanyCdTest
    }
}
