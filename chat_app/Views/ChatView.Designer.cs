namespace chat_app
{
    partial class ChatView
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnMessageList = new System.Windows.Forms.Panel();
            this._pnChat = new System.Windows.Forms.Panel();
            this.pnMoreAction = new System.Windows.Forms.Panel();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this._txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnUserList = new System.Windows.Forms.Panel();
            this.pnTools = new System.Windows.Forms.Panel();
            this.ptbAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblChatName = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnChatTiltle = new System.Windows.Forms.Panel();
            this.btnNewChat = new Guna.UI2.WinForms.Guna2Button();
            this.btnSort = new Guna.UI2.WinForms.Guna2Button();
            this.messageListControl = new chat_app.Views.Controls.MessageList();
            this.chatListControl = new chat_app.Views.Controls.ChatList();
            this.arrowButton1 = new chat_app.Views.Controls.ArrowButton();
            this.pnMain.SuspendLayout();
            this.pnMessageList.SuspendLayout();
            this._pnChat.SuspendLayout();
            this.pnMoreAction.SuspendLayout();
            this.pnTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.pnLeft.SuspendLayout();
            this.pnChatTiltle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnMessageList);
            this.pnMain.Controls.Add(this.pnUserList);
            this.pnMain.Controls.Add(this.pnTools);
            this.pnMain.Controls.Add(this.pnLeft);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1353, 695);
            this.pnMain.TabIndex = 0;
            // 
            // pnMessageList
            // 
            this.pnMessageList.Controls.Add(this._pnChat);
            this.pnMessageList.Controls.Add(this.pnMoreAction);
            this.pnMessageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMessageList.Location = new System.Drawing.Point(373, 62);
            this.pnMessageList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnMessageList.Name = "pnMessageList";
            this.pnMessageList.Size = new System.Drawing.Size(633, 633);
            this.pnMessageList.TabIndex = 0;
            // 
            // _pnChat
            // 
            this._pnChat.AutoScroll = true;
            this._pnChat.BackColor = System.Drawing.Color.WhiteSmoke;
            this._pnChat.Controls.Add(this.messageListControl);
            this._pnChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnChat.Location = new System.Drawing.Point(0, 0);
            this._pnChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._pnChat.Name = "_pnChat";
            this._pnChat.Size = new System.Drawing.Size(633, 535);
            this._pnChat.TabIndex = 4;
            // 
            // pnMoreAction
            // 
            this.pnMoreAction.Controls.Add(this.guna2Button5);
            this.pnMoreAction.Controls.Add(this.guna2Button4);
            this.pnMoreAction.Controls.Add(this.btnSend);
            this.pnMoreAction.Controls.Add(this.guna2Button3);
            this.pnMoreAction.Controls.Add(this._txtMessage);
            this.pnMoreAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnMoreAction.Location = new System.Drawing.Point(0, 535);
            this.pnMoreAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnMoreAction.Name = "pnMoreAction";
            this.pnMoreAction.Size = new System.Drawing.Size(633, 98);
            this.pnMoreAction.TabIndex = 7;
            // 
            // guna2Button5
            // 
            this.guna2Button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button5.BorderRadius = 3;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            this.guna2Button5.Image = global::chat_app.Properties.Resources.Happy;
            this.guna2Button5.Location = new System.Drawing.Point(177, 58);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(40, 37);
            this.guna2Button5.TabIndex = 0;
            this.guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Button4
            // 
            this.guna2Button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button4.BorderRadius = 3;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            this.guna2Button4.Image = global::chat_app.Properties.Resources.Image;
            this.guna2Button4.Location = new System.Drawing.Point(129, 58);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(40, 37);
            this.guna2Button4.TabIndex = 0;
            this.guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BorderRadius = 3;
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.FillColor = System.Drawing.SystemColors.Control;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            this.btnSend.Image = global::chat_app.Properties.Resources.Sent;
            this.btnSend.Location = new System.Drawing.Point(511, 58);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(40, 37);
            this.btnSend.TabIndex = 0;
            this.btnSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button3.BorderRadius = 3;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            this.guna2Button3.Image = global::chat_app.Properties.Resources.Attach;
            this.guna2Button3.Location = new System.Drawing.Point(81, 57);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(40, 37);
            this.guna2Button3.TabIndex = 0;
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // _txtMessage
            // 
            this._txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtMessage.BorderRadius = 3;
            this._txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtMessage.DefaultText = "";
            this._txtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtMessage.IconRightSize = new System.Drawing.Size(25, 25);
            this._txtMessage.Location = new System.Drawing.Point(81, 4);
            this._txtMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._txtMessage.Multiline = true;
            this._txtMessage.Name = "_txtMessage";
            this._txtMessage.PasswordChar = '\0';
            this._txtMessage.PlaceholderText = "Type a new message";
            this._txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtMessage.SelectedText = "";
            this._txtMessage.Size = new System.Drawing.Size(469, 49);
            this._txtMessage.TabIndex = 6;
            // 
            // pnUserList
            // 
            this.pnUserList.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnUserList.Location = new System.Drawing.Point(1006, 62);
            this.pnUserList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnUserList.Name = "pnUserList";
            this.pnUserList.Size = new System.Drawing.Size(347, 633);
            this.pnUserList.TabIndex = 5;
            // 
            // pnTools
            // 
            this.pnTools.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnTools.Controls.Add(this.ptbAvatar);
            this.pnTools.Controls.Add(this.lblChatName);
            this.pnTools.Controls.Add(this.guna2Button2);
            this.pnTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTools.Location = new System.Drawing.Point(373, 0);
            this.pnTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnTools.Name = "pnTools";
            this.pnTools.Size = new System.Drawing.Size(980, 62);
            this.pnTools.TabIndex = 4;
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Image = global::chat_app.Properties.Resources.avatar11;
            this.ptbAvatar.ImageRotate = 0F;
            this.ptbAvatar.Location = new System.Drawing.Point(8, 4);
            this.ptbAvatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptbAvatar.Size = new System.Drawing.Size(53, 49);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAvatar.TabIndex = 2;
            this.ptbAvatar.TabStop = false;
            // 
            // lblChatName
            // 
            this.lblChatName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblChatName.AutoSize = true;
            this.lblChatName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChatName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            this.lblChatName.Location = new System.Drawing.Point(88, 17);
            this.lblChatName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChatName.Name = "lblChatName";
            this.lblChatName.Size = new System.Drawing.Size(129, 28);
            this.lblChatName.TabIndex = 1;
            this.lblChatName.Text = "Friend Name";
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Button2.BorderRadius = 6;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            this.guna2Button2.Image = global::chat_app.Properties.Resources.AddUser;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.Location = new System.Drawing.Point(831, 10);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(127, 43);
            this.guna2Button2.TabIndex = 0;
            this.guna2Button2.Text = "Add User";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pnLeft
            // 
            this.pnLeft.AutoScroll = true;
            this.pnLeft.Controls.Add(this.chatListControl);
            this.pnLeft.Controls.Add(this.pnChatTiltle);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(373, 695);
            this.pnLeft.TabIndex = 6;
            // 
            // pnChatTiltle
            // 
            this.pnChatTiltle.BackColor = System.Drawing.SystemColors.Control;
            this.pnChatTiltle.Controls.Add(this.btnNewChat);
            this.pnChatTiltle.Controls.Add(this.btnSort);
            this.pnChatTiltle.Controls.Add(this.arrowButton1);
            this.pnChatTiltle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChatTiltle.Location = new System.Drawing.Point(0, 0);
            this.pnChatTiltle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnChatTiltle.Name = "pnChatTiltle";
            this.pnChatTiltle.Size = new System.Drawing.Size(373, 62);
            this.pnChatTiltle.TabIndex = 0;
            // 
            // btnNewChat
            // 
            this.btnNewChat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNewChat.BorderRadius = 6;
            this.btnNewChat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewChat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewChat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewChat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewChat.FillColor = System.Drawing.SystemColors.Control;
            this.btnNewChat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNewChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            this.btnNewChat.Image = global::chat_app.Properties.Resources.Create;
            this.btnNewChat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewChat.Location = new System.Drawing.Point(177, 10);
            this.btnNewChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewChat.Name = "btnNewChat";
            this.btnNewChat.Size = new System.Drawing.Size(87, 43);
            this.btnNewChat.TabIndex = 0;
            this.btnNewChat.Text = "New";
            this.btnNewChat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSort
            // 
            this.btnSort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSort.BorderRadius = 6;
            this.btnSort.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSort.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSort.FillColor = System.Drawing.SystemColors.Control;
            this.btnSort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            this.btnSort.Image = global::chat_app.Properties.Resources.filter;
            this.btnSort.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSort.Location = new System.Drawing.Point(272, 10);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(87, 43);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort";
            this.btnSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // messageListControl
            // 
            this.messageListControl.AutoScroll = true;
            this.messageListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageListControl.Location = new System.Drawing.Point(0, 0);
            this.messageListControl.Margin = new System.Windows.Forms.Padding(4);
            this.messageListControl.MessageSource = null;
            this.messageListControl.Name = "messageListControl";
            this.messageListControl.SenderID = 0;
            this.messageListControl.Size = new System.Drawing.Size(633, 535);
            this.messageListControl.TabIndex = 0;
            // 
            // chatListControl
            // 
            this.chatListControl.DataSource = null;
            this.chatListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatListControl.ItemBackColor = System.Drawing.SystemColors.Control;
            this.chatListControl.ItemHeight = 60;
            this.chatListControl.ItemHoverColor = System.Drawing.Color.White;
            this.chatListControl.Location = new System.Drawing.Point(0, 62);
            this.chatListControl.Margin = new System.Windows.Forms.Padding(5);
            this.chatListControl.Name = "chatListControl";
            this.chatListControl.Size = new System.Drawing.Size(373, 633);
            this.chatListControl.TabIndex = 0;
            // 
            // arrowButton1
            // 
            this.arrowButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.arrowButton1.BorderRadius = 6;
            this.arrowButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.arrowButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.arrowButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.arrowButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.arrowButton1.FillColor = System.Drawing.SystemColors.Control;
            this.arrowButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.arrowButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(145)))));
            this.arrowButton1.Location = new System.Drawing.Point(13, 10);
            this.arrowButton1.Margin = new System.Windows.Forms.Padding(4);
            this.arrowButton1.Name = "arrowButton1";
            this.arrowButton1.Size = new System.Drawing.Size(93, 43);
            this.arrowButton1.TabIndex = 0;
            this.arrowButton1.Text = "Chat";
            this.arrowButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ChatView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 695);
            this.Controls.Add(this.pnMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "ChatView";
            this.Text = "ChatView";
            this.pnMain.ResumeLayout(false);
            this.pnMessageList.ResumeLayout(false);
            this._pnChat.ResumeLayout(false);
            this.pnMoreAction.ResumeLayout(false);
            this.pnTools.ResumeLayout(false);
            this.pnTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.pnLeft.ResumeLayout(false);
            this.pnChatTiltle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnMessageList;
        private System.Windows.Forms.Panel _pnChat;
        private Guna.UI2.WinForms.Guna2TextBox _txtMessage;
        private System.Windows.Forms.Panel pnTools;
        private System.Windows.Forms.Panel pnUserList;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnChatTiltle;
        private Views.Controls.ArrowButton arrowButton1;
        private Guna.UI2.WinForms.Guna2Button btnSort;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label lblChatName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ptbAvatar;
        private System.Windows.Forms.Panel pnMoreAction;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Views.Controls.ChatList chatListControl;
        private Views.Controls.MessageList messageListControl;
        private Guna.UI2.WinForms.Guna2Button btnNewChat;
        private Guna.UI2.WinForms.Guna2Button btnSend;
    }
}

