namespace MinecraftServerLauncher
{
    partial class Server_Launcher
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server_Launcher));
            this.tb_log = new System.Windows.Forms.TextBox();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_Reload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pb_Status = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Status)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(12, 12);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.ReadOnly = true;
            this.tb_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_log.Size = new System.Drawing.Size(482, 387);
            this.tb_log.TabIndex = 0;
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(513, 80);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(111, 23);
            this.bt_start.TabIndex = 1;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(513, 138);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(111, 23);
            this.bt_stop.TabIndex = 2;
            this.bt_stop.Text = "Stop";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // bt_Reload
            // 
            this.bt_Reload.Location = new System.Drawing.Point(513, 109);
            this.bt_Reload.Name = "bt_Reload";
            this.bt_Reload.Size = new System.Drawing.Size(111, 23);
            this.bt_Reload.TabIndex = 3;
            this.bt_Reload.Text = "Reload";
            this.bt_Reload.UseVisualStyleBackColor = true;
            this.bt_Reload.Click += new System.EventHandler(this.bt_Restart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status:";
            // 
            // tbCommand
            // 
            this.tbCommand.Location = new System.Drawing.Point(513, 379);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(111, 20);
            this.tbCommand.TabIndex = 6;
            this.tbCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.command_Send);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Konfiguration";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.KonfigButton_Click);
            // 
            // pb_Status
            // 
            this.pb_Status.Image = ((System.Drawing.Image)(resources.GetObject("pb_Status.Image")));
            this.pb_Status.Location = new System.Drawing.Point(568, 12);
            this.pb_Status.Name = "pb_Status";
            this.pb_Status.Size = new System.Drawing.Size(20, 50);
            this.pb_Status.TabIndex = 8;
            this.pb_Status.TabStop = false;
            // 
            // Server_Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 408);
            this.Controls.Add(this.pb_Status);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCommand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Reload);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.tb_log);
            this.Name = "Server_Launcher";
            this.Text = "Minecraft Server Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_Reload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb_Status;
    }
}

