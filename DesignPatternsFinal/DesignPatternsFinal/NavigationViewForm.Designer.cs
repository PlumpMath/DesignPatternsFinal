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
            this.RoomPanel = new System.Windows.Forms.Panel();
            this.navigationControl = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // RoomPanel
            // 
            this.RoomPanel.Location = new System.Drawing.Point(12, 12);
            this.RoomPanel.Name = "RoomPanel";
            this.RoomPanel.Size = new System.Drawing.Size(260, 152);
            this.RoomPanel.TabIndex = 4;
            // 
            // navigationControl
            // 
            this.navigationControl.Location = new System.Drawing.Point(13, 170);
            this.navigationControl.Name = "navigationControl";
            this.navigationControl.Size = new System.Drawing.Size(259, 79);
            this.navigationControl.TabIndex = 5;
            this.navigationControl.TabStop = false;
            this.navigationControl.Text = "Navigation";
            // 
            // NavigationViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 256);
            this.Controls.Add(this.navigationControl);
            this.Controls.Add(this.RoomPanel);
            this.Name = "NavigationViewForm";
            this.Text = "NavigationViewForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NavigationViewForm_FormClosed);
            this.Load += new System.EventHandler(this.NavigationViewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RoomPanel;
        private System.Windows.Forms.GroupBox navigationControl;
    }
}