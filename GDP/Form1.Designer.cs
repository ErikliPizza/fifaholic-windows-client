using System.Drawing.Drawing2D;
using System.Drawing;
namespace GDP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.styleManager1 = new MetroSet_UI.Components.StyleManager();
            this.log_text = new MetroSet_UI.Controls.MetroSetLabel();
            this.oauthButton = new MetroSet_UI.Controls.MetroSetButton();
            this.league_box = new MetroSet_UI.Controls.MetroSetComboBox();
            this.accessKey_text = new MetroSet_UI.Controls.MetroSetTextBox();
            this.uri_text = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lockSwitch = new MetroSet_UI.Controls.MetroSetSwitch();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "NCDT app";
            this.notifyIcon.BalloonTipTitle = "NCDT app";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "NCDT";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(767, 12);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetControlBox1.StyleManager = this.styleManager1;
            this.metroSetControlBox1.TabIndex = 17;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\VViglaf\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Enums.Style.Dark;
            this.styleManager1.ThemeAuthor = "Narwin";
            this.styleManager1.ThemeName = "MetroDark";
            // 
            // log_text
            // 
            this.log_text.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.log_text.IsDerivedStyle = true;
            this.log_text.Location = new System.Drawing.Point(13, 213);
            this.log_text.Name = "log_text";
            this.log_text.Size = new System.Drawing.Size(855, 40);
            this.log_text.Style = MetroSet_UI.Enums.Style.Dark;
            this.log_text.StyleManager = this.styleManager1;
            this.log_text.TabIndex = 19;
            this.log_text.Text = "INFO";
            this.log_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.log_text.ThemeAuthor = "Narwin";
            this.log_text.ThemeName = "MetroDark";
            // 
            // oauthButton
            // 
            this.oauthButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.oauthButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.oauthButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.oauthButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.oauthButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.oauthButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.oauthButton.HoverTextColor = System.Drawing.Color.White;
            this.oauthButton.IsDerivedStyle = true;
            this.oauthButton.Location = new System.Drawing.Point(653, 183);
            this.oauthButton.Name = "oauthButton";
            this.oauthButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.oauthButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.oauthButton.NormalTextColor = System.Drawing.Color.White;
            this.oauthButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.oauthButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.oauthButton.PressTextColor = System.Drawing.Color.White;
            this.oauthButton.Size = new System.Drawing.Size(90, 26);
            this.oauthButton.Style = MetroSet_UI.Enums.Style.Dark;
            this.oauthButton.StyleManager = this.styleManager1;
            this.oauthButton.TabIndex = 14;
            this.oauthButton.Text = "OAuth";
            this.oauthButton.ThemeAuthor = "Narwin";
            this.oauthButton.ThemeName = "MetroDark";
            this.oauthButton.Click += new System.EventHandler(this.oauthButton_Click);
            // 
            // league_box
            // 
            this.league_box.AllowDrop = true;
            this.league_box.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.league_box.BackColor = System.Drawing.Color.Transparent;
            this.league_box.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.league_box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.league_box.CausesValidation = false;
            this.league_box.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.league_box.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.league_box.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.league_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.league_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.league_box.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.league_box.FormattingEnabled = true;
            this.league_box.IsDerivedStyle = true;
            this.league_box.ItemHeight = 16;
            this.league_box.Location = new System.Drawing.Point(382, 186);
            this.league_box.Name = "league_box";
            this.league_box.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.league_box.SelectedItemForeColor = System.Drawing.Color.White;
            this.league_box.Size = new System.Drawing.Size(114, 22);
            this.league_box.Style = MetroSet_UI.Enums.Style.Dark;
            this.league_box.StyleManager = this.styleManager1;
            this.league_box.TabIndex = 10;
            this.league_box.ThemeAuthor = "Narwin";
            this.league_box.ThemeName = "MetroDark";
            this.league_box.SelectedIndexChanged += new System.EventHandler(this.league_box_SelectedIndexChanged);
            // 
            // accessKey_text
            // 
            this.accessKey_text.AutoCompleteCustomSource = null;
            this.accessKey_text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.accessKey_text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.accessKey_text.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.accessKey_text.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.accessKey_text.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.accessKey_text.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.accessKey_text.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.accessKey_text.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.accessKey_text.Image = null;
            this.accessKey_text.IsDerivedStyle = true;
            this.accessKey_text.Lines = null;
            this.accessKey_text.Location = new System.Drawing.Point(400, 183);
            this.accessKey_text.MaxLength = 32767;
            this.accessKey_text.Multiline = false;
            this.accessKey_text.Name = "accessKey_text";
            this.accessKey_text.ReadOnly = false;
            this.accessKey_text.Size = new System.Drawing.Size(247, 27);
            this.accessKey_text.Style = MetroSet_UI.Enums.Style.Dark;
            this.accessKey_text.StyleManager = this.styleManager1;
            this.accessKey_text.TabIndex = 21;
            this.accessKey_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.accessKey_text.ThemeAuthor = "Narwin";
            this.accessKey_text.ThemeName = "MetroDark";
            this.accessKey_text.UseSystemPasswordChar = true;
            this.accessKey_text.WatermarkText = "Acces Token";
            // 
            // uri_text
            // 
            this.uri_text.AutoCompleteCustomSource = null;
            this.uri_text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.uri_text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.uri_text.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.uri_text.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uri_text.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uri_text.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uri_text.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uri_text.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.uri_text.Image = null;
            this.uri_text.IsDerivedStyle = true;
            this.uri_text.Lines = null;
            this.uri_text.Location = new System.Drawing.Point(147, 183);
            this.uri_text.MaxLength = 32767;
            this.uri_text.Multiline = false;
            this.uri_text.Name = "uri_text";
            this.uri_text.ReadOnly = false;
            this.uri_text.Size = new System.Drawing.Size(247, 27);
            this.uri_text.Style = MetroSet_UI.Enums.Style.Dark;
            this.uri_text.StyleManager = this.styleManager1;
            this.uri_text.TabIndex = 11;
            this.uri_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uri_text.ThemeAuthor = "Narwin";
            this.uri_text.ThemeName = "MetroDark";
            this.uri_text.UseSystemPasswordChar = false;
            this.uri_text.WatermarkText = "URL";
            // 
            // lockSwitch
            // 
            this.lockSwitch.BackColor = System.Drawing.Color.Transparent;
            this.lockSwitch.BackgroundColor = System.Drawing.Color.Empty;
            this.lockSwitch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.lockSwitch.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lockSwitch.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.lockSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lockSwitch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lockSwitch.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lockSwitch.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.lockSwitch.IsDerivedStyle = true;
            this.lockSwitch.Location = new System.Drawing.Point(12, 15);
            this.lockSwitch.Name = "lockSwitch";
            this.lockSwitch.Size = new System.Drawing.Size(58, 22);
            this.lockSwitch.Style = MetroSet_UI.Enums.Style.Dark;
            this.lockSwitch.StyleManager = this.styleManager1;
            this.lockSwitch.Switched = false;
            this.lockSwitch.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.lockSwitch.TabIndex = 23;
            this.lockSwitch.Text = "metroSetSwitch1";
            this.lockSwitch.ThemeAuthor = "Narwin";
            this.lockSwitch.ThemeName = "MetroDark";
            this.lockSwitch.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.lockSwitch.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.lockSwitch_SwitchedChanged);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(12, 377);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(576, 22);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel1.StyleManager = this.styleManager1;
            this.metroSetLabel1.TabIndex = 24;
            this.metroSetLabel1.Text = "Need help? See the documentation, source code and other projects on github/Erikli" +
    "Pizza";
            this.metroSetLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroDark";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(692, 377);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(176, 22);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel2.StyleManager = this.styleManager1;
            this.metroSetLabel2.TabIndex = 24;
            this.metroSetLabel2.Text = "lshift + . to create a match";
            this.metroSetLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroDark";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BackgroundImage = global::GDP.Properties.Resources.luke_chesser_eICUFSeirc0_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 408);
            this.ControlBox = false;
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.lockSwitch);
            this.Controls.Add(this.uri_text);
            this.Controls.Add(this.accessKey_text);
            this.Controls.Add(this.log_text);
            this.Controls.Add(this.league_box);
            this.Controls.Add(this.oauthButton);
            this.Controls.Add(this.metroSetControlBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NCDT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetLabel log_text;
        private MetroSet_UI.Controls.MetroSetButton oauthButton;
        private MetroSet_UI.Controls.MetroSetComboBox league_box;
        private MetroSet_UI.Controls.MetroSetTextBox accessKey_text;
        private MetroSet_UI.Controls.MetroSetTextBox uri_text;
        private MetroSet_UI.Components.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetSwitch lockSwitch;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
    }
}

