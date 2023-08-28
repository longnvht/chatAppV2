namespace chat_app.Views.Controls
{
    partial class ListButton
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
            this.flpList = new System.Windows.Forms.FlowLayoutPanel();
            this.scrList = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.SuspendLayout();
            // 
            // flpList
            // 
            this.flpList.AutoScroll = true;
            this.flpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpList.Location = new System.Drawing.Point(0, 0);
            this.flpList.Name = "flpList";
            this.flpList.Padding = new System.Windows.Forms.Padding(6);
            this.flpList.Size = new System.Drawing.Size(598, 316);
            this.flpList.TabIndex = 1;
            // 
            // scrList
            // 
            this.scrList.BindingContainer = this.flpList;
            this.scrList.BorderRadius = 6;
            this.scrList.InUpdate = false;
            this.scrList.LargeChange = 316;
            this.scrList.Location = new System.Drawing.Point(579, 0);
            this.scrList.Maximum = 321;
            this.scrList.Name = "scrList";
            this.scrList.ScrollbarSize = 18;
            this.scrList.Size = new System.Drawing.Size(18, 316);
            this.scrList.SmallChange = 5;
            this.scrList.TabIndex = 2;
            // 
            // ListButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scrList);
            this.Controls.Add(this.flpList);
            this.Name = "ListButton";
            this.Size = new System.Drawing.Size(598, 316);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpList;
        private Guna.UI2.WinForms.Guna2VScrollBar scrList;
    }
}
