using System.Windows.Forms;

namespace chat_app.Views.Controls
{
    partial class ChatListItem
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
            this.pnChatListItem = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelTime = new System.Windows.Forms.Label();
            this.pictureBoxAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pnChatListItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnChatListItem
            // 
            this.pnChatListItem.AutoRoundedCorners = true;
            this.pnChatListItem.BackColor = System.Drawing.Color.Transparent;
            this.pnChatListItem.BorderRadius = 42;
            this.pnChatListItem.Controls.Add(this.labelTime);
            this.pnChatListItem.Controls.Add(this.pictureBoxAvatar);
            this.pnChatListItem.Controls.Add(this.labelMessage);
            this.pnChatListItem.Controls.Add(this.labelName);
            this.pnChatListItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnChatListItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(144)))), ((int)(((byte)(223)))));
            this.pnChatListItem.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.pnChatListItem.Location = new System.Drawing.Point(0, 0);
            this.pnChatListItem.Name = "pnChatListItem";
            this.pnChatListItem.Size = new System.Drawing.Size(348, 87);
            this.pnChatListItem.TabIndex = 0;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelTime.Location = new System.Drawing.Point(273, 15);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(69, 20);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "22:10 PM";
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxAvatar.ImageRotate = 0F;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(9, 9);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxAvatar.Size = new System.Drawing.Size(69, 69);
            this.pictureBoxAvatar.TabIndex = 0;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelMessage.Location = new System.Drawing.Point(93, 59);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(50, 20);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "label1";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(93, 14);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 21);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label1";
            // 
            // ChatListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnChatListItem);
            this.Name = "ChatListItem";
            this.Size = new System.Drawing.Size(348, 87);
            this.pnChatListItem.ResumeLayout(false);
            this.pnChatListItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnChatListItem;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxAvatar;
        private Label labelTime;
        private Label labelMessage;
        private Label labelName;
    }
}

