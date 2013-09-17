namespace Elegant.Ui.Samples.ControlsSample
{
    partial class FirewallServerStatPage
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControlCheckTask = new Elegant.Ui.TabControl();
            this.TabPageMySQLServer = new Elegant.Ui.TabPage();
            this.separator4 = new Elegant.Ui.Separator();
            this.separator3 = new Elegant.Ui.Separator();
            this.ButtonPortCheck = new Elegant.Ui.Button();
            this.TextBoxMySqlPort = new Elegant.Ui.TextBox();
            this.label4 = new Elegant.Ui.Label();
            this.TextBoxMySqlPortStatus = new Elegant.Ui.TextBox();
            this.label2 = new Elegant.Ui.Label();
            this.ButtonMySqlStop = new Elegant.Ui.Button();
            this.ButtonMySqlStart = new Elegant.Ui.Button();
            this.TextBoxMySqlServiceStatus = new Elegant.Ui.TextBox();
            this.groupBox4 = new Elegant.Ui.GroupBox();
            this.button12 = new Elegant.Ui.Button();
            this.separator11 = new Elegant.Ui.Separator();
            this.RTBoxMySqlComCdCheck = new System.Windows.Forms.RichTextBox();
            this.ButtonMySqlComcdCheck = new Elegant.Ui.Button();
            this.separator21 = new Elegant.Ui.Separator();
            this.RTBoxMySqlPing = new System.Windows.Forms.RichTextBox();
            this.ButtonMySqlPing = new Elegant.Ui.Button();
            this.separator22 = new Elegant.Ui.Separator();
            this.label5 = new Elegant.Ui.Label();
            this.ButtonMySqlFirewallRemove = new Elegant.Ui.Button();
            this.ButtonMySqlFirewallAdd = new Elegant.Ui.Button();
            this.TextBoxMySQLServerFirewall = new Elegant.Ui.TextBox();
            this.TabPageServer = new Elegant.Ui.TabPage();
            this.separator1 = new Elegant.Ui.Separator();
            this.separator2 = new Elegant.Ui.Separator();
            this.ButtonCrmPortCheck = new Elegant.Ui.Button();
            this.TextBoxCrmPort = new Elegant.Ui.TextBox();
            this.label8 = new Elegant.Ui.Label();
            this.TextBoxCrmPortStatus = new Elegant.Ui.TextBox();
            this.ButtonHealthCheckPortCheck = new Elegant.Ui.Button();
            this.TextBoxHealthCheckPort = new Elegant.Ui.TextBox();
            this.label9 = new Elegant.Ui.Label();
            this.TextBoxHealthCheckPortStatus = new Elegant.Ui.TextBox();
            this.ButtonMainPortCheck = new Elegant.Ui.Button();
            this.TextBoxMainPort = new Elegant.Ui.TextBox();
            this.label7 = new Elegant.Ui.Label();
            this.TextBoxMainPortStatus = new Elegant.Ui.TextBox();
            this.groupBox1 = new Elegant.Ui.GroupBox();
            this.RTBoxServerBasicTest = new System.Windows.Forms.RichTextBox();
            this.ButtonServerBasicTest = new Elegant.Ui.Button();
            this.separator9 = new Elegant.Ui.Separator();
            this.label1 = new Elegant.Ui.Label();
            this.ButtonServerFirewallRemove = new Elegant.Ui.Button();
            this.ButtonServerFirewallAdd = new Elegant.Ui.Button();
            this.TextBoxServerFirewall = new Elegant.Ui.TextBox();
            this.groupBox3 = new Elegant.Ui.GroupBox();
            this.richTextBox13 = new System.Windows.Forms.RichTextBox();
            this.button18 = new Elegant.Ui.Button();
            this.separator16 = new Elegant.Ui.Separator();
            this.richTextBox14 = new System.Windows.Forms.RichTextBox();
            this.button19 = new Elegant.Ui.Button();
            this.separator17 = new Elegant.Ui.Separator();
            this.richTextBox15 = new System.Windows.Forms.RichTextBox();
            this.button20 = new Elegant.Ui.Button();
            this.separator18 = new Elegant.Ui.Separator();
            this.richTextBox16 = new System.Windows.Forms.RichTextBox();
            this.button21 = new Elegant.Ui.Button();
            this.separator19 = new Elegant.Ui.Separator();
            this.label3 = new Elegant.Ui.Label();
            this.button22 = new Elegant.Ui.Button();
            this.separator20 = new Elegant.Ui.Separator();
            this.button23 = new Elegant.Ui.Button();
            this.textBox3 = new Elegant.Ui.TextBox();
            this.label6 = new Elegant.Ui.Label();
            this.label10 = new Elegant.Ui.Label();
            this.label11 = new Elegant.Ui.Label();
            this.label12 = new Elegant.Ui.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlCheckTask)).BeginInit();
            this.TabPageMySQLServer.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.TabPageServer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlCheckTask
            // 
            this.TabControlCheckTask.Location = new System.Drawing.Point(0, 0);
            this.TabControlCheckTask.Name = "TabControlCheckTask";
            this.TabControlCheckTask.SelectedTabPage = this.TabPageMySQLServer;
            this.TabControlCheckTask.Size = new System.Drawing.Size(835, 609);
            this.TabControlCheckTask.TabIndex = 23;
            this.TabControlCheckTask.TabPages.AddRange(new Elegant.Ui.TabPage[] {
            this.TabPageMySQLServer,
            this.TabPageServer});
            this.TabControlCheckTask.Text = "서버";
            this.TabControlCheckTask.SelectedTabPageChanged += new Elegant.Ui.TabPageChangedEventHandler(this.TabControlCheckTask_SelectedTabPageChanged);
            // 
            // TabPageMySQLServer
            // 
            this.TabPageMySQLServer.ActiveControl = null;
            this.TabPageMySQLServer.Controls.Add(this.label12);
            this.TabPageMySQLServer.Controls.Add(this.separator4);
            this.TabPageMySQLServer.Controls.Add(this.separator3);
            this.TabPageMySQLServer.Controls.Add(this.ButtonPortCheck);
            this.TabPageMySQLServer.Controls.Add(this.TextBoxMySqlPort);
            this.TabPageMySQLServer.Controls.Add(this.label4);
            this.TabPageMySQLServer.Controls.Add(this.TextBoxMySqlPortStatus);
            this.TabPageMySQLServer.Controls.Add(this.label2);
            this.TabPageMySQLServer.Controls.Add(this.ButtonMySqlStop);
            this.TabPageMySQLServer.Controls.Add(this.ButtonMySqlStart);
            this.TabPageMySQLServer.Controls.Add(this.TextBoxMySqlServiceStatus);
            this.TabPageMySQLServer.Controls.Add(this.groupBox4);
            this.TabPageMySQLServer.Controls.Add(this.label5);
            this.TabPageMySQLServer.Controls.Add(this.ButtonMySqlFirewallRemove);
            this.TabPageMySQLServer.Controls.Add(this.ButtonMySqlFirewallAdd);
            this.TabPageMySQLServer.Controls.Add(this.TextBoxMySQLServerFirewall);
            this.TabPageMySQLServer.KeyTip = null;
            this.TabPageMySQLServer.Name = "TabPageMySQLServer";
            this.TabPageMySQLServer.Size = new System.Drawing.Size(833, 589);
            this.TabPageMySQLServer.TabIndex = 3;
            this.TabPageMySQLServer.Text = "MySQL(위두서버)";
            // 
            // separator4
            // 
            this.separator4.Id = "93bd8d71-41b6-4b7b-964c-232907784845";
            this.separator4.Location = new System.Drawing.Point(19, 105);
            this.separator4.Name = "separator4";
            this.separator4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator4.Size = new System.Drawing.Size(694, 25);
            this.separator4.TabIndex = 62;
            this.separator4.Text = "방화벽 상태";
            // 
            // separator3
            // 
            this.separator3.Id = "c88b8d3c-a2e6-4400-9a42-769730fea860";
            this.separator3.Location = new System.Drawing.Point(19, 8);
            this.separator3.Name = "separator3";
            this.separator3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator3.Size = new System.Drawing.Size(694, 25);
            this.separator3.TabIndex = 61;
            this.separator3.Text = "MySql 서버 기동상태";
            // 
            // ButtonPortCheck
            // 
            this.ButtonPortCheck.Id = "9cffcce8-1209-457d-97a5-863a29260f4d";
            this.ButtonPortCheck.Location = new System.Drawing.Point(613, 72);
            this.ButtonPortCheck.Name = "ButtonPortCheck";
            this.ButtonPortCheck.Size = new System.Drawing.Size(66, 21);
            this.ButtonPortCheck.TabIndex = 43;
            this.ButtonPortCheck.Text = "재확인";
            this.ButtonPortCheck.Click += new System.EventHandler(this.ButtonPortCheck_Click);
            // 
            // TextBoxMySqlPort
            // 
            this.TextBoxMySqlPort.Id = "55dfd05b-0e2d-4872-ab3b-35df3424bbd2";
            this.TextBoxMySqlPort.LabelText = "확인포트";
            this.TextBoxMySqlPort.Location = new System.Drawing.Point(198, 70);
            this.TextBoxMySqlPort.Multiline = true;
            this.TextBoxMySqlPort.Name = "TextBoxMySqlPort";
            this.TextBoxMySqlPort.Size = new System.Drawing.Size(89, 24);
            this.TextBoxMySqlPort.TabIndex = 42;
            this.TextBoxMySqlPort.Text = "3306";
            this.TextBoxMySqlPort.TextEditorWidth = 32;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 12);
            this.label4.TabIndex = 41;
            this.label4.Text = "포트 기동여부(기본포트:3306)";
            // 
            // TextBoxMySqlPortStatus
            // 
            this.TextBoxMySqlPortStatus.Id = "2142ee9b-d87f-4cf7-8e81-e12ac7f90a96";
            this.TextBoxMySqlPortStatus.Location = new System.Drawing.Point(315, 70);
            this.TextBoxMySqlPortStatus.Multiline = true;
            this.TextBoxMySqlPortStatus.Name = "TextBoxMySqlPortStatus";
            this.TextBoxMySqlPortStatus.ReadOnly = true;
            this.TextBoxMySqlPortStatus.Size = new System.Drawing.Size(284, 24);
            this.TextBoxMySqlPortStatus.TabIndex = 40;
            this.TextBoxMySqlPortStatus.TextEditorWidth = 278;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 12);
            this.label2.TabIndex = 37;
            this.label2.Text = "서비스 기동여부";
            // 
            // ButtonMySqlStop
            // 
            this.ButtonMySqlStop.Id = "efe6056b-c59c-4e1f-93e5-d3d6312debd6";
            this.ButtonMySqlStop.Location = new System.Drawing.Point(690, 44);
            this.ButtonMySqlStop.Name = "ButtonMySqlStop";
            this.ButtonMySqlStop.Size = new System.Drawing.Size(66, 21);
            this.ButtonMySqlStop.TabIndex = 39;
            this.ButtonMySqlStop.Text = "서비스중지";
            this.ButtonMySqlStop.Click += new System.EventHandler(this.ButtonMySqlStop_Click);
            // 
            // ButtonMySqlStart
            // 
            this.ButtonMySqlStart.Id = "b2df5861-1b0f-4a65-8f93-75043351f4d7";
            this.ButtonMySqlStart.Location = new System.Drawing.Point(615, 44);
            this.ButtonMySqlStart.Name = "ButtonMySqlStart";
            this.ButtonMySqlStart.Size = new System.Drawing.Size(66, 21);
            this.ButtonMySqlStart.TabIndex = 38;
            this.ButtonMySqlStart.Text = "서비스기동";
            this.ButtonMySqlStart.Click += new System.EventHandler(this.ButtonMySqlStart_Click);
            // 
            // TextBoxMySqlServiceStatus
            // 
            this.TextBoxMySqlServiceStatus.Id = "50b8e984-c325-4dc2-b600-52a27ccc4246";
            this.TextBoxMySqlServiceStatus.Location = new System.Drawing.Point(198, 40);
            this.TextBoxMySqlServiceStatus.Multiline = true;
            this.TextBoxMySqlServiceStatus.Name = "TextBoxMySqlServiceStatus";
            this.TextBoxMySqlServiceStatus.ReadOnly = true;
            this.TextBoxMySqlServiceStatus.Size = new System.Drawing.Size(401, 24);
            this.TextBoxMySqlServiceStatus.TabIndex = 36;
            this.TextBoxMySqlServiceStatus.TextEditorWidth = 395;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.button12);
            this.groupBox4.Controls.Add(this.separator11);
            this.groupBox4.Controls.Add(this.RTBoxMySqlComCdCheck);
            this.groupBox4.Controls.Add(this.ButtonMySqlComcdCheck);
            this.groupBox4.Controls.Add(this.separator21);
            this.groupBox4.Controls.Add(this.RTBoxMySqlPing);
            this.groupBox4.Controls.Add(this.ButtonMySqlPing);
            this.groupBox4.Controls.Add(this.separator22);
            this.groupBox4.Id = "8fffbcb5-aab4-43c8-beca-25424480a528";
            this.groupBox4.Location = new System.Drawing.Point(22, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(798, 311);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.Text = "DB 상태";
            // 
            // button12
            // 
            this.button12.Id = "59c134f0-a887-4f34-862c-ab949782aa55";
            this.button12.Location = new System.Drawing.Point(160, 269);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 21);
            this.button12.TabIndex = 30;
            this.button12.Text = "실행";
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // separator11
            // 
            this.separator11.Id = "c5b2a0d4-e004-475c-9e2f-4c397f0c1d3d";
            this.separator11.Location = new System.Drawing.Point(19, 269);
            this.separator11.Name = "separator11";
            this.separator11.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator11.Size = new System.Drawing.Size(138, 21);
            this.separator11.TabIndex = 29;
            this.separator11.Text = "mysql 콘솔 실행";
            // 
            // RTBoxMySqlComCdCheck
            // 
            this.RTBoxMySqlComCdCheck.Location = new System.Drawing.Point(160, 145);
            this.RTBoxMySqlComCdCheck.Name = "RTBoxMySqlComCdCheck";
            this.RTBoxMySqlComCdCheck.Size = new System.Drawing.Size(618, 116);
            this.RTBoxMySqlComCdCheck.TabIndex = 28;
            this.RTBoxMySqlComCdCheck.Text = "select * from t_company;\nselect * from t_user;\nselect * from t_l_code;\nselect * f" +
                "rom t_s_code;";
            // 
            // ButtonMySqlComcdCheck
            // 
            this.ButtonMySqlComcdCheck.Id = "8fce4dc3-10a5-4d3d-82be-ed0836273bb2";
            this.ButtonMySqlComcdCheck.Location = new System.Drawing.Point(17, 166);
            this.ButtonMySqlComcdCheck.Name = "ButtonMySqlComcdCheck";
            this.ButtonMySqlComcdCheck.Size = new System.Drawing.Size(75, 21);
            this.ButtonMySqlComcdCheck.TabIndex = 27;
            this.ButtonMySqlComcdCheck.Text = "테스트";
            this.ButtonMySqlComcdCheck.Click += new System.EventHandler(this.ButtonMySqlComcdCheck_Click);
            // 
            // separator21
            // 
            this.separator21.Id = "56a9ec81-e473-4cf1-9309-6c7f40cf0bc4";
            this.separator21.Location = new System.Drawing.Point(17, 145);
            this.separator21.Name = "separator21";
            this.separator21.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator21.Size = new System.Drawing.Size(140, 21);
            this.separator21.TabIndex = 26;
            this.separator21.Text = "회사코드 점검";
            // 
            // RTBoxMySqlPing
            // 
            this.RTBoxMySqlPing.Location = new System.Drawing.Point(160, 20);
            this.RTBoxMySqlPing.Name = "RTBoxMySqlPing";
            this.RTBoxMySqlPing.Size = new System.Drawing.Size(618, 121);
            this.RTBoxMySqlPing.TabIndex = 25;
            this.RTBoxMySqlPing.Text = "select * from t_user";
            // 
            // ButtonMySqlPing
            // 
            this.ButtonMySqlPing.Id = "a977ef6d-6eb3-4d30-bebe-41195fbdc419";
            this.ButtonMySqlPing.Location = new System.Drawing.Point(19, 43);
            this.ButtonMySqlPing.Name = "ButtonMySqlPing";
            this.ButtonMySqlPing.Size = new System.Drawing.Size(75, 21);
            this.ButtonMySqlPing.TabIndex = 24;
            this.ButtonMySqlPing.Text = "테스트";
            this.ButtonMySqlPing.Click += new System.EventHandler(this.ButtonMySqlPing_Click);
            // 
            // separator22
            // 
            this.separator22.Id = "68712f31-d74f-4bb8-8d7b-0c58e0245d9d";
            this.separator22.Location = new System.Drawing.Point(19, 22);
            this.separator22.Name = "separator22";
            this.separator22.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator22.Size = new System.Drawing.Size(138, 21);
            this.separator22.TabIndex = 19;
            this.separator22.Text = "기본통신(TCP)";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "방화벽 예외등록 여부";
            // 
            // ButtonMySqlFirewallRemove
            // 
            this.ButtonMySqlFirewallRemove.Id = "81cbf4d5-1dad-49f5-bb2d-ba6d68292ce5";
            this.ButtonMySqlFirewallRemove.Location = new System.Drawing.Point(690, 145);
            this.ButtonMySqlFirewallRemove.Name = "ButtonMySqlFirewallRemove";
            this.ButtonMySqlFirewallRemove.Size = new System.Drawing.Size(66, 21);
            this.ButtonMySqlFirewallRemove.TabIndex = 34;
            this.ButtonMySqlFirewallRemove.Text = "등록해제";
            this.ButtonMySqlFirewallRemove.Click += new System.EventHandler(this.ButtonMySqlFirewallRemove_Click);
            // 
            // ButtonMySqlFirewallAdd
            // 
            this.ButtonMySqlFirewallAdd.Id = "1d544eed-3fba-42e2-b072-cd42b9ec881f";
            this.ButtonMySqlFirewallAdd.Location = new System.Drawing.Point(614, 145);
            this.ButtonMySqlFirewallAdd.Name = "ButtonMySqlFirewallAdd";
            this.ButtonMySqlFirewallAdd.Size = new System.Drawing.Size(66, 21);
            this.ButtonMySqlFirewallAdd.TabIndex = 33;
            this.ButtonMySqlFirewallAdd.Text = "예외등록";
            this.ButtonMySqlFirewallAdd.Click += new System.EventHandler(this.ButtonMySqlFirewallAdd_Click);
            // 
            // TextBoxMySQLServerFirewall
            // 
            this.TextBoxMySQLServerFirewall.Id = "48a774c9-96f4-4a5e-ba59-24f9b96c5cc5";
            this.TextBoxMySQLServerFirewall.Location = new System.Drawing.Point(198, 141);
            this.TextBoxMySQLServerFirewall.Multiline = true;
            this.TextBoxMySQLServerFirewall.Name = "TextBoxMySQLServerFirewall";
            this.TextBoxMySQLServerFirewall.ReadOnly = true;
            this.TextBoxMySQLServerFirewall.Size = new System.Drawing.Size(401, 66);
            this.TextBoxMySQLServerFirewall.TabIndex = 31;
            this.TextBoxMySQLServerFirewall.TextEditorWidth = 395;
            // 
            // TabPageServer
            // 
            this.TabPageServer.ActiveControl = null;
            this.TabPageServer.Controls.Add(this.label11);
            this.TabPageServer.Controls.Add(this.separator1);
            this.TabPageServer.Controls.Add(this.separator2);
            this.TabPageServer.Controls.Add(this.ButtonCrmPortCheck);
            this.TabPageServer.Controls.Add(this.TextBoxCrmPort);
            this.TabPageServer.Controls.Add(this.label8);
            this.TabPageServer.Controls.Add(this.TextBoxCrmPortStatus);
            this.TabPageServer.Controls.Add(this.ButtonHealthCheckPortCheck);
            this.TabPageServer.Controls.Add(this.TextBoxHealthCheckPort);
            this.TabPageServer.Controls.Add(this.label9);
            this.TabPageServer.Controls.Add(this.TextBoxHealthCheckPortStatus);
            this.TabPageServer.Controls.Add(this.ButtonMainPortCheck);
            this.TabPageServer.Controls.Add(this.TextBoxMainPort);
            this.TabPageServer.Controls.Add(this.label7);
            this.TabPageServer.Controls.Add(this.TextBoxMainPortStatus);
            this.TabPageServer.Controls.Add(this.groupBox1);
            this.TabPageServer.Controls.Add(this.label1);
            this.TabPageServer.Controls.Add(this.ButtonServerFirewallRemove);
            this.TabPageServer.Controls.Add(this.ButtonServerFirewallAdd);
            this.TabPageServer.Controls.Add(this.TextBoxServerFirewall);
            this.TabPageServer.KeyTip = null;
            this.TabPageServer.Name = "TabPageServer";
            this.TabPageServer.Size = new System.Drawing.Size(833, 589);
            this.TabPageServer.TabIndex = 1;
            this.TabPageServer.Text = "위두서버";
            // 
            // separator1
            // 
            this.separator1.Id = "ab008724-0101-4fa7-94b0-fbc4c6815c9e";
            this.separator1.Location = new System.Drawing.Point(19, 154);
            this.separator1.Name = "separator1";
            this.separator1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator1.Size = new System.Drawing.Size(694, 25);
            this.separator1.TabIndex = 61;
            this.separator1.Text = "방화벽 상태(서버 -> 클라이언트)";
            // 
            // separator2
            // 
            this.separator2.Id = "b71485fc-2033-47d2-b1fe-27d4abf5ea64";
            this.separator2.Location = new System.Drawing.Point(19, 12);
            this.separator2.Name = "separator2";
            this.separator2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator2.Size = new System.Drawing.Size(694, 25);
            this.separator2.TabIndex = 60;
            this.separator2.Text = "서버포트 상태";
            // 
            // ButtonCrmPortCheck
            // 
            this.ButtonCrmPortCheck.Id = "7437100d-bc4b-4750-8420-79f3f8a1d75c";
            this.ButtonCrmPortCheck.Location = new System.Drawing.Point(634, 118);
            this.ButtonCrmPortCheck.Name = "ButtonCrmPortCheck";
            this.ButtonCrmPortCheck.Size = new System.Drawing.Size(66, 21);
            this.ButtonCrmPortCheck.TabIndex = 59;
            this.ButtonCrmPortCheck.Text = "재확인";
            this.ButtonCrmPortCheck.Click += new System.EventHandler(this.ButtonCrmPortCheck_Click);
            // 
            // TextBoxCrmPort
            // 
            this.TextBoxCrmPort.Id = "6cf7daee-0864-4610-ad48-dbd22c73818a";
            this.TextBoxCrmPort.LabelText = "확인포트";
            this.TextBoxCrmPort.Location = new System.Drawing.Point(219, 116);
            this.TextBoxCrmPort.Multiline = true;
            this.TextBoxCrmPort.Name = "TextBoxCrmPort";
            this.TextBoxCrmPort.Size = new System.Drawing.Size(89, 24);
            this.TextBoxCrmPort.TabIndex = 58;
            this.TextBoxCrmPort.Text = "8886";
            this.TextBoxCrmPort.TextEditorWidth = 32;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 12);
            this.label8.TabIndex = 57;
            this.label8.Text = "포트 기동여부(CRM수신:8886)";
            // 
            // TextBoxCrmPortStatus
            // 
            this.TextBoxCrmPortStatus.Id = "0a271420-56d1-46ff-b8f9-950f6eedda36";
            this.TextBoxCrmPortStatus.Location = new System.Drawing.Point(336, 116);
            this.TextBoxCrmPortStatus.Multiline = true;
            this.TextBoxCrmPortStatus.Name = "TextBoxCrmPortStatus";
            this.TextBoxCrmPortStatus.ReadOnly = true;
            this.TextBoxCrmPortStatus.Size = new System.Drawing.Size(284, 24);
            this.TextBoxCrmPortStatus.TabIndex = 56;
            this.TextBoxCrmPortStatus.TextEditorWidth = 278;
            // 
            // ButtonHealthCheckPortCheck
            // 
            this.ButtonHealthCheckPortCheck.Id = "e3743716-135a-43c9-a195-05807a1dbc00";
            this.ButtonHealthCheckPortCheck.Location = new System.Drawing.Point(634, 83);
            this.ButtonHealthCheckPortCheck.Name = "ButtonHealthCheckPortCheck";
            this.ButtonHealthCheckPortCheck.Size = new System.Drawing.Size(66, 21);
            this.ButtonHealthCheckPortCheck.TabIndex = 55;
            this.ButtonHealthCheckPortCheck.Text = "재확인";
            this.ButtonHealthCheckPortCheck.Click += new System.EventHandler(this.ButtonHealthCheckPortCheck_Click);
            // 
            // TextBoxHealthCheckPort
            // 
            this.TextBoxHealthCheckPort.Id = "39927048-8c74-4e40-bb3f-081a76c71ae4";
            this.TextBoxHealthCheckPort.LabelText = "확인포트";
            this.TextBoxHealthCheckPort.Location = new System.Drawing.Point(219, 81);
            this.TextBoxHealthCheckPort.Multiline = true;
            this.TextBoxHealthCheckPort.Name = "TextBoxHealthCheckPort";
            this.TextBoxHealthCheckPort.Size = new System.Drawing.Size(89, 24);
            this.TextBoxHealthCheckPort.TabIndex = 54;
            this.TextBoxHealthCheckPort.Text = "8885";
            this.TextBoxHealthCheckPort.TextEditorWidth = 32;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(20, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 12);
            this.label9.TabIndex = 53;
            this.label9.Text = "포트 기동여부(연동확인:8885)";
            // 
            // TextBoxHealthCheckPortStatus
            // 
            this.TextBoxHealthCheckPortStatus.Id = "1e7fe737-dcdf-4300-9496-6b32d32c93ee";
            this.TextBoxHealthCheckPortStatus.Location = new System.Drawing.Point(336, 81);
            this.TextBoxHealthCheckPortStatus.Multiline = true;
            this.TextBoxHealthCheckPortStatus.Name = "TextBoxHealthCheckPortStatus";
            this.TextBoxHealthCheckPortStatus.ReadOnly = true;
            this.TextBoxHealthCheckPortStatus.Size = new System.Drawing.Size(284, 24);
            this.TextBoxHealthCheckPortStatus.TabIndex = 52;
            this.TextBoxHealthCheckPortStatus.TextEditorWidth = 278;
            // 
            // ButtonMainPortCheck
            // 
            this.ButtonMainPortCheck.Id = "2a3f2376-4db7-4f02-b7f3-b7d6984da694";
            this.ButtonMainPortCheck.Location = new System.Drawing.Point(634, 47);
            this.ButtonMainPortCheck.Name = "ButtonMainPortCheck";
            this.ButtonMainPortCheck.Size = new System.Drawing.Size(66, 21);
            this.ButtonMainPortCheck.TabIndex = 51;
            this.ButtonMainPortCheck.Text = "재확인";
            this.ButtonMainPortCheck.Click += new System.EventHandler(this.ButtonMainPortCheck_Click);
            // 
            // TextBoxMainPort
            // 
            this.TextBoxMainPort.Id = "e8a2212b-dfbb-4382-91c8-46d883b662ab";
            this.TextBoxMainPort.LabelText = "확인포트";
            this.TextBoxMainPort.Location = new System.Drawing.Point(219, 45);
            this.TextBoxMainPort.Multiline = true;
            this.TextBoxMainPort.Name = "TextBoxMainPort";
            this.TextBoxMainPort.Size = new System.Drawing.Size(89, 24);
            this.TextBoxMainPort.TabIndex = 50;
            this.TextBoxMainPort.Text = "8881";
            this.TextBoxMainPort.TextEditorWidth = 32;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(20, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 12);
            this.label7.TabIndex = 49;
            this.label7.Text = "포트 기동여부(기본포트:8881)";
            // 
            // TextBoxMainPortStatus
            // 
            this.TextBoxMainPortStatus.Id = "b0c5caee-d20e-46fd-9cfd-6932865555ec";
            this.TextBoxMainPortStatus.Location = new System.Drawing.Point(336, 45);
            this.TextBoxMainPortStatus.Multiline = true;
            this.TextBoxMainPortStatus.Name = "TextBoxMainPortStatus";
            this.TextBoxMainPortStatus.ReadOnly = true;
            this.TextBoxMainPortStatus.Size = new System.Drawing.Size(284, 24);
            this.TextBoxMainPortStatus.TabIndex = 48;
            this.TextBoxMainPortStatus.TextEditorWidth = 278;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.RTBoxServerBasicTest);
            this.groupBox1.Controls.Add(this.ButtonServerBasicTest);
            this.groupBox1.Controls.Add(this.separator9);
            this.groupBox1.Id = "059de08f-a61b-4339-b804-2b2e1c449708";
            this.groupBox1.Location = new System.Drawing.Point(19, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 161);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.Text = "세부 포트 상태";
            // 
            // RTBoxServerBasicTest
            // 
            this.RTBoxServerBasicTest.Enabled = false;
            this.RTBoxServerBasicTest.Location = new System.Drawing.Point(160, 20);
            this.RTBoxServerBasicTest.Name = "RTBoxServerBasicTest";
            this.RTBoxServerBasicTest.Size = new System.Drawing.Size(618, 121);
            this.RTBoxServerBasicTest.TabIndex = 25;
            this.RTBoxServerBasicTest.Text = "";
            // 
            // ButtonServerBasicTest
            // 
            this.ButtonServerBasicTest.Enabled = false;
            this.ButtonServerBasicTest.Id = "affffebf-d520-4e25-a89d-4157d6656c65";
            this.ButtonServerBasicTest.Location = new System.Drawing.Point(19, 43);
            this.ButtonServerBasicTest.Name = "ButtonServerBasicTest";
            this.ButtonServerBasicTest.Size = new System.Drawing.Size(75, 21);
            this.ButtonServerBasicTest.TabIndex = 24;
            this.ButtonServerBasicTest.Text = "테스트";
            this.ButtonServerBasicTest.Click += new System.EventHandler(this.ButtonServerBasicTest_Click);
            // 
            // separator9
            // 
            this.separator9.Id = "9d51f734-9c59-49f4-9a6d-735d41fd61aa";
            this.separator9.Location = new System.Drawing.Point(19, 22);
            this.separator9.Name = "separator9";
            this.separator9.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator9.Size = new System.Drawing.Size(138, 21);
            this.separator9.TabIndex = 19;
            this.separator9.Text = "기본통신(UDP)";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "방화벽 예외등록 여부";
            // 
            // ButtonServerFirewallRemove
            // 
            this.ButtonServerFirewallRemove.Id = "d504beed-22ea-495e-a774-670600485db6";
            this.ButtonServerFirewallRemove.Location = new System.Drawing.Point(690, 193);
            this.ButtonServerFirewallRemove.Name = "ButtonServerFirewallRemove";
            this.ButtonServerFirewallRemove.Size = new System.Drawing.Size(66, 21);
            this.ButtonServerFirewallRemove.TabIndex = 28;
            this.ButtonServerFirewallRemove.Text = "등록해제";
            this.ButtonServerFirewallRemove.Click += new System.EventHandler(this.ButtonServerFirewallRemove_Click);
            // 
            // ButtonServerFirewallAdd
            // 
            this.ButtonServerFirewallAdd.Id = "e94e33c1-1225-4384-bcfe-5f3efc9a1d88";
            this.ButtonServerFirewallAdd.Location = new System.Drawing.Point(615, 193);
            this.ButtonServerFirewallAdd.Name = "ButtonServerFirewallAdd";
            this.ButtonServerFirewallAdd.Size = new System.Drawing.Size(66, 21);
            this.ButtonServerFirewallAdd.TabIndex = 27;
            this.ButtonServerFirewallAdd.Text = "예외등록";
            this.ButtonServerFirewallAdd.Click += new System.EventHandler(this.ButtonServerFirewallAdd_Click);
            // 
            // TextBoxServerFirewall
            // 
            this.TextBoxServerFirewall.Id = "ab2cd067-cbac-4542-a248-bbaf477e21f5";
            this.TextBoxServerFirewall.Location = new System.Drawing.Point(198, 189);
            this.TextBoxServerFirewall.Multiline = true;
            this.TextBoxServerFirewall.Name = "TextBoxServerFirewall";
            this.TextBoxServerFirewall.ReadOnly = true;
            this.TextBoxServerFirewall.Size = new System.Drawing.Size(401, 53);
            this.TextBoxServerFirewall.TabIndex = 25;
            this.TextBoxServerFirewall.TextEditorWidth = 395;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox13);
            this.groupBox3.Controls.Add(this.button18);
            this.groupBox3.Controls.Add(this.separator16);
            this.groupBox3.Controls.Add(this.richTextBox14);
            this.groupBox3.Controls.Add(this.button19);
            this.groupBox3.Controls.Add(this.separator17);
            this.groupBox3.Controls.Add(this.richTextBox15);
            this.groupBox3.Controls.Add(this.button20);
            this.groupBox3.Controls.Add(this.separator18);
            this.groupBox3.Controls.Add(this.richTextBox16);
            this.groupBox3.Controls.Add(this.button21);
            this.groupBox3.Controls.Add(this.separator19);
            this.groupBox3.Id = "885886ed-a74a-49fb-9d38-837221b24df3";
            this.groupBox3.Location = new System.Drawing.Point(19, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(798, 496);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.Text = "세부 포트 상태";
            // 
            // richTextBox13
            // 
            this.richTextBox13.Location = new System.Drawing.Point(160, 367);
            this.richTextBox13.Name = "richTextBox13";
            this.richTextBox13.Size = new System.Drawing.Size(618, 116);
            this.richTextBox13.TabIndex = 34;
            this.richTextBox13.Text = "";
            // 
            // button18
            // 
            this.button18.Id = "5bc136e6-dacb-4cd5-932b-6839305259fd";
            this.button18.Location = new System.Drawing.Point(17, 388);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 21);
            this.button18.TabIndex = 33;
            this.button18.Text = "테스트";
            // 
            // separator16
            // 
            this.separator16.Id = "e3572736-d434-4b77-8b05-1df513fc34c7";
            this.separator16.Location = new System.Drawing.Point(17, 367);
            this.separator16.Name = "separator16";
            this.separator16.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator16.Size = new System.Drawing.Size(140, 21);
            this.separator16.TabIndex = 32;
            this.separator16.Text = "파일전송(TCP)";
            // 
            // richTextBox14
            // 
            this.richTextBox14.Location = new System.Drawing.Point(160, 269);
            this.richTextBox14.Name = "richTextBox14";
            this.richTextBox14.Size = new System.Drawing.Size(620, 84);
            this.richTextBox14.TabIndex = 31;
            this.richTextBox14.Text = "";
            // 
            // button19
            // 
            this.button19.Id = "f01209c2-0f82-4f6b-bee7-0a4620f71077";
            this.button19.Location = new System.Drawing.Point(17, 290);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 21);
            this.button19.TabIndex = 30;
            this.button19.Text = "테스트";
            // 
            // separator17
            // 
            this.separator17.Id = "05a7edd7-9995-45e4-9861-61d2612f724a";
            this.separator17.Location = new System.Drawing.Point(19, 269);
            this.separator17.Name = "separator17";
            this.separator17.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator17.Size = new System.Drawing.Size(138, 21);
            this.separator17.TabIndex = 29;
            this.separator17.Text = "CRM-서버통신(TCP)";
            // 
            // richTextBox15
            // 
            this.richTextBox15.Location = new System.Drawing.Point(160, 145);
            this.richTextBox15.Name = "richTextBox15";
            this.richTextBox15.Size = new System.Drawing.Size(618, 116);
            this.richTextBox15.TabIndex = 28;
            this.richTextBox15.Text = "";
            // 
            // button20
            // 
            this.button20.Id = "5e12c196-147a-4ea6-bc52-5f6cbfc6b79f";
            this.button20.Location = new System.Drawing.Point(17, 166);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 21);
            this.button20.TabIndex = 27;
            this.button20.Text = "테스트";
            // 
            // separator18
            // 
            this.separator18.Id = "2e728a0c-347b-449a-92c0-cca8b54d1b31";
            this.separator18.Location = new System.Drawing.Point(17, 145);
            this.separator18.Name = "separator18";
            this.separator18.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator18.Size = new System.Drawing.Size(140, 21);
            this.separator18.TabIndex = 26;
            this.separator18.Text = "헬스체크(UDP)";
            // 
            // richTextBox16
            // 
            this.richTextBox16.Location = new System.Drawing.Point(160, 20);
            this.richTextBox16.Name = "richTextBox16";
            this.richTextBox16.Size = new System.Drawing.Size(618, 121);
            this.richTextBox16.TabIndex = 25;
            this.richTextBox16.Text = "select * from t_user";
            // 
            // button21
            // 
            this.button21.Id = "d6d3da52-c75b-4e7d-be15-501a1f8c2f1d";
            this.button21.Location = new System.Drawing.Point(19, 43);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 21);
            this.button21.TabIndex = 24;
            this.button21.Text = "테스트";
            // 
            // separator19
            // 
            this.separator19.Id = "e8a4e1df-c292-43f3-bbf8-025e7b4f9d30";
            this.separator19.Location = new System.Drawing.Point(19, 22);
            this.separator19.Name = "separator19";
            this.separator19.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator19.Size = new System.Drawing.Size(138, 21);
            this.separator19.TabIndex = 19;
            this.separator19.Text = "기본통신(TCP)";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "방화벽 예외등록 여부";
            // 
            // button22
            // 
            this.button22.Id = "75d8ccce-d5c1-4c6d-9a2c-d773f17d9208";
            this.button22.Location = new System.Drawing.Point(690, 52);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(66, 21);
            this.button22.TabIndex = 28;
            this.button22.Text = "등록해제";
            // 
            // separator20
            // 
            this.separator20.Id = "2e06b41f-9dc6-47e9-a95e-2a97fd7913b0";
            this.separator20.Location = new System.Drawing.Point(16, 20);
            this.separator20.Name = "separator20";
            this.separator20.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator20.Size = new System.Drawing.Size(582, 17);
            this.separator20.TabIndex = 24;
            this.separator20.Text = "방화벽 상태(클라이언트->서버)";
            // 
            // button23
            // 
            this.button23.Id = "decd6eb8-1f18-44ec-aa90-a3b6ce2985bc";
            this.button23.Location = new System.Drawing.Point(615, 52);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(66, 21);
            this.button23.TabIndex = 27;
            this.button23.Text = "예외등록";
            // 
            // textBox3
            // 
            this.textBox3.Id = "d5d51359-29f5-4150-92c2-72949021feab";
            this.textBox3.Location = new System.Drawing.Point(198, 48);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(401, 24);
            this.textBox3.TabIndex = 25;
            this.textBox3.TextEditorWidth = 395;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 66);
            this.label6.TabIndex = 62;
            this.label6.Text = "메신저클라이언트와 \r\n메시지통신 테스트를 \r\n위해 준비되었으나, \r\n현재 불필요하여 비활\r\n성화 해둠.";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(251, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(314, 12);
            this.label10.TabIndex = 63;
            this.label10.Text = "mysql 커멘드창 프로그램을 실행하여 직접 mysql 접속함.";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(22, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 32);
            this.label11.TabIndex = 63;
            this.label11.Text = "(*방화벽자체가 비활성화인 \r\n경우 예외등록할 필요없음)";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(22, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 32);
            this.label12.TabIndex = 64;
            this.label12.Text = "(*방화벽자체가 비활성화인 \r\n경우 예외등록할 필요없음)";
            // 
            // FirewallServerStatPage
            // 
            this.Controls.Add(this.TabControlCheckTask);
            this.Name = "FirewallServerStatPage";
            this.Size = new System.Drawing.Size(835, 609);
            this.Load += new System.EventHandler(this.FirewallStatPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabControlCheckTask)).EndInit();
            this.TabPageMySQLServer.ResumeLayout(false);
            this.TabPageMySQLServer.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.TabPageServer.ResumeLayout(false);
            this.TabPageServer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TabControlCheckTask;
        private TabPage TabPageServer;
        private Label label1;
        private Button ButtonServerFirewallRemove;
        private Button ButtonServerFirewallAdd;
        private TextBox TextBoxServerFirewall;
        private GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox RTBoxServerBasicTest;
        private Button ButtonServerBasicTest;
        private Separator separator9;
        private TabPage TabPageMySQLServer;
        private GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox13;
        private Button button18;
        private Separator separator16;
        private System.Windows.Forms.RichTextBox richTextBox14;
        private Button button19;
        private Separator separator17;
        private System.Windows.Forms.RichTextBox richTextBox15;
        private Button button20;
        private Separator separator18;
        private System.Windows.Forms.RichTextBox richTextBox16;
        private Button button21;
        private Separator separator19;
        private Label label3;
        private Button button22;
        private Separator separator20;
        private Button button23;
        private TextBox textBox3;
        private GroupBox groupBox4;
        private Button button12;
        private Separator separator11;
        private System.Windows.Forms.RichTextBox RTBoxMySqlComCdCheck;
        private Button ButtonMySqlComcdCheck;
        private Separator separator21;
        private System.Windows.Forms.RichTextBox RTBoxMySqlPing;
        private Button ButtonMySqlPing;
        private Separator separator22;
        private Label label5;
        private Button ButtonMySqlFirewallRemove;
        private Button ButtonMySqlFirewallAdd;
        private TextBox TextBoxMySQLServerFirewall;
        private Label label2;
        private Button ButtonMySqlStop;
        private Button ButtonMySqlStart;
        private TextBox TextBoxMySqlServiceStatus;
        private TextBox TextBoxMySqlPort;
        private Label label4;
        private TextBox TextBoxMySqlPortStatus;
        private Button ButtonPortCheck;
        private Button ButtonCrmPortCheck;
        private TextBox TextBoxCrmPort;
        private Label label8;
        private TextBox TextBoxCrmPortStatus;
        private Button ButtonHealthCheckPortCheck;
        private TextBox TextBoxHealthCheckPort;
        private Label label9;
        private TextBox TextBoxHealthCheckPortStatus;
        private Button ButtonMainPortCheck;
        private TextBox TextBoxMainPort;
        private Label label7;
        private TextBox TextBoxMainPortStatus;
        private Separator separator1;
        private Separator separator2;
        private Separator separator4;
        private Separator separator3;
        private Label label6;
        private Label label12;
        private Label label10;
        private Label label11;
    }
}
