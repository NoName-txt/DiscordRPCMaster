namespace DiscordRPCMaster
{
    partial class DiscordRPCMaster
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscordRPCMaster));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeWindow = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.initButton = new System.Windows.Forms.Button();
            this.detailsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.smallImageText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.smallImageName = new System.Windows.Forms.TextBox();
            this.largeImageName = new System.Windows.Forms.TextBox();
            this.largeImageText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2Url = new System.Windows.Forms.TextBox();
            this.button2Text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1Url = new System.Windows.Forms.TextBox();
            this.button1Text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.notifyDiscordRPC = new System.Windows.Forms.NotifyIcon(this.components);
            this.discordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.configBox = new System.Windows.Forms.ListBox();
            this.updateConfig = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.dataNameBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.reloadListBox = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.minimizeWindow);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 43);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // minimizeWindow
            // 
            this.minimizeWindow.BackColor = System.Drawing.SystemColors.ControlDark;
            this.minimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeWindow.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minimizeWindow.ForeColor = System.Drawing.Color.White;
            this.minimizeWindow.Location = new System.Drawing.Point(651, 12);
            this.minimizeWindow.Name = "minimizeWindow";
            this.minimizeWindow.Size = new System.Drawing.Size(29, 23);
            this.minimizeWindow.TabIndex = 2;
            this.minimizeWindow.Text = "_";
            this.minimizeWindow.UseVisualStyleBackColor = false;
            this.minimizeWindow.Click += new System.EventHandler(this.minimizeWindow_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(7, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 30);
            this.label10.TabIndex = 1;
            this.label10.Text = "Discord RPC Master";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(686, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(29, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(189, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idBox.ForeColor = System.Drawing.Color.Black;
            this.idBox.Location = new System.Drawing.Point(193, 111);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(237, 25);
            this.idBox.TabIndex = 2;
            this.idBox.Text = "ID";
            // 
            // initButton
            // 
            this.initButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.initButton.Location = new System.Drawing.Point(181, 517);
            this.initButton.Name = "initButton";
            this.initButton.Size = new System.Drawing.Size(99, 29);
            this.initButton.TabIndex = 3;
            this.initButton.Text = "Initialize";
            this.initButton.UseVisualStyleBackColor = true;
            this.initButton.Click += new System.EventHandler(this.initButton_Click);
            // 
            // detailsBox
            // 
            this.detailsBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.detailsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailsBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.detailsBox.ForeColor = System.Drawing.Color.Black;
            this.detailsBox.Location = new System.Drawing.Point(193, 171);
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(236, 25);
            this.detailsBox.TabIndex = 5;
            this.detailsBox.Text = "DETAILS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(189, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Details:";
            // 
            // stateBox
            // 
            this.stateBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.stateBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stateBox.ForeColor = System.Drawing.Color.Black;
            this.stateBox.Location = new System.Drawing.Point(454, 171);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(236, 25);
            this.stateBox.TabIndex = 7;
            this.stateBox.Text = "STATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(450, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "State:";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startButton.Location = new System.Drawing.Point(286, 517);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 29);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // smallImageText
            // 
            this.smallImageText.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.smallImageText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smallImageText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smallImageText.ForeColor = System.Drawing.Color.Black;
            this.smallImageText.Location = new System.Drawing.Point(193, 240);
            this.smallImageText.Name = "smallImageText";
            this.smallImageText.Size = new System.Drawing.Size(236, 25);
            this.smallImageText.TabIndex = 10;
            this.smallImageText.Text = "TEXT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(189, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Small Image:";
            // 
            // smallImageName
            // 
            this.smallImageName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.smallImageName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smallImageName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.smallImageName.ForeColor = System.Drawing.Color.Black;
            this.smallImageName.Location = new System.Drawing.Point(193, 266);
            this.smallImageName.Name = "smallImageName";
            this.smallImageName.Size = new System.Drawing.Size(236, 25);
            this.smallImageName.TabIndex = 11;
            this.smallImageName.Text = "IMAGE NAME";
            // 
            // largeImageName
            // 
            this.largeImageName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.largeImageName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.largeImageName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.largeImageName.ForeColor = System.Drawing.Color.Black;
            this.largeImageName.Location = new System.Drawing.Point(454, 266);
            this.largeImageName.Name = "largeImageName";
            this.largeImageName.Size = new System.Drawing.Size(236, 25);
            this.largeImageName.TabIndex = 14;
            this.largeImageName.Text = "IMAGE NAME";
            // 
            // largeImageText
            // 
            this.largeImageText.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.largeImageText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.largeImageText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.largeImageText.ForeColor = System.Drawing.Color.Black;
            this.largeImageText.Location = new System.Drawing.Point(454, 240);
            this.largeImageText.Name = "largeImageText";
            this.largeImageText.Size = new System.Drawing.Size(236, 25);
            this.largeImageText.TabIndex = 13;
            this.largeImageText.Text = "TEXT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(450, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Large Image:";
            // 
            // button2Url
            // 
            this.button2Url.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2Url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button2Url.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2Url.ForeColor = System.Drawing.Color.Black;
            this.button2Url.Location = new System.Drawing.Point(454, 368);
            this.button2Url.Name = "button2Url";
            this.button2Url.Size = new System.Drawing.Size(236, 25);
            this.button2Url.TabIndex = 20;
            this.button2Url.Text = "URL";
            // 
            // button2Text
            // 
            this.button2Text.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button2Text.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2Text.ForeColor = System.Drawing.Color.Black;
            this.button2Text.Location = new System.Drawing.Point(454, 342);
            this.button2Text.Name = "button2Text";
            this.button2Text.Size = new System.Drawing.Size(236, 25);
            this.button2Text.TabIndex = 19;
            this.button2Text.Text = "TEXT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(450, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Button 2:";
            // 
            // button1Url
            // 
            this.button1Url.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1Url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button1Url.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1Url.ForeColor = System.Drawing.Color.Black;
            this.button1Url.Location = new System.Drawing.Point(193, 368);
            this.button1Url.Name = "button1Url";
            this.button1Url.Size = new System.Drawing.Size(236, 25);
            this.button1Url.TabIndex = 17;
            this.button1Url.Text = "URL";
            // 
            // button1Text
            // 
            this.button1Text.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button1Text.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1Text.ForeColor = System.Drawing.Color.Black;
            this.button1Text.Location = new System.Drawing.Point(193, 342);
            this.button1Text.Name = "button1Text";
            this.button1Text.Size = new System.Drawing.Size(236, 25);
            this.button1Text.TabIndex = 16;
            this.button1Text.Text = "TEXT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(189, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Button 1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(451, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Timestamp:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(455, 90);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 21);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Open/Close";
            this.checkBox1.UseVisualStyleBackColor = true;

            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stopButton.Location = new System.Drawing.Point(367, 517);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 29);
            this.stopButton.TabIndex = 27;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // notifyDiscordRPC
            // 
            this.notifyDiscordRPC.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyDiscordRPC.Icon")));
            this.notifyDiscordRPC.Text = "Discord RPC Master";
            this.notifyDiscordRPC.Visible = true;
            this.notifyDiscordRPC.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyDiscordRPC_MouseDoubleClick);
            // 
            // discordLinkLabel
            // 
            this.discordLinkLabel.AutoSize = true;
            this.discordLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.discordLinkLabel.Location = new System.Drawing.Point(190, 93);
            this.discordLinkLabel.Name = "discordLinkLabel";
            this.discordLinkLabel.Size = new System.Drawing.Size(204, 15);
            this.discordLinkLabel.TabIndex = 29;
            this.discordLinkLabel.TabStop = true;
            this.discordLinkLabel.Text = "discord.com/developers/applications";
            this.discordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.discordLinkLabel_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(531, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "Config Settings:";
            // 
            // configBox
            // 
            this.configBox.BackColor = System.Drawing.Color.DarkGray;
            this.configBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.configBox.FormattingEnabled = true;
            this.configBox.ItemHeight = 17;
            this.configBox.Location = new System.Drawing.Point(12, 83);
            this.configBox.Name = "configBox";
            this.configBox.Size = new System.Drawing.Size(154, 429);
            this.configBox.TabIndex = 32;
            this.configBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.configBox_MouseClick);
            // 
            // updateConfig
            // 
            this.updateConfig.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateConfig.Location = new System.Drawing.Point(535, 429);
            this.updateConfig.Name = "updateConfig";
            this.updateConfig.Size = new System.Drawing.Size(75, 29);
            this.updateConfig.TabIndex = 33;
            this.updateConfig.Text = "Update";
            this.updateConfig.UseVisualStyleBackColor = true;
            this.updateConfig.Click += new System.EventHandler(this.updateConfig_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.removeButton.Location = new System.Drawing.Point(616, 429);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 29);
            this.removeButton.TabIndex = 34;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // dataNameBox
            // 
            this.dataNameBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataNameBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataNameBox.ForeColor = System.Drawing.Color.Black;
            this.dataNameBox.Location = new System.Drawing.Point(535, 486);
            this.dataNameBox.Name = "dataNameBox";
            this.dataNameBox.Size = new System.Drawing.Size(156, 25);
            this.dataNameBox.TabIndex = 35;
            this.dataNameBox.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(13, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 21);
            this.label11.TabIndex = 36;
            this.label11.Text = "Select Config:";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(535, 460);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 18);
            this.label12.TabIndex = 37;
            this.label12.Text = "-------------------------";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.Location = new System.Drawing.Point(535, 517);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(156, 29);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "New Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // reloadListBox
            // 
            this.reloadListBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reloadListBox.Location = new System.Drawing.Point(12, 517);
            this.reloadListBox.Name = "reloadListBox";
            this.reloadListBox.Size = new System.Drawing.Size(154, 29);
            this.reloadListBox.TabIndex = 38;
            this.reloadListBox.Text = "Reload";
            this.reloadListBox.UseVisualStyleBackColor = true;
            this.reloadListBox.Click += new System.EventHandler(this.reloadListBox_Click);
            // 
            // DiscordRPCMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(727, 562);
            this.Controls.Add(this.reloadListBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataNameBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.updateConfig);
            this.Controls.Add(this.configBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.discordLinkLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.initButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.largeImageName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1Text);
            this.Controls.Add(this.detailsBox);
            this.Controls.Add(this.largeImageText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1Url);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.smallImageName);
            this.Controls.Add(this.button2Text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.smallImageText);
            this.Controls.Add(this.button2Url);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiscordRPCMaster";
            this.Text = "DiscordRPC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button initButton;
        private System.Windows.Forms.TextBox detailsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox smallImageText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox smallImageName;
        private System.Windows.Forms.TextBox largeImageName;
        private System.Windows.Forms.TextBox largeImageText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox button2Url;
        private System.Windows.Forms.TextBox button2Text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox button1Url;
        private System.Windows.Forms.TextBox button1Text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button minimizeWindow;
        private System.Windows.Forms.NotifyIcon notifyDiscordRPC;
        private System.Windows.Forms.LinkLabel discordLinkLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox configBox;
        private System.Windows.Forms.Button updateConfig;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox dataNameBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button reloadListBox;
    }
}

