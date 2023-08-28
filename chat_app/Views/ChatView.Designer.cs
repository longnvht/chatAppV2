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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnChatAndSend = new System.Windows.Forms.Panel();
            this._pnChat = new System.Windows.Forms.Panel();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this._btnSend = new Guna.UI2.WinForms.Guna2Button();
            this._txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this._pnDetail = new System.Windows.Forms.Panel();
            this._lblNameChat = new System.Windows.Forms.Label();
            this._txtNameChat = new Guna.UI2.WinForms.Guna2TextBox();
            this._lsbMembers = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._btnDeleteMember = new Guna.UI2.WinForms.Guna2Button();
            this._btnAddMember = new Guna.UI2.WinForms.Guna2Button();
            this._grbMembers = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this._btnSelect = new Guna.UI2.WinForms.Guna2Button();
            this._txtSearchMember = new Guna.UI2.WinForms.Guna2TextBox();
            this._lsMembers = new chat_app.Views.Controls.ListButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.grbChat = new System.Windows.Forms.GroupBox();
            this._chatList = new chat_app.Views.Controls.ChatList();
            this._txtNewChat = new Guna.UI2.WinForms.Guna2Button();
            this.pnMain.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.pnChatAndSend.SuspendLayout();
            this.tlpFooter.SuspendLayout();
            this._pnDetail.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this._grbMembers.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.grbChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.tlpMain);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(755, 450);
            this.pnMain.TabIndex = 0;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 328F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnChatAndSend, 1, 0);
            this.tlpMain.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(755, 450);
            this.tlpMain.TabIndex = 0;
            // 
            // pnChatAndSend
            // 
            this.pnChatAndSend.Controls.Add(this._pnChat);
            this.pnChatAndSend.Controls.Add(this.tlpFooter);
            this.pnChatAndSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnChatAndSend.Location = new System.Drawing.Point(331, 3);
            this.pnChatAndSend.Name = "pnChatAndSend";
            this.pnChatAndSend.Size = new System.Drawing.Size(421, 444);
            this.pnChatAndSend.TabIndex = 0;
            // 
            // _pnChat
            // 
            this._pnChat.AutoScroll = true;
            this._pnChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnChat.Location = new System.Drawing.Point(0, 0);
            this._pnChat.Name = "_pnChat";
            this._pnChat.Size = new System.Drawing.Size(421, 399);
            this._pnChat.TabIndex = 4;
            // 
            // tlpFooter
            // 
            this.tlpFooter.ColumnCount = 2;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpFooter.Controls.Add(this._btnSend, 1, 0);
            this.tlpFooter.Controls.Add(this._txtMessage, 0, 0);
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpFooter.Location = new System.Drawing.Point(0, 399);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Size = new System.Drawing.Size(421, 45);
            this.tlpFooter.TabIndex = 3;
            // 
            // _btnSend
            // 
            this._btnSend.BorderRadius = 3;
            this._btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnSend.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSend.ForeColor = System.Drawing.Color.White;
            this._btnSend.Location = new System.Drawing.Point(274, 3);
            this._btnSend.Name = "_btnSend";
            this._btnSend.Size = new System.Drawing.Size(144, 39);
            this._btnSend.TabIndex = 5;
            this._btnSend.Text = "Gửi";
            // 
            // _txtMessage
            // 
            this._txtMessage.BorderRadius = 3;
            this._txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtMessage.DefaultText = "";
            this._txtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtMessage.Location = new System.Drawing.Point(3, 4);
            this._txtMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtMessage.Name = "_txtMessage";
            this._txtMessage.PasswordChar = '\0';
            this._txtMessage.PlaceholderText = "";
            this._txtMessage.SelectedText = "";
            this._txtMessage.Size = new System.Drawing.Size(265, 37);
            this._txtMessage.TabIndex = 6;
            // 
            // _pnDetail
            // 
            this._pnDetail.BackColor = System.Drawing.SystemColors.Control;
            this._pnDetail.Controls.Add(this._lblNameChat);
            this._pnDetail.Controls.Add(this._txtNameChat);
            this._pnDetail.Controls.Add(this._lsbMembers);
            this._pnDetail.Controls.Add(this.tableLayoutPanel1);
            this._pnDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this._pnDetail.Location = new System.Drawing.Point(755, 0);
            this._pnDetail.Name = "_pnDetail";
            this._pnDetail.Size = new System.Drawing.Size(260, 450);
            this._pnDetail.TabIndex = 2;
            this._pnDetail.Visible = false;
            // 
            // _lblNameChat
            // 
            this._lblNameChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblNameChat.AutoSize = true;
            this._lblNameChat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblNameChat.Location = new System.Drawing.Point(6, 9);
            this._lblNameChat.Name = "_lblNameChat";
            this._lblNameChat.Size = new System.Drawing.Size(153, 20);
            this._lblNameChat.TabIndex = 9;
            this._lblNameChat.Text = "Tên cuộc trò chuyện:";
            // 
            // _txtNameChat
            // 
            this._txtNameChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtNameChat.BorderRadius = 3;
            this._txtNameChat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtNameChat.DefaultText = "";
            this._txtNameChat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtNameChat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtNameChat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtNameChat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtNameChat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtNameChat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtNameChat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtNameChat.Location = new System.Drawing.Point(3, 33);
            this._txtNameChat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtNameChat.Name = "_txtNameChat";
            this._txtNameChat.PasswordChar = '\0';
            this._txtNameChat.PlaceholderText = "";
            this._txtNameChat.SelectedText = "";
            this._txtNameChat.Size = new System.Drawing.Size(254, 37);
            this._txtNameChat.TabIndex = 8;
            // 
            // _lsbMembers
            // 
            this._lsbMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lsbMembers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lsbMembers.FormattingEnabled = true;
            this._lsbMembers.ItemHeight = 20;
            this._lsbMembers.Location = new System.Drawing.Point(5, 77);
            this._lsbMembers.Name = "_lsbMembers";
            this._lsbMembers.Size = new System.Drawing.Size(252, 184);
            this._lsbMembers.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this._btnDeleteMember, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._btnAddMember, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 402);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _btnDeleteMember
            // 
            this._btnDeleteMember.BorderRadius = 3;
            this._btnDeleteMember.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._btnDeleteMember.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._btnDeleteMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnDeleteMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._btnDeleteMember.Enabled = false;
            this._btnDeleteMember.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnDeleteMember.ForeColor = System.Drawing.Color.White;
            this._btnDeleteMember.Location = new System.Drawing.Point(133, 3);
            this._btnDeleteMember.Name = "_btnDeleteMember";
            this._btnDeleteMember.Size = new System.Drawing.Size(124, 42);
            this._btnDeleteMember.TabIndex = 8;
            this._btnDeleteMember.Text = "Xóa người";
            // 
            // _btnAddMember
            // 
            this._btnAddMember.BorderRadius = 3;
            this._btnAddMember.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._btnAddMember.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._btnAddMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnAddMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._btnAddMember.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAddMember.ForeColor = System.Drawing.Color.White;
            this._btnAddMember.Location = new System.Drawing.Point(3, 3);
            this._btnAddMember.Name = "_btnAddMember";
            this._btnAddMember.Size = new System.Drawing.Size(124, 42);
            this._btnAddMember.TabIndex = 7;
            this._btnAddMember.Text = "Thêm người";
            // 
            // _grbMembers
            // 
            this._grbMembers.Controls.Add(this.tableLayoutPanel2);
            this._grbMembers.Controls.Add(this._txtSearchMember);
            this._grbMembers.Controls.Add(this._lsMembers);
            this._grbMembers.Dock = System.Windows.Forms.DockStyle.Right;
            this._grbMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._grbMembers.Location = new System.Drawing.Point(512, 0);
            this._grbMembers.Name = "_grbMembers";
            this._grbMembers.Size = new System.Drawing.Size(243, 450);
            this._grbMembers.TabIndex = 3;
            this._grbMembers.TabStop = false;
            this._grbMembers.Text = "Chọn thành viên";
            this._grbMembers.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this._btnCancel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._btnSelect, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 402);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(237, 45);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // _btnCancel
            // 
            this._btnCancel.BorderRadius = 3;
            this._btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCancel.ForeColor = System.Drawing.Color.White;
            this._btnCancel.Location = new System.Drawing.Point(121, 3);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(113, 39);
            this._btnCancel.TabIndex = 7;
            this._btnCancel.Text = "Hủy";
            // 
            // _btnSelect
            // 
            this._btnSelect.BorderRadius = 3;
            this._btnSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._btnSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._btnSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._btnSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._btnSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnSelect.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSelect.ForeColor = System.Drawing.Color.White;
            this._btnSelect.Location = new System.Drawing.Point(3, 3);
            this._btnSelect.Name = "_btnSelect";
            this._btnSelect.Size = new System.Drawing.Size(112, 39);
            this._btnSelect.TabIndex = 6;
            this._btnSelect.Text = "Chọn";
            // 
            // _txtSearchMember
            // 
            this._txtSearchMember.BorderRadius = 3;
            this._txtSearchMember.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtSearchMember.DefaultText = "";
            this._txtSearchMember.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this._txtSearchMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this._txtSearchMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtSearchMember.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this._txtSearchMember.Dock = System.Windows.Forms.DockStyle.Top;
            this._txtSearchMember.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtSearchMember.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtSearchMember.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this._txtSearchMember.Location = new System.Drawing.Point(3, 20);
            this._txtSearchMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtSearchMember.Name = "_txtSearchMember";
            this._txtSearchMember.PasswordChar = '\0';
            this._txtSearchMember.PlaceholderText = "Tìm thành viên";
            this._txtSearchMember.SelectedText = "";
            this._txtSearchMember.Size = new System.Drawing.Size(237, 37);
            this._txtSearchMember.TabIndex = 7;
            // 
            // _lsMembers
            // 
            this._lsMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lsMembers.AutoSpacing = false;
            this._lsMembers.DataSource = null;
            this._lsMembers.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this._lsMembers.ItemBorderRadius = 0;
            this._lsMembers.ItemBorderThickness = 0;
            this._lsMembers.ItemBottomDisplayMember = "";
            this._lsMembers.ItemFillColor = System.Drawing.Color.WhiteSmoke;
            this._lsMembers.ItemFont = new System.Drawing.Font("Segoe UI", 10F);
            this._lsMembers.ItemForceColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this._lsMembers.ItemHeight = 50;
            this._lsMembers.ItemSpace = 3;
            this._lsMembers.ItemTopDisplayMember = "strNameStaff";
            this._lsMembers.ItemWidth = 200;
            this._lsMembers.Location = new System.Drawing.Point(3, 65);
            this._lsMembers.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._lsMembers.MinMargin = 0;
            this._lsMembers.Name = "_lsMembers";
            this._lsMembers.Padding = new System.Windows.Forms.Padding(3);
            this._lsMembers.Size = new System.Drawing.Size(237, 330);
            this._lsMembers.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this._txtNewChat, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.grbChat, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(322, 444);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // grbChat
            // 
            this.grbChat.Controls.Add(this._chatList);
            this.grbChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChat.Location = new System.Drawing.Point(3, 3);
            this.grbChat.Name = "grbChat";
            this.grbChat.Size = new System.Drawing.Size(316, 393);
            this.grbChat.TabIndex = 3;
            this.grbChat.TabStop = false;
            this.grbChat.Text = "Trò chuyện";
            // 
            // _chatList
            // 
            this._chatList.BackColor = System.Drawing.SystemColors.ControlLight;
            this._chatList.DataMember = "Name";
            this._chatList.DataSource = null;
            this._chatList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._chatList.Location = new System.Drawing.Point(3, 20);
            this._chatList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._chatList.Name = "_chatList";
            this._chatList.Size = new System.Drawing.Size(310, 370);
            this._chatList.TabIndex = 0;
            // 
            // _txtNewChat
            // 
            this._txtNewChat.BorderRadius = 3;
            this._txtNewChat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._txtNewChat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._txtNewChat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._txtNewChat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._txtNewChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtNewChat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtNewChat.ForeColor = System.Drawing.Color.White;
            this._txtNewChat.Location = new System.Drawing.Point(3, 402);
            this._txtNewChat.Name = "_txtNewChat";
            this._txtNewChat.Size = new System.Drawing.Size(316, 39);
            this._txtNewChat.TabIndex = 7;
            this._txtNewChat.Text = "New Chat";
            // 
            // ChatView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 450);
            this.Controls.Add(this._grbMembers);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this._pnDetail);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ChatView";
            this.Text = "ChatView";
            this.pnMain.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.pnChatAndSend.ResumeLayout(false);
            this.tlpFooter.ResumeLayout(false);
            this._pnDetail.ResumeLayout(false);
            this._pnDetail.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this._grbMembers.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.grbChat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnChatAndSend;
        private System.Windows.Forms.Panel _pnChat;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private Guna.UI2.WinForms.Guna2Button _btnSend;
        private Guna.UI2.WinForms.Guna2TextBox _txtMessage;
        private System.Windows.Forms.Panel _pnDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button _btnDeleteMember;
        private Guna.UI2.WinForms.Guna2Button _btnAddMember;
        private System.Windows.Forms.ListBox _lsbMembers;
        private System.Windows.Forms.GroupBox _grbMembers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button _btnCancel;
        private Guna.UI2.WinForms.Guna2Button _btnSelect;
        private Guna.UI2.WinForms.Guna2TextBox _txtSearchMember;
        private Views.Controls.ListButton _lsMembers;
        private System.Windows.Forms.Label _lblNameChat;
        private Guna.UI2.WinForms.Guna2TextBox _txtNameChat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2Button _txtNewChat;
        private System.Windows.Forms.GroupBox grbChat;
        private Views.Controls.ChatList _chatList;
    }
}

