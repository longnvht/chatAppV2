﻿using System.Drawing;
using System.Windows.Forms;

namespace chat_app.Views.Controls
{
    partial class ChatList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnChatList = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnChatList
            // 
            this.pnChatList.AutoScroll = true;
            this.pnChatList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnChatList.Location = new System.Drawing.Point(0, 0);
            this.pnChatList.Name = "pnChatList";
            this.pnChatList.Size = new System.Drawing.Size(185, 134);
            this.pnChatList.TabIndex = 0;
            // 
            // ChatList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnChatList);
            this.Name = "ChatList";
            this.Size = new System.Drawing.Size(185, 134);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnChatList;
    }
}
