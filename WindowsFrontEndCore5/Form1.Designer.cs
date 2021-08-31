
namespace WindowsFrontEndCore5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.SuppliersComboBox.Location = new System.Drawing.Point(310, 40);
            this.SuppliersComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SuppliersComboBox.Name = "SuppliersComboBox";
            this.SuppliersComboBox.Size = new System.Drawing.Size(240, 23);
            this.SuppliersComboBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.SuppliersComboBox, "Suppliers: implements soft delete");
            // 
            // CompanyComboBox
            // 
            this.CompanyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompanyComboBox.FormattingEnabled = true;
            this.CompanyComboBox.Location = new System.Drawing.Point(37, 40);
            this.CompanyComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CompanyComboBox.Name = "CompanyComboBox";
            this.CompanyComboBox.Size = new System.Drawing.Size(240, 23);
            this.CompanyComboBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.CompanyComboBox, "Companies: no soft delete");
            // 
            // RemoveCurrentSupplierButton
            // 
            this.RemoveCurrentSupplierButton.Enabled = false;
            this.RemoveCurrentSupplierButton.Location = new System.Drawing.Point(394, 87);
            this.RemoveCurrentSupplierButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RemoveCurrentSupplierButton.Name = "RemoveCurrentSupplierButton";
            this.RemoveCurrentSupplierButton.Size = new System.Drawing.Size(156, 27);
            this.RemoveCurrentSupplierButton.TabIndex = 2;
            this.RemoveCurrentSupplierButton.Text = "Remove current supplier";
            this.toolTip1.SetToolTip(this.RemoveCurrentSupplierButton, "Prompt to soft delete current shipper");
            this.RemoveCurrentSupplierButton.UseVisualStyleBackColor = true;
            this.RemoveCurrentSupplierButton.Click += new System.EventHandler(this.RemoveCurrentSupplierButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Soft deletable = true";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soft deletable = false";
            // 
            // FilteredCountButton
            // 
            this.FilteredCountButton.Enabled = false;
            this.FilteredCountButton.Location = new System.Drawing.Point(394, 130);
            this.FilteredCountButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FilteredCountButton.Name = "FilteredCountButton";
            this.FilteredCountButton.Size = new System.Drawing.Size(156, 27);
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
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 180);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "From OnModelCreating");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 346);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FilteredCountButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveCurrentSupplierButton);
            this.Controls.Add(this.CompanyComboBox);
            this.Controls.Add(this.SuppliersComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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

