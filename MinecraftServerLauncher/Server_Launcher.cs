using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftServerLauncher
{
    public partial class Server_Launcher : Form
    {
        private StreamWriter WriteCommands;
        private BackgroundWorker StartServer;
        private FileLauncher fL = new FileLauncher();
        private bool running = false;

        delegate void SetTextCallBack(string text);

        string MaxRam = null;
        string MinRam = null;
        string server = null;

        public Server_Launcher()
        {
            InitializeComponent();
            //lb_status_server.Text = "Offline";
            //lb_status_server.ForeColor = Color.Red;
        }

        void StartServer_DoWork(object sender, DoWorkEventArgs e)
        {
                for (int i = 0; i < 1; i++)
                {
                    Process Minecraft = new Process();
                    Minecraft.StartInfo.FileName = "CMD.exe";
                    Minecraft.StartInfo.CreateNoWindow = true;
                    Minecraft.StartInfo.RedirectStandardInput = true;
                    Minecraft.StartInfo.RedirectStandardOutput = true;
                    Minecraft.StartInfo.RedirectStandardError = true;
                    Minecraft.StartInfo.UseShellExecute = false;
                    Minecraft.OutputDataReceived += Minecraft_OutputDataReceived;
                    Minecraft.ErrorDataReceived += Minecraft_ErrorDataReceived;
                    Minecraft.Start();
                    Minecraft.BeginOutputReadLine();
                    Minecraft.BeginErrorReadLine();
                    WriteCommands = Minecraft.StandardInput;
                    WriteCommands.WriteLineAsync(@"java -Xmx" + MaxRam + "M -Xms" + MinRam + "M -jar " + server + " " + "nogui");
                    pb_Status.Image = Properties.Resources.ampel_100c;

            }

        }

        void Minecraft_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {

        }

        void Minecraft_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            try
            {
                this.SetText(tbCommand.Text + e.Data + System.Environment.NewLine);
            }
            catch (Exception ex)
            {
            }
        }
        private void SetText(string text)
        {
            if (this.tb_log.InvokeRequired)
            {
                SetTextCallBack d = new SetTextCallBack(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                tb_log.AppendText(text);
            }

        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            runServer();
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            stopServer();
        }

        private void bt_Restart_Click(object sender, EventArgs e)
        {
            clearIt();
            WriteCommands.WriteLineAsync("reload");

        }

        private void command_Send(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(tbCommand.Text.ToLower().Equals("start"))
                {
                    runServer();
                }
                if(tbCommand.Text.ToLower().Equals("stop"))
                {
                    stopServer();
                }
                else
                {
                    string text = tbCommand.Text;
                    tbCommand.Text = "";
                    WriteCommands.WriteLineAsync(text);
                }
                
            }
        }



        private void runServer()
        {
            clearIt();
            loadFileConfig();
            pb_Status.Image = Properties.Resources.ampel_100d;
            if (MinRam != null && MaxRam != null && server != null)
            {
                if(!running)
                {
                    StartServer = new BackgroundWorker();
                    StartServer.DoWork += StartServer_DoWork;
                    StartServer.RunWorkerAsync();
                    running = true;
                    
                }
                else
                {
                    pb_Status.Image = Properties.Resources.ampel_100c;
                    tb_log.AppendText(LogMsg.InfoLogMsg("Der Server läuft bereits!") + System.Environment.NewLine);
                }

            }
            else
            {
                pb_Status.Image = Properties.Resources.ampel_100b;
                tb_log.AppendText(LogMsg.ErrorLogMsg("Die Konfigurationsdatei ist nicht ausgefüllt!") + System.Environment.NewLine);
            }
        }

        private void stopServer()
        {
            clearIt();
            if (running)
            {
                WriteCommands.WriteLineAsync("stop");
                pb_Status.Image = Properties.Resources.ampel_100a;
                running = false;
            }
        }

        private void clearIt()
        {
            tbCommand.Text = "";
        }

        private void KonfigButton_Click(object sender, EventArgs e)
        {
            ConfigForm ConfigForm = new ConfigForm();
            ConfigForm.Show();
        }

        private void loadFileConfig()
        {
            string[] configLines = fL.readConfigFile();
            if(configLines != null)
            {
                MinRam = configLines[0];
                MaxRam = configLines[1];
                server = configLines[2];
            }

        }
    }
}

