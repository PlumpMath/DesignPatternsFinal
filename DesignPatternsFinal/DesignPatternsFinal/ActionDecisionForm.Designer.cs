namespace DesignPatternsFinal
{
    partial class ActionDecisionForm
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
            this.actionBox = new System.Windows.Forms.GroupBox();
            this.actionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // actionBox
            // 
            this.actionBox.Location = new System.Drawing.Point(14, 15);
            this.actionBox.Name = "actionBox";
            this.actionBox.Size = new System.Drawing.Size(255, 144);
            this.actionBox.TabIndex = 0;
            this.actionBox.TabStop = false;
            this.actionBox.Text = "groupBox1";
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Location = new System.Drawing.Point(69, 189);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(35, 13);
            this.actionLabel.TabIndex = 1;
            this.actionLabel.Text = "label1";
            // 
            // ActionDecisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.actionLabel);
            this.Controls.Add(this.actionBox);
            this.Name = "ActionDecisionForm";
            this.Text = "ActionDecisionForm";
            this.Load += new System.EventHandler(this.ActionDecisionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox actionBox;
        private System.Windows.Forms.Label actionLabel;
    }
}