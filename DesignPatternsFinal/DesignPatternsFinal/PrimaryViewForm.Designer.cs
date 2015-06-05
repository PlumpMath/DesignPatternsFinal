namespace DesignPatternsFinal
{
    partial class PrimaryViewForm
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
            this.partyBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // partyBox
            // 
            this.partyBox.Location = new System.Drawing.Point(18, 20);
            this.partyBox.Name = "partyBox";
            this.partyBox.Size = new System.Drawing.Size(393, 209);
            this.partyBox.TabIndex = 0;
            this.partyBox.TabStop = false;
            this.partyBox.Text = "partyBox";
            // 
            // PrimaryViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 261);
            this.Controls.Add(this.partyBox);
            this.Name = "PrimaryViewForm";
            this.Text = "PrimaryViewForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox partyBox;
    }
}