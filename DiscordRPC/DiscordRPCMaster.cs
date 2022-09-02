using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DiscordRPC;
using Buttons = DiscordRPC.Button;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;
using System.Diagnostics;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.InteropServices.ComTypes;
using System.IO;
using DiscordRPCMaster.Properties;
using System.Runtime;

namespace DiscordRPCMaster
{
    public partial class DiscordRPCMaster : Form
    {
        public DiscordRpcClient client;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private ContextMenu dRPCcontextMenu;
        private MenuItem dRPCmenuItem;

        public string selectConfig = "";
        public DiscordRPCMaster()
        {
            InitializeComponent();
            //this.BackColor = ColorTranslator.FromHtml("#36393f");

            dRPCcontextMenu = new ContextMenu();
            dRPCmenuItem = new MenuItem();

            dRPCcontextMenu.MenuItems.AddRange(new MenuItem[] { this.dRPCmenuItem });
            dRPCmenuItem.Index = 0;
            dRPCmenuItem.Text = "Exit";
            dRPCmenuItem.Click += new System.EventHandler(this.closeButton_Click);

            notifyDiscordRPC.ContextMenu = dRPCcontextMenu;
            notifyDiscordRPC.Visible = true;

            loadConfigItems();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (client != null)
            {
                client.Dispose();
            }
        }
        public void Move_Form(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Move_Form(Handle, e);
        }

        RichPresence presence;

        public void UpdatePresence()
        {
            int buttonSize = 0;
            if (button1Text.Text.Length > 1 && button1Url.Text.Length > 1)
            {
                buttonSize++;
            }
            if (button2Text.Text.Length > 1 && button2Url.Text.Length > 1)
            {
                buttonSize++;
            }

            Buttons[] buttons = new Buttons[buttonSize];

            if (button1Text.Text.Length > 1 && button1Url.Text.Length > 1)
            {

                try
                {
                    buttons.SetValue(new Buttons() { Label = button1Text.Text, Url = button1Url.Text }, 0);
                }
                catch (Exception ae)
                {
                    MessageBox.Show("Button 1 Incorrect Please Check! (URL Must Start With https:// or http://)", "Discord RPC Master");
                    return;
                }

            }
            if (button2Text.Text.Length > 1 && button2Url.Text.Length > 1)
            {
                try
                {
                    buttons.SetValue(new Buttons() { Label = button2Text.Text, Url = button2Url.Text }, 1);
                }
                catch (Exception ae)
                {
                    MessageBox.Show("Button 2 Incorrect Please Check! (URL Must Start With https:// or http://)", "Discord RPC Master");
                    return;
                }
            }




            RichPresence prsc = new RichPresence()
            {
                Details = detailsBox.Text,
                State = stateBox.Text,
                Assets = new Assets()
                {
                    LargeImageKey = largeImageName.Text,
                    LargeImageText = largeImageText.Text,
                    SmallImageKey = smallImageName.Text,
                    SmallImageText = smallImageText.Text
                },
                Buttons = buttons



            };
            if (checkBox1.Checked) {
                prsc.Timestamps = new Timestamps()
                {
                    Start = DateTime.UtcNow
                };
            }

            presence = prsc;

        }

        void Initialize()
        {
            if (idBox.Text.Length < 3)
            {
                MessageBox.Show("Enter ID", "Warning");
                return;
            }

            client = new DiscordRpcClient(idBox.Text);

            client.Initialize();

            startButton.Text = "Start";
            return;
        }

        void Start()
        {
            if (presence == null || client == null)
            {
                MessageBox.Show("Please Initialize!", "Discord RPC Master");
            }
            else
            {
                if (startButton.Text == "Update")
                {
                    UpdatePresence();
                }
                startButton.Text = "Update";
                client.SetPresence(presence);
            }
        }
        private void initButton_Click(object sender, EventArgs e)
        {
            Initialize();
            if (client != null)
            {
                MessageBox.Show("Initialize Successful!", "Discord RPC Master");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                startButton.Text = "Start";
                client.Dispose();
                client = null;
            }
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            Config settings = Config.Load();
            CDatas obj = settings.Options.Find(el => el.DataName == dataNameBox.Text);
            if (obj == null)
            {
                CDatas data = new CDatas()
                {
                    DataName = dataNameBox.Text,
                    clientID = idBox.Text,
                    details = detailsBox.Text,
                    state = stateBox.Text,
                    timestamp = checkBox1.Checked,

                    smallImageName = smallImageName.Text,
                    smallImageText = smallImageText.Text,
                    largeImageName = largeImageName.Text,
                    largeImageText = largeImageText.Text,

                    button1Text = button1Text.Text,
                    button1Url = button1Url.Text,
                    button2Text = button2Text.Text,
                    button2Url = button2Url.Text
                };
                settings.Options.Add(data);
                settings.Save();
                configBox.Items.Add(data.DataName);
            }
            else
            {
                MessageBox.Show("There Is Already A Config With This Name!", "Discord RPC Master");
            }

        }


        bool firstMin = true;
        private void minimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                if(firstMin == true)
                {
                    notifyDiscordRPC.BalloonTipText = "I am here!";
                    notifyDiscordRPC.BalloonTipTitle = "Discord RPC Master";
                    notifyDiscordRPC.ShowBalloonTip(1000);
                    firstMin = false;
                }

            }
        }

        private void notifyDiscordRPC_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }


        private void discordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.com/developers/applications");
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Config settings = Config.Load();
            settings.Options.Remove(new CDatas() { DataName = selectConfig});
            settings.Save();

            configBox.Items.Remove(selectConfig);
            selectConfig = "";
        }


        void configBox_MouseClick(object sender, MouseEventArgs e)
        {
            int index = configBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches) {

                string a = configBox.Items[index].ToString();
                selectConfig = a;

                Config settings = Config.Load();
                CDatas ao = settings.Options.Find(ec => ec.DataName == a);
                DialogResult dialogResult =  MessageBox.Show("Selected "+a + ",\nWant to Activate Config?", "Discord RPC Master", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (ao != null)
                    {
                        idBox.Text = ao.clientID;
                        detailsBox.Text = ao.details;
                        stateBox.Text = ao.state;
                        checkBox1.Checked = ao.timestamp;

                        smallImageName.Text = ao.smallImageName;
                        smallImageText.Text = ao.smallImageText;
                        largeImageName.Text = ao.largeImageName;
                        largeImageText.Text = ao.largeImageText;

                        button1Text.Text = ao.button1Text;
                        button1Url.Text = ao.button1Url;
                        button2Text.Text = ao.button2Text;
                        button2Url.Text = ao.button2Url;
                    }
                    else
                    {
                        MessageBox.Show("I Couldn't Find Such A Config!", "Discord RPC Master");
                    }
                }
            }
        }

        private void updateConfig_Click(object sender, EventArgs e)
        {
            Config settings = Config.Load();
            CDatas ao = settings.Options.Find(ec => ec.DataName == selectConfig);
            if(ao != null)
            {
                ao.clientID = idBox.Text;
                ao.details = detailsBox.Text;
                ao.state = stateBox.Text;
                ao.timestamp = checkBox1.Checked;

                ao.smallImageName = smallImageName.Text;
                ao.smallImageText = smallImageText.Text;
                ao.largeImageName = largeImageName.Text;
                ao.largeImageText = largeImageText.Text;

                ao.button1Text = button1Text.Text;
                ao.button1Url = button1Url.Text;
                ao.button2Text = button2Text.Text;
                ao.button2Url = button2Url.Text;
                settings.Save();
                MessageBox.Show("Updated!", "Discord RPC Master");
            }
            else
            {
                MessageBox.Show("I Couldn't Find Such A Config!", "Discord RPC Master");
            }

        }
        public void loadConfigItems()
        {
            configBox.Items.Clear();
            Config settings = Config.Load();
            settings.Options.ForEach(el =>
            {
                configBox.Items.Add(el.DataName);
            });
        }
        private void reloadListBox_Click(object sender, EventArgs e)
        {
            loadConfigItems();
        }
    }
}
