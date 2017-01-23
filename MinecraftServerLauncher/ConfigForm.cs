using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftServerLauncher
{
    public partial class ConfigForm : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        FileLauncher fL = new FileLauncher();
        public ConfigForm()
        {
            InitializeComponent();
            string[] line = fL.loadConfig();

            if(line != null)
            {
                cb_MinRam.Text = line[0];
                cb_MaxRam.Text = line[1];
                tb_Pfad.Text = line[2];
            }
            
        }

        private void openFileDialog(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                tb_Pfad.Text = ofd.FileName;
            }
        }

        private void bt_Speichern_Click(object sender, EventArgs e)
        {
            if(fL.fileCheck(tb_Pfad.Text))
            {
                fL.writeInConfigFile(cb_MinRam.Text,cb_MaxRam.Text,tb_Pfad.Text);
                this.Close(); 
            }
        }

    }
}
