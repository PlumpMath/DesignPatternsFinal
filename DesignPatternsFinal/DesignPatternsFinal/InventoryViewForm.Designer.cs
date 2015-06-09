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
            this.EquipInventoryButton = new System.Windows.Forms.Button();
            this.closeInventoryButton = new System.Windows.Forms.Button();
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
            // EquipInventoryButton
            // 
            this.EquipInventoryButton.Location = new System.Drawing.Point(12, 203);
            this.EquipInventoryButton.Name = "EquipInventoryButton";
            this.EquipInventoryButton.Size = new System.Drawing.Size(75, 23);
            this.EquipInventoryButton.TabIndex = 2;
            this.EquipInventoryButton.Text = "Equip";
            this.EquipInventoryButton.UseVisualStyleBackColor = true;
            this.EquipInventoryButton.Click += new System.EventHandler(this.EquipInventoryButton_Click);
            // 
            // closeInventoryButton
            // 
            this.closeInventoryButton.Location = new System.Drawing.Point(93, 203);
            this.closeInventoryButton.Name = "closeInventoryButton";
            this.closeInventoryButton.Size = new System.Drawing.Size(75, 23);
            this.closeInventoryButton.TabIndex = 3;
            this.closeInventoryButton.Text = "Close";
            this.closeInventoryButton.UseVisualStyleBackColor = true;
            this.closeInventoryButton.Click += new System.EventHandler(this.closeInventoryButton_Click);
            // 
            // InventoryViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.closeInventoryButton);
            this.Controls.Add(this.EquipInventoryButton);
            this.Controls.Add(this.InventoryCheckBox);
            this.Name = "InventoryViewForm";
            this.Text = "InventoryViewForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox InventoryCheckBox;
        private System.Windows.Forms.Button EquipInventoryButton;
        private System.Windows.Forms.Button closeInventoryButton;

    }
}