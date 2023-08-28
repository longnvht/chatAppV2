using System.Drawing;
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
            this.flpChatList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpChatList
            // 
            this.flpChatList.AutoScroll = true;
            this.flpChatList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpChatList.Location = new System.Drawing.Point(0, 0);
            this.flpChatList.Name = "flpChatList";
            this.flpChatList.Size = new System.Drawing.Size(395, 345);
            this.flpChatList.TabIndex = 0;
            // 
            // ChatList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpChatList);
            this.Name = "ChatList";
            this.Size = new System.Drawing.Size(395, 345);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flpChatList;
    }
}
