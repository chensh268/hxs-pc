﻿namespace MaSoft.UI.MaMessage
{
    partial class RunOnly
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
            this.button_ok = new System.Windows.Forms.Button();
            this.textBox_msg = new System.Windows.Forms.TextBox();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.pictureBox_ico = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ico)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.Red;
            this.button_ok.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ok.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_ok.Location = new System.Drawing.Point(110, 163);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(100, 35);
            this.button_ok.TabIndex = 17;
            this.button_ok.Text = "确 定";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // textBox_msg
            // 
            this.textBox_msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_msg.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_msg.Enabled = false;
            this.textBox_msg.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_msg.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox_msg.Location = new System.Drawing.Point(12, 122);
            this.textBox_msg.Multiline = true;
            this.textBox_msg.Name = "textBox_msg";
            this.textBox_msg.ReadOnly = true;
            this.textBox_msg.ShortcutsEnabled = false;
            this.textBox_msg.Size = new System.Drawing.Size(297, 26);
            this.textBox_msg.TabIndex = 14;
            this.textBox_msg.TabStop = false;
            this.textBox_msg.Text = "慧学僧自助打印助手运行中";
            this.textBox_msg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Image = global::MaSoft.Properties.Resources.MessageBox_close;
            this.pictureBox_close.Location = new System.Drawing.Point(298, 7);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_close.TabIndex = 16;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            this.pictureBox_close.MouseLeave += new System.EventHandler(this.pictureBox_close_MouseLeave);
            this.pictureBox_close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_close_MouseMove);
            // 
            // pictureBox_ico
            // 
            this.pictureBox_ico.Image = global::MaSoft.Properties.Resources.MessageBox_warning;
            this.pictureBox_ico.Location = new System.Drawing.Point(130, 27);
            this.pictureBox_ico.MaximumSize = new System.Drawing.Size(60, 60);
            this.pictureBox_ico.MinimumSize = new System.Drawing.Size(60, 60);
            this.pictureBox_ico.Name = "pictureBox_ico";
            this.pictureBox_ico.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_ico.TabIndex = 15;
            this.pictureBox_ico.TabStop = false;
            // 
            // RunOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::MaSoft.Properties.Resources.bg_alert;
            this.ClientSize = new System.Drawing.Size(321, 230);
            this.ControlBox = false;
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBox_msg);
            this.Controls.Add(this.pictureBox_close);
            this.Controls.Add(this.pictureBox_ico);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(321, 230);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(321, 230);
            this.Name = "RunOnly";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunOnly";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.TextBox textBox_msg;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.PictureBox pictureBox_ico;
    }
}