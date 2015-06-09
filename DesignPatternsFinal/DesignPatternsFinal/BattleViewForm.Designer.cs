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
            this.Return = new System.Windows.Forms.Button();
            this.battleOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // badguyBox
            // 
            this.badguyBox.Location = new System.Drawing.Point(8, 24);
            this.badguyBox.Name = "badguyBox";
            this.badguyBox.Size = new System.Drawing.Size(256, 100);
            this.badguyBox.TabIndex = 0;
            this.badguyBox.TabStop = false;
            this.badguyBox.Text = "Enemies";
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(102, 226);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 2;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Visible = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // battleOutput
            // 
            this.battleOutput.Location = new System.Drawing.Point(8, 130);
            this.battleOutput.Multiline = true;
            this.battleOutput.Name = "battleOutput";
            this.battleOutput.ReadOnly = true;
            this.battleOutput.Size = new System.Drawing.Size(256, 90);
            this.battleOutput.TabIndex = 3;
            // 
            // BattleViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.battleOutput);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.badguyBox);
            this.Name = "BattleViewForm";
            this.Text = "BattleViewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox badguyBox;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.TextBox battleOutput;
    }
}