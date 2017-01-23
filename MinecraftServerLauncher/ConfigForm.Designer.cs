namespace MinecraftServerLauncher
{
    partial class ConfigForm
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
            this.cb_MinRam = new System.Windows.Forms.ComboBox();
            this.cb_MaxRam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_Pfad = new System.Windows.Forms.TextBox();
            this.bt_Speichern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_MinRam
            // 
            this.cb_MinRam.FormattingEnabled = true;
            this.cb_MinRam.Items.AddRange(new object[] {
            "512",
            "1024",
            "1536",
            "2048",
            "2560",
            "3072",
            "3584",
            "4096",
            "4608",
            "5120",
            "5632",
            "6144",
            "6656",
            "7186",
            "7680",
            "8192",
            "8704",
            "9216",
            "9728",
            "10240",
            "10752",
            "11264",
            "11776",
            "12288"});
            this.cb_MinRam.Location = new System.Drawing.Point(73, 12);
            this.cb_MinRam.Name = "cb_MinRam";
            this.cb_MinRam.Size = new System.Drawing.Size(121, 21);
            this.cb_MinRam.TabIndex = 0;
            this.cb_MinRam.Text = "512";
            // 
            // cb_MaxRam
            // 
            this.cb_MaxRam.FormattingEnabled = true;
            this.cb_MaxRam.Items.AddRange(new object[] {
            "512",
            "1024",
            "1536",
            "2048",
            "2560",
            "3072",
            "3584",
            "4096",
            "4608",
            "5120",
            "5632",
            "6144",
            "6656",
            "7186",
            "7680",
            "8192",
            "8704",
            "9216",
            "9728",
            "10240",
            "10752",
            "11264",
            "11776",
            "12288"});
            this.cb_MaxRam.Location = new System.Drawing.Point(282, 12);
            this.cb_MaxRam.Name = "cb_MaxRam";
            this.cb_MaxRam.Size = new System.Drawing.Size(121, 21);
            this.cb_MaxRam.TabIndex = 1;
            this.cb_MaxRam.Text = "512";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Min. Ram:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max. Ram:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jar-File Pfad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MinecraftServerLauncher.Properties.Resources.Documents;
            this.pictureBox1.Location = new System.Drawing.Point(374, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.openFileDialog);
            // 
            // tb_Pfad
            // 
            this.tb_Pfad.Location = new System.Drawing.Point(87, 52);
            this.tb_Pfad.Name = "tb_Pfad";
            this.tb_Pfad.ReadOnly = true;
            this.tb_Pfad.Size = new System.Drawing.Size(281, 20);
            this.tb_Pfad.TabIndex = 6;
            // 
            // bt_Speichern
            // 
            this.bt_Speichern.Location = new System.Drawing.Point(138, 78);
            this.bt_Speichern.Name = "bt_Speichern";
            this.bt_Speichern.Size = new System.Drawing.Size(138, 23);
            this.bt_Speichern.TabIndex = 7;
            this.bt_Speichern.Text = "Speichern";
            this.bt_Speichern.UseVisualStyleBackColor = true;
            this.bt_Speichern.Click += new System.EventHandler(this.bt_Speichern_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 108);
            this.Controls.Add(this.bt_Speichern);
            this.Controls.Add(this.tb_Pfad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_MaxRam);
            this.Controls.Add(this.cb_MinRam);
            this.Name = "ConfigForm";
            this.Text = "Konfiguration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_MinRam;
        private System.Windows.Forms.ComboBox cb_MaxRam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_Pfad;
        private System.Windows.Forms.Button bt_Speichern;
    }
}