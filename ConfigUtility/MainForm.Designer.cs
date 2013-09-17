using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Elegant.Ui.Samples.ControlsSample
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ControlsNavigationBar = new Elegant.Ui.NavigationBar();
            this.FirewallServerStatPageToggleButton = new Elegant.Ui.ToggleButton();
            this.FirewallClientStatPageToggleButton = new Elegant.Ui.ToggleButton();
            this.toggleButton3 = new Elegant.Ui.ToggleButton();
            this.toggleButton1 = new Elegant.Ui.ToggleButton();
            this.TopPanel = new Elegant.Ui.Panel();
            this.RadioButtonClientMode = new Elegant.Ui.RadioButton();
            this.RadioButtonServerMode = new Elegant.Ui.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aquaSkin1 = new SkinSoft.AquaSkin.AquaSkin(this.components);
            this.ControlsSamplePageContainer = new Elegant.Ui.Samples.ControlsSample.ControlsSamplePageContainer();
            this.ControlsNavigationBar.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aquaSkin1)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlsNavigationBar
            // 
            this.ControlsNavigationBar.Controls.Add(this.FirewallServerStatPageToggleButton);
            this.ControlsNavigationBar.Controls.Add(this.FirewallClientStatPageToggleButton);
            this.ControlsNavigationBar.Controls.Add(this.toggleButton3);
            this.ControlsNavigationBar.Controls.Add(this.toggleButton1);
            this.ControlsNavigationBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlsNavigationBar.Id = "cba39524-c60d-4bb0-8dcf-15df5e41b782";
            this.ControlsNavigationBar.Location = new System.Drawing.Point(0, 0);
            this.ControlsNavigationBar.Name = "ControlsNavigationBar";
            this.ControlsNavigationBar.Size = new System.Drawing.Size(173, 730);
            this.ControlsNavigationBar.TabIndex = 0;
            this.ControlsNavigationBar.Text = "ControlsNavigationBar";
            this.ControlsNavigationBar.UseTabToNavigate = false;
            this.ControlsNavigationBar.WrapNavigation = false;
            // 
            // FirewallServerStatPageToggleButton
            // 
            this.FirewallServerStatPageToggleButton.Id = "a44f7346-8607-4095-8626-1bda22b82d4b";
            this.FirewallServerStatPageToggleButton.Location = new System.Drawing.Point(2, 2);
            this.FirewallServerStatPageToggleButton.Name = "FirewallServerStatPageToggleButton";
            this.FirewallServerStatPageToggleButton.RadioGroupName = "NavigationBarToggleButtons";
            this.FirewallServerStatPageToggleButton.Size = new System.Drawing.Size(169, 24);
            this.FirewallServerStatPageToggleButton.TabIndex = 15;
            this.FirewallServerStatPageToggleButton.Text = "방화벽관리(WeDo 서버)";
            this.FirewallServerStatPageToggleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FirewallServerStatPageToggleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // FirewallClientStatPageToggleButton
            // 
            this.FirewallClientStatPageToggleButton.Id = "0ae6abbf-8a21-43c8-a625-930390ec20d2";
            this.FirewallClientStatPageToggleButton.Location = new System.Drawing.Point(2, 28);
            this.FirewallClientStatPageToggleButton.Name = "FirewallClientStatPageToggleButton";
            this.FirewallClientStatPageToggleButton.RadioGroupName = "NavigationBarToggleButtons";
            this.FirewallClientStatPageToggleButton.Size = new System.Drawing.Size(169, 24);
            this.FirewallClientStatPageToggleButton.TabIndex = 14;
            this.FirewallClientStatPageToggleButton.Text = "방화벽관리(메신저/CRM)";
            this.FirewallClientStatPageToggleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FirewallClientStatPageToggleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // toggleButton3
            // 
            this.toggleButton3.Id = "59ba1d57-5ab5-4320-bc65-9f7a5e4a0049";
            this.toggleButton3.Location = new System.Drawing.Point(2, 54);
            this.toggleButton3.Name = "toggleButton3";
            this.toggleButton3.RadioGroupName = "NavigationBarToggleButtons";
            this.toggleButton3.Size = new System.Drawing.Size(169, 24);
            this.toggleButton3.TabIndex = 18;
            this.toggleButton3.Text = "스마트폰접속설정";
            this.toggleButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toggleButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // toggleButton1
            // 
            this.toggleButton1.Id = "f0a9456e-c5a3-4ed0-a206-a0ffaa7e8d76";
            this.toggleButton1.Location = new System.Drawing.Point(2, 80);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.RadioGroupName = "NavigationBarToggleButtons";
            this.toggleButton1.Size = new System.Drawing.Size(169, 24);
            this.toggleButton1.TabIndex = 16;
            this.toggleButton1.Text = "IP폰접속설정";
            this.toggleButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toggleButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TopPanel.Controls.Add(this.RadioButtonClientMode);
            this.TopPanel.Controls.Add(this.RadioButtonServerMode);
            this.TopPanel.Controls.Add(this.panel1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(173, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(835, 37);
            this.TopPanel.TabIndex = 1;
            // 
            // RadioButtonClientMode
            // 
            this.RadioButtonClientMode.Id = "f1c0ddbb-c950-46f3-b773-f3a1d02f0058";
            this.RadioButtonClientMode.Location = new System.Drawing.Point(179, 6);
            this.RadioButtonClientMode.Name = "RadioButtonClientMode";
            this.RadioButtonClientMode.RadioGroupName = "CSMode";
            this.RadioButtonClientMode.Size = new System.Drawing.Size(169, 24);
            this.RadioButtonClientMode.TabIndex = 2;
            this.RadioButtonClientMode.Text = "메신저 클라이언트 설정";
            this.RadioButtonClientMode.Click += new System.EventHandler(this.RadioButtonServerMode_Click);
            // 
            // RadioButtonServerMode
            // 
            this.RadioButtonServerMode.Checked = true;
            this.RadioButtonServerMode.Id = "889306b8-9b49-43db-bbd0-4533a8df9803";
            this.RadioButtonServerMode.Location = new System.Drawing.Point(38, 6);
            this.RadioButtonServerMode.Name = "RadioButtonServerMode";
            this.RadioButtonServerMode.RadioGroupName = "CSMode";
            this.RadioButtonServerMode.Size = new System.Drawing.Size(104, 24);
            this.RadioButtonServerMode.TabIndex = 1;
            this.RadioButtonServerMode.Text = "서버 설정";
            this.RadioButtonServerMode.Click += new System.EventHandler(this.RadioButtonServerMode_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 2);
            this.panel1.TabIndex = 0;
            // 
            // aquaSkin1
            // 
            this.aquaSkin1.AquaStyle = SkinSoft.AquaSkin.AquaStyle.Panther;
            this.aquaSkin1.License = ((SkinSoft.AquaSkin.Licensing.AquaSkinLicense)(resources.GetObject("aquaSkin1.License")));
            this.aquaSkin1.TargetControls = SkinSoft.AquaSkin.TargetControls.Forms;
            // 
            // ControlsSamplePageContainer
            // 
            this.ControlsSamplePageContainer.ControlsSamplePage = null;
            this.ControlsSamplePageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsSamplePageContainer.Location = new System.Drawing.Point(173, 37);
            this.ControlsSamplePageContainer.Name = "ControlsSamplePageContainer";
            this.ControlsSamplePageContainer.Size = new System.Drawing.Size(835, 693);
            this.ControlsSamplePageContainer.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.ControlsSamplePageContainer);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.ControlsNavigationBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeDo 설정관리";
            this.ControlsNavigationBar.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aquaSkin1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NavigationBar ControlsNavigationBar;
        private ControlsSamplePageContainer ControlsSamplePageContainer;
        private System.Windows.Forms.Panel panel1;
        private Panel TopPanel;
        private SkinSoft.AquaSkin.AquaSkin aquaSkin1;
        private ToggleButton FirewallClientStatPageToggleButton;
        private ToggleButton FirewallServerStatPageToggleButton;
        private ToggleButton toggleButton1;
        private ToggleButton toggleButton3;
        private RadioButton RadioButtonServerMode;
        private RadioButton RadioButtonClientMode;
    }
}

