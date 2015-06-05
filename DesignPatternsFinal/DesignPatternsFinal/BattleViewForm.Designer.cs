namespace DesignPatternsFinal
{
    partial class BattleViewForm
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
            this.badguyBox = new System.Windows.Forms.GroupBox();
            this.battleOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // badguyBox
            // 
            this.badguyBox.Location = new System.Drawing.Point(8, 24);
            this.badguyBox.Name = "badguyBox";
            this.badguyBox.Size = new System.Drawing.Size(256, 126);
            this.badguyBox.TabIndex = 0;
            this.badguyBox.TabStop = false;
            this.badguyBox.Text = "Enemies";
            // 
            // battleOutput
            // 
            this.battleOutput.AutoSize = true;
            this.battleOutput.Location = new System.Drawing.Point(15, 157);
            this.battleOutput.Name = "battleOutput";
            this.battleOutput.Size = new System.Drawing.Size(35, 13);
            this.battleOutput.TabIndex = 1;
            this.battleOutput.Text = "label1";
            // 
            // BattleViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.battleOutput);
            this.Controls.Add(this.badguyBox);
            this.Name = "BattleViewForm";
            this.Text = "BattleViewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox badguyBox;
        private System.Windows.Forms.Label battleOutput;
    }
}