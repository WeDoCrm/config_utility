namespace Elegant.Ui.Samples.ControlsSample
{
    partial class FirewallClientStatPage
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
            this.TabPageMsgr = new Elegant.Ui.TabPage();
            this.label2 = new Elegant.Ui.Label();
            this.ButtonMsgrFirewallRemove = new Elegant.Ui.Button();
            this.TextBoxMsgrFirewall = new Elegant.Ui.TextBox();
            this.label4 = new Elegant.Ui.Label();
            this.ButtonsGroupBox = new Elegant.Ui.GroupBox();
            this.label8 = new Elegant.Ui.Label();
            this.label7 = new Elegant.Ui.Label();
            this.label6 = new Elegant.Ui.Label();
            this.label1 = new Elegant.Ui.Label();
            this.RTBoxMsgrFTPTest = new System.Windows.Forms.RichTextBox();
            this.ButtonMsgrFTPTest = new Elegant.Ui.Button();
            this.separator5 = new Elegant.Ui.Separator();
            this.RTBoxMsgrCRMTest = new System.Windows.Forms.RichTextBox();
            this.ButtonMsgrCRMTest = new Elegant.Ui.Button();
            this.separator4 = new Elegant.Ui.Separator();
            this.RTBoxMsgrHealthCheck = new System.Windows.Forms.RichTextBox();
            this.ButtonMsgrHealthCheck = new Elegant.Ui.Button();
            this.separator3 = new Elegant.Ui.Separator();
            this.RTBoxMsgrBasicTest = new System.Windows.Forms.RichTextBox();
            this.ButtonMsgrBasicTest = new Elegant.Ui.Button();
            this.separator1 = new Elegant.Ui.Separator();
            this.separator2 = new Elegant.Ui.Separator();
            this.ButtonMsgrFirewallAdd = new Elegant.Ui.Button();
            this.TabPageMySQLMsgr = new Elegant.Ui.TabPage();
            this.label11 = new Elegant.Ui.Label();
            this.ButtonMySqlFirewallRemove = new Elegant.Ui.Button();
            this.TextBoxMySqlFirewall = new Elegant.Ui.TextBox();
            this.label5 = new Elegant.Ui.Label();
            this.groupBox1 = new Elegant.Ui.GroupBox();
            this.RTBoxCompanyCdTest = new System.Windows.Forms.RichTextBox();
            this.ButtonCompanyCdTest = new Elegant.Ui.Button();
            this.separator8 = new Elegant.Ui.Separator();
            this.RTBoxMySqlBasicTest = new System.Windows.Forms.RichTextBox();
            this.ButtonMySqlBasicTest = new Elegant.Ui.Button();
            this.separator9 = new Elegant.Ui.Separator();
            this.separator10 = new Elegant.Ui.Separator();
            this.ButtonMySqlFirewallAdd = new Elegant.Ui.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.TabControlCheckTask)).BeginInit();
            this.TabPageMsgr.SuspendLayout();
            this.ButtonsGroupBox.SuspendLayout();
            this.TabPageMySQLMsgr.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlCheckTask
            // 
            this.TabControlCheckTask.Location = new System.Drawing.Point(0, 0);
            this.TabControlCheckTask.Name = "TabControlCheckTask";
            this.TabControlCheckTask.SelectedTabPage = this.TabPageMsgr;
            this.TabControlCheckTask.Size = new System.Drawing.Size(835, 609);
            this.TabControlCheckTask.TabIndex = 23;
            this.TabControlCheckTask.TabPages.AddRange(new Elegant.Ui.TabPage[] {
            this.TabPageMsgr,
            this.TabPageMySQLMsgr});
            this.TabControlCheckTask.Text = "서버";
            this.TabControlCheckTask.SelectedTabPageChanged += new Elegant.Ui.TabPageChangedEventHandler(this.TabControlCheckTask_SelectedTabPageChanged);
            // 
            // TabPageMsgr
            // 
            this.TabPageMsgr.ActiveControl = null;
            this.TabPageMsgr.Controls.Add(this.label2);
            this.TabPageMsgr.Controls.Add(this.ButtonMsgrFirewallRemove);
            this.TabPageMsgr.Controls.Add(this.TextBoxMsgrFirewall);
            this.TabPageMsgr.Controls.Add(this.label4);
            this.TabPageMsgr.Controls.Add(this.ButtonsGroupBox);
            this.TabPageMsgr.Controls.Add(this.separator2);
            this.TabPageMsgr.Controls.Add(this.ButtonMsgrFirewallAdd);
            this.TabPageMsgr.KeyTip = null;
            this.TabPageMsgr.Name = "TabPageMsgr";
            this.TabPageMsgr.Size = new System.Drawing.Size(833, 589);
            this.TabPageMsgr.TabIndex = 0;
            this.TabPageMsgr.Text = "메신저/CRM";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 19);
            this.label2.TabIndex = 64;
            this.label2.Text = "(*방화벽자체가 비활성화인 경우 예외등록할 필요없음)";
            // 
            // ButtonMsgrFirewallRemove
            // 
            this.ButtonMsgrFirewallRemove.Id = "cdebde07-d76e-4d47-b512-e7e98a25bc84";
            this.ButtonMsgrFirewallRemove.Location = new System.Drawing.Point(734, 55);
            this.ButtonMsgrFirewallRemove.Name = "ButtonMsgrFirewallRemove";
            this.ButtonMsgrFirewallRemove.Size = new System.Drawing.Size(66, 21);
            this.ButtonMsgrFirewallRemove.TabIndex = 35;
            this.ButtonMsgrFirewallRemove.Text = "등록해제";
            this.ButtonMsgrFirewallRemove.Click += new System.EventHandler(this.ButtonMsgrFirewallRemove_Click);
            // 
            // TextBoxMsgrFirewall
            // 
            this.TextBoxMsgrFirewall.Id = "2571e8b9-6dbc-4958-adc3-5a0744ad26e2";
            this.TextBoxMsgrFirewall.Location = new System.Drawing.Point(143, 55);
            this.TextBoxMsgrFirewall.Multiline = true;
            this.TextBoxMsgrFirewall.Name = "TextBoxMsgrFirewall";
            this.TextBoxMsgrFirewall.ReadOnly = true;
            this.TextBoxMsgrFirewall.Size = new System.Drawing.Size(507, 41);
            this.TextBoxMsgrFirewall.TabIndex = 34;
            this.TextBoxMsgrFirewall.TextEditorWidth = 501;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "방화벽 예외등록 여부";
            // 
            // ButtonsGroupBox
            // 
            this.ButtonsGroupBox.Controls.Add(this.label8);
            this.ButtonsGroupBox.Controls.Add(this.label7);
            this.ButtonsGroupBox.Controls.Add(this.label6);
            this.ButtonsGroupBox.Controls.Add(this.label1);
            this.ButtonsGroupBox.Controls.Add(this.RTBoxMsgrFTPTest);
            this.ButtonsGroupBox.Controls.Add(this.ButtonMsgrFTPTest);
            this.ButtonsGroupBox.Controls.Add(this.separator5);
            this.ButtonsGroupBox.Controls.Add(this.RTBoxMsgrCRMTest);
            this.ButtonsGroupBox.Controls.Add(this.ButtonMsgrCRMTest);
            this.ButtonsGroupBox.Controls.Add(this.separator4);
            this.ButtonsGroupBox.Controls.Add(this.RTBoxMsgrHealthCheck);
            this.ButtonsGroupBox.Controls.Add(this.ButtonMsgrHealthCheck);
            this.ButtonsGroupBox.Controls.Add(this.separator3);
            this.ButtonsGroupBox.Controls.Add(this.RTBoxMsgrBasicTest);
            this.ButtonsGroupBox.Controls.Add(this.ButtonMsgrBasicTest);
            this.ButtonsGroupBox.Controls.Add(this.separator1);
            this.ButtonsGroupBox.Id = "61deb040-d2fd-47bb-8e59-1aa098d72b79";
            this.ButtonsGroupBox.Location = new System.Drawing.Point(19, 131);
            this.ButtonsGroupBox.Name = "ButtonsGroupBox";
            this.ButtonsGroupBox.Size = new System.Drawing.Size(798, 452);
            this.ButtonsGroupBox.TabIndex = 23;
            this.ButtonsGroupBox.Text = "세부 포트 상태";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 32);
            this.label8.TabIndex = 67;
            this.label8.Text = "(현재 사용안함.)";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 32);
            this.label7.TabIndex = 66;
            this.label7.Text = "(오류로그가 없으면 정상)";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 32);
            this.label6.TabIndex = 65;
            this.label6.Text = "(오류로그가 없으면 정상)";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 64;
            this.label1.Text = "(오류로그가 없으면 정상)";
            // 
            // RTBoxMsgrFTPTest
            // 
            this.RTBoxMsgrFTPTest.Enabled = false;
            this.RTBoxMsgrFTPTest.Location = new System.Drawing.Point(161, 338);
            this.RTBoxMsgrFTPTest.Name = "RTBoxMsgrFTPTest";
            this.RTBoxMsgrFTPTest.Size = new System.Drawing.Size(618, 100);
            this.RTBoxMsgrFTPTest.TabIndex = 34;
            this.RTBoxMsgrFTPTest.Text = "";
            // 
            // ButtonMsgrFTPTest
            // 
            this.ButtonMsgrFTPTest.Enabled = false;
            this.ButtonMsgrFTPTest.Id = "3a487728-a1ec-4b07-927d-2e4d13ad2b5b";
            this.ButtonMsgrFTPTest.Location = new System.Drawing.Point(19, 362);
            this.ButtonMsgrFTPTest.Name = "ButtonMsgrFTPTest";
            this.ButtonMsgrFTPTest.Size = new System.Drawing.Size(138, 21);
            this.ButtonMsgrFTPTest.TabIndex = 33;
            this.ButtonMsgrFTPTest.Text = "테스트";
            this.ButtonMsgrFTPTest.Click += new System.EventHandler(this.ButtonMsgrFTPTest_Click);
            // 
            // separator5
            // 
            this.separator5.Id = "c4c2be13-4917-4a15-a47d-ba152dd9709f";
            this.separator5.Location = new System.Drawing.Point(18, 338);
            this.separator5.Name = "separator5";
            this.separator5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator5.Size = new System.Drawing.Size(140, 21);
            this.separator5.TabIndex = 32;
            this.separator5.Text = "파일전송(TCP)";
            // 
            // RTBoxMsgrCRMTest
            // 
            this.RTBoxMsgrCRMTest.Location = new System.Drawing.Point(161, 233);
            this.RTBoxMsgrCRMTest.Name = "RTBoxMsgrCRMTest";
            this.RTBoxMsgrCRMTest.Size = new System.Drawing.Size(618, 100);
            this.RTBoxMsgrCRMTest.TabIndex = 31;
            this.RTBoxMsgrCRMTest.Text = "";
            // 
            // ButtonMsgrCRMTest
            // 
            this.ButtonMsgrCRMTest.Id = "8e3deaed-52a2-49fa-8998-cd081fdfc829";
            this.ButtonMsgrCRMTest.Location = new System.Drawing.Point(19, 257);
            this.ButtonMsgrCRMTest.Name = "ButtonMsgrCRMTest";
            this.ButtonMsgrCRMTest.Size = new System.Drawing.Size(138, 21);
            this.ButtonMsgrCRMTest.TabIndex = 30;
            this.ButtonMsgrCRMTest.Text = "테스트";
            this.ButtonMsgrCRMTest.Click += new System.EventHandler(this.ButtonMsgrCRMTest_Click);
            // 
            // separator4
            // 
            this.separator4.Id = "f05895e0-7998-4807-83b8-b4940386098e";
            this.separator4.Location = new System.Drawing.Point(20, 233);
            this.separator4.Name = "separator4";
            this.separator4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator4.Size = new System.Drawing.Size(138, 21);
            this.separator4.TabIndex = 29;
            this.separator4.Text = "CRM-서버통신(TCP)";
            // 
            // RTBoxMsgrHealthCheck
            // 
            this.RTBoxMsgrHealthCheck.Location = new System.Drawing.Point(161, 128);
            this.RTBoxMsgrHealthCheck.Name = "RTBoxMsgrHealthCheck";
            this.RTBoxMsgrHealthCheck.Size = new System.Drawing.Size(618, 100);
            this.RTBoxMsgrHealthCheck.TabIndex = 28;
            this.RTBoxMsgrHealthCheck.Text = "";
            // 
            // ButtonMsgrHealthCheck
            // 
            this.ButtonMsgrHealthCheck.Id = "0e7e55c0-bc02-4025-b284-20a3dff70162";
            this.ButtonMsgrHealthCheck.Location = new System.Drawing.Point(19, 152);
            this.ButtonMsgrHealthCheck.Name = "ButtonMsgrHealthCheck";
            this.ButtonMsgrHealthCheck.Size = new System.Drawing.Size(138, 21);
            this.ButtonMsgrHealthCheck.TabIndex = 27;
            this.ButtonMsgrHealthCheck.Text = "테스트";
            this.ButtonMsgrHealthCheck.Click += new System.EventHandler(this.ButtonMsgrHealthCheck_Click);
            // 
            // separator3
            // 
            this.separator3.Id = "5c81ed44-1c4e-4c7a-a484-bb08e87492bc";
            this.separator3.Location = new System.Drawing.Point(18, 128);
            this.separator3.Name = "separator3";
            this.separator3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator3.Size = new System.Drawing.Size(140, 21);
            this.separator3.TabIndex = 26;
            this.separator3.Text = "헬스체크(UDP)";
            // 
            // RTBoxMsgrBasicTest
            // 
            this.RTBoxMsgrBasicTest.Location = new System.Drawing.Point(161, 23);
            this.RTBoxMsgrBasicTest.Name = "RTBoxMsgrBasicTest";
            this.RTBoxMsgrBasicTest.Size = new System.Drawing.Size(618, 100);
            this.RTBoxMsgrBasicTest.TabIndex = 25;
            this.RTBoxMsgrBasicTest.Text = "";
            // 
            // ButtonMsgrBasicTest
            // 
            this.ButtonMsgrBasicTest.Id = "d000f440-e816-435b-b69a-3f26e7fbcf92";
            this.ButtonMsgrBasicTest.Location = new System.Drawing.Point(19, 49);
            this.ButtonMsgrBasicTest.Name = "ButtonMsgrBasicTest";
            this.ButtonMsgrBasicTest.Size = new System.Drawing.Size(138, 21);
            this.ButtonMsgrBasicTest.TabIndex = 24;
            this.ButtonMsgrBasicTest.Text = "테스트";
            this.ButtonMsgrBasicTest.Click += new System.EventHandler(this.ButtonMsgrBasicTest_Click);
            // 
            // separator1
            // 
            this.separator1.Id = "2cdec66c-2d49-4797-bfdd-2a9d9610ba50";
            this.separator1.Location = new System.Drawing.Point(20, 25);
            this.separator1.Name = "separator1";
            this.separator1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator1.Size = new System.Drawing.Size(138, 21);
            this.separator1.TabIndex = 19;
            this.separator1.Text = "기본통신(UDP)";
            // 
            // separator2
            // 
            this.separator2.Id = "d1345f3f-1616-438b-8629-2fc1eb816866";
            this.separator2.Location = new System.Drawing.Point(16, 13);
            this.separator2.Name = "separator2";
            this.separator2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator2.Size = new System.Drawing.Size(694, 27);
            this.separator2.TabIndex = 29;
            this.separator2.Text = "방화벽 상태(클라이언트->서버)";
            // 
            // ButtonMsgrFirewallAdd
            // 
            this.ButtonMsgrFirewallAdd.Id = "a98d9559-b61b-49fd-b8c6-04e764e00df9";
            this.ButtonMsgrFirewallAdd.Location = new System.Drawing.Point(659, 55);
            this.ButtonMsgrFirewallAdd.Name = "ButtonMsgrFirewallAdd";
            this.ButtonMsgrFirewallAdd.Size = new System.Drawing.Size(66, 21);
            this.ButtonMsgrFirewallAdd.TabIndex = 32;
            this.ButtonMsgrFirewallAdd.Text = "예외등록";
            this.ButtonMsgrFirewallAdd.Click += new System.EventHandler(this.ButtonMsgrFirewallAdd_Click);
            // 
            // TabPageMySQLMsgr
            // 
            this.TabPageMySQLMsgr.ActiveControl = null;
            this.TabPageMySQLMsgr.Controls.Add(this.label11);
            this.TabPageMySQLMsgr.Controls.Add(this.ButtonMySqlFirewallRemove);
            this.TabPageMySQLMsgr.Controls.Add(this.TextBoxMySqlFirewall);
            this.TabPageMySQLMsgr.Controls.Add(this.label5);
            this.TabPageMySQLMsgr.Controls.Add(this.groupBox1);
            this.TabPageMySQLMsgr.Controls.Add(this.separator10);
            this.TabPageMySQLMsgr.Controls.Add(this.ButtonMySqlFirewallAdd);
            this.TabPageMySQLMsgr.KeyTip = null;
            this.TabPageMySQLMsgr.Name = "TabPageMySQLMsgr";
            this.TabPageMySQLMsgr.Size = new System.Drawing.Size(833, 589);
            this.TabPageMySQLMsgr.TabIndex = 2;
            this.TabPageMySQLMsgr.Text = "MySQL(메신저/CRM)";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(25, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 32);
            this.label11.TabIndex = 64;
            this.label11.Text = "(*방화벽자체가 비활성화인 \r\n경우 예외등록할 필요없음)";
            // 
            // ButtonMySqlFirewallRemove
            // 
            this.ButtonMySqlFirewallRemove.Id = "9956e29f-40f0-47da-b157-9354f3b22227";
            this.ButtonMySqlFirewallRemove.Location = new System.Drawing.Point(745, 52);
            this.ButtonMySqlFirewallRemove.Name = "ButtonMySqlFirewallRemove";
            this.ButtonMySqlFirewallRemove.Size = new System.Drawing.Size(66, 21);
            this.ButtonMySqlFirewallRemove.TabIndex = 43;
            this.ButtonMySqlFirewallRemove.Text = "등록해제";
            this.ButtonMySqlFirewallRemove.Click += new System.EventHandler(this.ButtonMySqlFirewallRemove_Click);
            // 
            // TextBoxMySqlFirewall
            // 
            this.TextBoxMySqlFirewall.Id = "42cb680e-9f1d-48ff-91da-f661ac2c561f";
            this.TextBoxMySqlFirewall.Location = new System.Drawing.Point(143, 55);
            this.TextBoxMySqlFirewall.Multiline = true;
            this.TextBoxMySqlFirewall.Name = "TextBoxMySqlFirewall";
            this.TextBoxMySqlFirewall.ReadOnly = true;
            this.TextBoxMySqlFirewall.Size = new System.Drawing.Size(507, 41);
            this.TextBoxMySqlFirewall.TabIndex = 42;
            this.TextBoxMySqlFirewall.TextEditorWidth = 501;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 12);
            this.label5.TabIndex = 40;
            this.label5.Text = "방화벽 예외등록 여부";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RTBoxCompanyCdTest);
            this.groupBox1.Controls.Add(this.ButtonCompanyCdTest);
            this.groupBox1.Controls.Add(this.separator8);
            this.groupBox1.Controls.Add(this.RTBoxMySqlBasicTest);
            this.groupBox1.Controls.Add(this.ButtonMySqlBasicTest);
            this.groupBox1.Controls.Add(this.separator9);
            this.groupBox1.Id = "d4bd28ad-5e88-4a8c-ba30-b50b000fe6a4";
            this.groupBox1.Location = new System.Drawing.Point(19, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 382);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.Text = "세부 포트 상태";
            // 
            // RTBoxCompanyCdTest
            // 
            this.RTBoxCompanyCdTest.Location = new System.Drawing.Point(161, 128);
            this.RTBoxCompanyCdTest.Name = "RTBoxCompanyCdTest";
            this.RTBoxCompanyCdTest.Size = new System.Drawing.Size(618, 100);
            this.RTBoxCompanyCdTest.TabIndex = 28;
            this.RTBoxCompanyCdTest.Text = "";
            // 
            // ButtonCompanyCdTest
            // 
            this.ButtonCompanyCdTest.Id = "b9d77bda-cfea-465b-bfe2-57162ec02bb1";
            this.ButtonCompanyCdTest.Location = new System.Drawing.Point(19, 152);
            this.ButtonCompanyCdTest.Name = "ButtonCompanyCdTest";
            this.ButtonCompanyCdTest.Size = new System.Drawing.Size(138, 21);
            this.ButtonCompanyCdTest.TabIndex = 27;
            this.ButtonCompanyCdTest.Text = "테스트";
            this.ButtonCompanyCdTest.Click += new System.EventHandler(this.ButtonCompanyCdTest_Click);
            // 
            // separator8
            // 
            this.separator8.Id = "e3aced70-430d-4d73-b6d5-6a572f62be93";
            this.separator8.Location = new System.Drawing.Point(18, 128);
            this.separator8.Name = "separator8";
            this.separator8.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator8.Size = new System.Drawing.Size(140, 21);
            this.separator8.TabIndex = 26;
            this.separator8.Text = "회사코드확인";
            // 
            // RTBoxMySqlBasicTest
            // 
            this.RTBoxMySqlBasicTest.Location = new System.Drawing.Point(161, 23);
            this.RTBoxMySqlBasicTest.Name = "RTBoxMySqlBasicTest";
            this.RTBoxMySqlBasicTest.Size = new System.Drawing.Size(618, 100);
            this.RTBoxMySqlBasicTest.TabIndex = 25;
            this.RTBoxMySqlBasicTest.Text = "";
            // 
            // ButtonMySqlBasicTest
            // 
            this.ButtonMySqlBasicTest.Id = "aca897c2-ab50-4e74-a26d-974cbfaaf003";
            this.ButtonMySqlBasicTest.Location = new System.Drawing.Point(19, 49);
            this.ButtonMySqlBasicTest.Name = "ButtonMySqlBasicTest";
            this.ButtonMySqlBasicTest.Size = new System.Drawing.Size(138, 21);
            this.ButtonMySqlBasicTest.TabIndex = 24;
            this.ButtonMySqlBasicTest.Text = "테스트";
            this.ButtonMySqlBasicTest.Click += new System.EventHandler(this.ButtonMySqlBasicTest_Click);
            // 
            // separator9
            // 
            this.separator9.Id = "cf835e69-d58b-4e24-a011-177411e29f6f";
            this.separator9.Location = new System.Drawing.Point(20, 25);
            this.separator9.Name = "separator9";
            this.separator9.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator9.Size = new System.Drawing.Size(138, 21);
            this.separator9.TabIndex = 19;
            this.separator9.Text = "기본통신(TCP)";
            // 
            // separator10
            // 
            this.separator10.Id = "3903e987-d72e-447c-a2ac-50e3802f59c2";
            this.separator10.Location = new System.Drawing.Point(16, 13);
            this.separator10.Name = "separator10";
            this.separator10.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator10.Size = new System.Drawing.Size(694, 27);
            this.separator10.TabIndex = 39;
            this.separator10.Text = "방화벽 상태(클라이언트->서버)";
            // 
            // ButtonMySqlFirewallAdd
            // 
            this.ButtonMySqlFirewallAdd.Id = "7b528b1e-f79b-4685-a213-018958cebe30";
            this.ButtonMySqlFirewallAdd.Location = new System.Drawing.Point(670, 52);
            this.ButtonMySqlFirewallAdd.Name = "ButtonMySqlFirewallAdd";
            this.ButtonMySqlFirewallAdd.Size = new System.Drawing.Size(66, 21);
            this.ButtonMySqlFirewallAdd.TabIndex = 41;
            this.ButtonMySqlFirewallAdd.Text = "예외등록";
            this.ButtonMySqlFirewallAdd.Click += new System.EventHandler(this.ButtonMySqlFirewallAdd_Click);
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
            this.groupBox3.Id = "1ad24018-a8ed-4259-8297-6616178e43e6";
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
            this.button18.Id = "4fc6e9e0-0de4-4d31-9e48-8ea71c71f423";
            this.button18.Location = new System.Drawing.Point(17, 388);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 21);
            this.button18.TabIndex = 33;
            this.button18.Text = "테스트";
            // 
            // separator16
            // 
            this.separator16.Id = "faddeaec-cd39-494f-80c5-fb857ff4c6e9";
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
            this.button19.Id = "21f08aa4-4152-4d40-b1c6-b771ffda91b7";
            this.button19.Location = new System.Drawing.Point(17, 290);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 21);
            this.button19.TabIndex = 30;
            this.button19.Text = "테스트";
            // 
            // separator17
            // 
            this.separator17.Id = "84225cc0-2ddf-455e-973f-4f765709c8dc";
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
            this.button20.Id = "f388f32e-175e-4b58-bc1a-d67fee8a47c4";
            this.button20.Location = new System.Drawing.Point(17, 166);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 21);
            this.button20.TabIndex = 27;
            this.button20.Text = "테스트";
            // 
            // separator18
            // 
            this.separator18.Id = "066d2abb-a57a-43e9-b31e-57469346dc49";
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
            this.button21.Id = "9a7b494c-bff2-45cb-84d0-cbf1591972fd";
            this.button21.Location = new System.Drawing.Point(19, 43);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 21);
            this.button21.TabIndex = 24;
            this.button21.Text = "테스트";
            // 
            // separator19
            // 
            this.separator19.Id = "3919f672-8923-4bd7-a434-e2d6d9f3d5a6";
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
            this.button22.Id = "c74966dc-bf01-4fee-9b12-3d2a37d30645";
            this.button22.Location = new System.Drawing.Point(690, 52);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(66, 21);
            this.button22.TabIndex = 28;
            this.button22.Text = "등록해제";
            // 
            // separator20
            // 
            this.separator20.Id = "21922fde-5e81-4131-868a-939d9b505edf";
            this.separator20.Location = new System.Drawing.Point(16, 20);
            this.separator20.Name = "separator20";
            this.separator20.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.separator20.Size = new System.Drawing.Size(582, 17);
            this.separator20.TabIndex = 24;
            this.separator20.Text = "방화벽 상태(클라이언트->서버)";
            // 
            // button23
            // 
            this.button23.Id = "c5d5024e-6633-4308-a0e3-4dfb3d193c9f";
            this.button23.Location = new System.Drawing.Point(615, 52);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(66, 21);
            this.button23.TabIndex = 27;
            this.button23.Text = "예외등록";
            // 
            // textBox3
            // 
            this.textBox3.Id = "f427dde4-4150-4bb3-9f78-7738d0717570";
            this.textBox3.Location = new System.Drawing.Point(198, 48);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(401, 24);
            this.textBox3.TabIndex = 25;
            this.textBox3.TextEditorWidth = 395;
            // 
            // FirewallClientStatPage
            // 
            this.Controls.Add(this.TabControlCheckTask);
            this.Name = "FirewallClientStatPage";
            this.Size = new System.Drawing.Size(835, 609);
            this.Load += new System.EventHandler(this.FirewallStatPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabControlCheckTask)).EndInit();
            this.TabPageMsgr.ResumeLayout(false);
            this.TabPageMsgr.PerformLayout();
            this.ButtonsGroupBox.ResumeLayout(false);
            this.ButtonsGroupBox.PerformLayout();
            this.TabPageMySQLMsgr.ResumeLayout(false);
            this.TabPageMySQLMsgr.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TabControlCheckTask;
        private TabPage TabPageMsgr;
        private TabPage TabPageMySQLMsgr;
        private Label label4;
        private GroupBox ButtonsGroupBox;
        private System.Windows.Forms.RichTextBox RTBoxMsgrFTPTest;
        private Button ButtonMsgrFTPTest;
        private Separator separator5;
        private System.Windows.Forms.RichTextBox RTBoxMsgrCRMTest;
        private Button ButtonMsgrCRMTest;
        private Separator separator4;
        private System.Windows.Forms.RichTextBox RTBoxMsgrHealthCheck;
        private Button ButtonMsgrHealthCheck;
        private Separator separator3;
        private System.Windows.Forms.RichTextBox RTBoxMsgrBasicTest;
        private Button ButtonMsgrBasicTest;
        private Separator separator1;
        private Separator separator2;
        private Button ButtonMsgrFirewallAdd;
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
        private TextBox TextBoxMsgrFirewall;
        private Button ButtonMsgrFirewallRemove;
        private Button ButtonMySqlFirewallRemove;
        private TextBox TextBoxMySqlFirewall;
        private Label label5;
        private GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox RTBoxCompanyCdTest;
        private Button ButtonCompanyCdTest;
        private Separator separator8;
        private System.Windows.Forms.RichTextBox RTBoxMySqlBasicTest;
        private Button ButtonMySqlBasicTest;
        private Separator separator9;
        private Separator separator10;
        private Button ButtonMySqlFirewallAdd;
        private Label label1;
        private Label label11;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}
