namespace DesignPatternsFinal
{
    partial class InventoryViewForm
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
            this.InventoryCheckBox = new System.Windows.Forms.CheckedListBox();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.equipButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InventoryCheckBox
            // 
            this.InventoryCheckBox.FormattingEnabled = true;
            this.InventoryCheckBox.Location = new System.Drawing.Point(12, 12);
            this.InventoryCheckBox.Name = "InventoryCheckBox";
            this.InventoryCheckBox.Size = new System.Drawing.Size(260, 184);
            this.InventoryCheckBox.TabIndex = 0;
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(12, 199);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(0, 13);
            this.InventoryLabel.TabIndex = 4;
            // 
            // equipButton
            // 
            this.equipButton.Location = new System.Drawing.Point(12, 215);
            this.equipButton.Name = "equipButton";
            this.equipButton.Size = new System.Drawing.Size(75, 23);
            this.equipButton.TabIndex = 5;
            this.equipButton.Text = "Equip";
            this.equipButton.UseVisualStyleBackColor = true;
            this.equipButton.Click += new System.EventHandler(this.equipButton_Click);
            // 
            // InventoryViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.equipButton);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.InventoryCheckBox);
            this.Name = "InventoryViewForm";
            this.Text = "InventoryViewForm";
            this.Load += new System.EventHandler(this.InventoryViewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox InventoryCheckBox;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Button equipButton;

    }
}