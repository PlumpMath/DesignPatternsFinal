namespace DesignPatternsFinal
{
    partial class NavigationViewForm
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
            this.navigationControl = new System.Windows.Forms.GroupBox();
            this.RoomPanel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // navigationControl
            // 
            this.navigationControl.Location = new System.Drawing.Point(13, 130);
            this.navigationControl.Name = "navigationControl";
            this.navigationControl.Size = new System.Drawing.Size(259, 119);
            this.navigationControl.TabIndex = 5;
            this.navigationControl.TabStop = false;
            this.navigationControl.Text = "Navigation";
            // 
            // RoomPanel
            // 
            this.RoomPanel.Location = new System.Drawing.Point(12, 16);
            this.RoomPanel.Multiline = true;
            this.RoomPanel.Name = "RoomPanel";
            this.RoomPanel.Size = new System.Drawing.Size(259, 114);
            this.RoomPanel.TabIndex = 6;
            // 
            // NavigationViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 256);
            this.Controls.Add(this.RoomPanel);
            this.Controls.Add(this.navigationControl);
            this.Name = "NavigationViewForm";
            this.Text = "NavigationViewForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NavigationViewForm_FormClosed);
            this.Load += new System.EventHandler(this.NavigationViewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox navigationControl;
        private System.Windows.Forms.TextBox RoomPanel;
    }
}