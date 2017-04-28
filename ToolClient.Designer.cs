namespace CommunicationTool_Client
{
    partial class ToolClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolClient));
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.panel_ButtonsServer = new System.Windows.Forms.Panel();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.btn_ConnectServer = new System.Windows.Forms.Button();
            this.pictureBox_BroadcastMsg = new System.Windows.Forms.PictureBox();
            this.richTextBox_chatInput = new System.Windows.Forms.RichTextBox();
            this.richTextBox_chatStream = new System.Windows.Forms.RichTextBox();
            this.pnl_Main.SuspendLayout();
            this.panel_ButtonsServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BroadcastMsg)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_Main.Controls.Add(this.panel_ButtonsServer);
            this.pnl_Main.Controls.Add(this.richTextBox_chatInput);
            this.pnl_Main.Controls.Add(this.richTextBox_chatStream);
            this.pnl_Main.Location = new System.Drawing.Point(0, -2);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(483, 306);
            this.pnl_Main.TabIndex = 2;
            // 
            // panel_ButtonsServer
            // 
            this.panel_ButtonsServer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_ButtonsServer.Controls.Add(this.lbl_UserName);
            this.panel_ButtonsServer.Controls.Add(this.textBox_UserName);
            this.panel_ButtonsServer.Controls.Add(this.btn_ConnectServer);
            this.panel_ButtonsServer.Controls.Add(this.pictureBox_BroadcastMsg);
            this.panel_ButtonsServer.Location = new System.Drawing.Point(4, 194);
            this.panel_ButtonsServer.Name = "panel_ButtonsServer";
            this.panel_ButtonsServer.Size = new System.Drawing.Size(474, 39);
            this.panel_ButtonsServer.TabIndex = 2;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_UserName.Location = new System.Drawing.Point(5, 7);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(76, 20);
            this.lbl_UserName.TabIndex = 6;
            this.lbl_UserName.Text = "Usuário:";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(80, 7);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(197, 20);
            this.textBox_UserName.TabIndex = 5;
            // 
            // btn_ConnectServer
            // 
            this.btn_ConnectServer.BackColor = System.Drawing.Color.LightGray;
            this.btn_ConnectServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConnectServer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ConnectServer.Location = new System.Drawing.Point(283, 2);
            this.btn_ConnectServer.Name = "btn_ConnectServer";
            this.btn_ConnectServer.Size = new System.Drawing.Size(116, 30);
            this.btn_ConnectServer.TabIndex = 4;
            this.btn_ConnectServer.Text = "Conectar";
            this.btn_ConnectServer.UseVisualStyleBackColor = false;
            this.btn_ConnectServer.Click += new System.EventHandler(this.btn_ConnectServer_Click);
            // 
            // pictureBox_BroadcastMsg
            // 
            this.pictureBox_BroadcastMsg.Image = global::CommunicationTool_Client.Properties.Resources.red_mail_send_icon;
            this.pictureBox_BroadcastMsg.Location = new System.Drawing.Point(420, -2);
            this.pictureBox_BroadcastMsg.Name = "pictureBox_BroadcastMsg";
            this.pictureBox_BroadcastMsg.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_BroadcastMsg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_BroadcastMsg.TabIndex = 1;
            this.pictureBox_BroadcastMsg.TabStop = false;
            this.pictureBox_BroadcastMsg.Click += new System.EventHandler(this.pictureBox_BroadcastMsg_Click);
            // 
            // richTextBox_chatInput
            // 
            this.richTextBox_chatInput.Location = new System.Drawing.Point(4, 232);
            this.richTextBox_chatInput.Name = "richTextBox_chatInput";
            this.richTextBox_chatInput.Size = new System.Drawing.Size(474, 62);
            this.richTextBox_chatInput.TabIndex = 1;
            this.richTextBox_chatInput.Text = "";
            this.richTextBox_chatInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // richTextBox_chatStream
            // 
            this.richTextBox_chatStream.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox_chatStream.Enabled = false;
            this.richTextBox_chatStream.Location = new System.Drawing.Point(4, 4);
            this.richTextBox_chatStream.Name = "richTextBox_chatStream";
            this.richTextBox_chatStream.Size = new System.Drawing.Size(474, 189);
            this.richTextBox_chatStream.TabIndex = 0;
            this.richTextBox_chatStream.Text = "";
            this.richTextBox_chatStream.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // ToolClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 302);
            this.Controls.Add(this.pnl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Communication Tool - Client";
            this.pnl_Main.ResumeLayout(false);
            this.panel_ButtonsServer.ResumeLayout(false);
            this.panel_ButtonsServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BroadcastMsg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel panel_ButtonsServer;
        private System.Windows.Forms.PictureBox pictureBox_BroadcastMsg;
        private System.Windows.Forms.RichTextBox richTextBox_chatInput;
        private System.Windows.Forms.RichTextBox richTextBox_chatStream;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Button btn_ConnectServer;
    }
}

