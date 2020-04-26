namespace WindowsFrontEnd
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.SuppliersComboBox = new System.Windows.Forms.ComboBox();
            this.CompanyComboBox = new System.Windows.Forms.ComboBox();
            this.RemoveCurrentSupplierButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilteredCountButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SuppliersComboBox
            // 
            this.SuppliersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SuppliersComboBox.FormattingEnabled = true;
            this.SuppliersComboBox.Location = new System.Drawing.Point(266, 35);
            this.SuppliersComboBox.Name = "SuppliersComboBox";
            this.SuppliersComboBox.Size = new System.Drawing.Size(206, 21);
            this.SuppliersComboBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.SuppliersComboBox, "Suppliers: implements soft delete");
            // 
            // CompanyComboBox
            // 
            this.CompanyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompanyComboBox.FormattingEnabled = true;
            this.CompanyComboBox.Location = new System.Drawing.Point(32, 35);
            this.CompanyComboBox.Name = "CompanyComboBox";
            this.CompanyComboBox.Size = new System.Drawing.Size(206, 21);
            this.CompanyComboBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.CompanyComboBox, "Companies: no soft delete");
            // 
            // RemoveCurrentSupplierButton
            // 
            this.RemoveCurrentSupplierButton.Enabled = false;
            this.RemoveCurrentSupplierButton.Location = new System.Drawing.Point(338, 75);
            this.RemoveCurrentSupplierButton.Name = "RemoveCurrentSupplierButton";
            this.RemoveCurrentSupplierButton.Size = new System.Drawing.Size(134, 23);
            this.RemoveCurrentSupplierButton.TabIndex = 2;
            this.RemoveCurrentSupplierButton.Text = "Remove current supplier";
            this.toolTip1.SetToolTip(this.RemoveCurrentSupplierButton, "Prompt to soft delete current shipper");
            this.RemoveCurrentSupplierButton.UseVisualStyleBackColor = true;
            this.RemoveCurrentSupplierButton.Click += new System.EventHandler(this.RemoveCurrentSupplierButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Soft deletable = true";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soft deletable = false";
            // 
            // FilteredCountButton
            // 
            this.FilteredCountButton.Enabled = false;
            this.FilteredCountButton.Location = new System.Drawing.Point(338, 113);
            this.FilteredCountButton.Name = "FilteredCountButton";
            this.FilteredCountButton.Size = new System.Drawing.Size(134, 23);
            this.FilteredCountButton.TabIndex = 5;
            this.FilteredCountButton.Text = "Filtered count";
            this.toolTip1.SetToolTip(this.FilteredCountButton, "Get filter/unfilter counts of suppliers");
            this.FilteredCountButton.UseVisualStyleBackColor = true;
            this.FilteredCountButton.Click += new System.EventHandler(this.FilteredCountButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFrontEnd.Properties.Resources.F1;
            this.pictureBox1.Location = new System.Drawing.Point(20, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "From OnModelCreating");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 300);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FilteredCountButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveCurrentSupplierButton);
            this.Controls.Add(this.CompanyComboBox);
            this.Controls.Add(this.SuppliersComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soft Deletables";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SuppliersComboBox;
        private System.Windows.Forms.ComboBox CompanyComboBox;
        private System.Windows.Forms.Button RemoveCurrentSupplierButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FilteredCountButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

