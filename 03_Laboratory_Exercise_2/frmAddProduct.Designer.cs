namespace _03_Laboratory_Exercise_2
{
    partial class frmAddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.dtPicketMfgDate = new System.Windows.Forms.DateTimePicker();
            this.dtPickerExpDate = new System.Windows.Forms.DateTimePicker();
            this.richTxtDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.gripViewProductList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gripViewProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(43, 87);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Product";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(43, 114);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Qty.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Exp. Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mfg. Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sell Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Description";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(129, 84);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 8;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(129, 200);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 8;
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(129, 226);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSellPrice.TabIndex = 8;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(129, 111);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 9;
            // 
            // dtPicketMfgDate
            // 
            this.dtPicketMfgDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicketMfgDate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtPicketMfgDate.Location = new System.Drawing.Point(129, 145);
            this.dtPicketMfgDate.Name = "dtPicketMfgDate";
            this.dtPicketMfgDate.Size = new System.Drawing.Size(200, 20);
            this.dtPicketMfgDate.TabIndex = 10;
            // 
            // dtPickerExpDate
            // 
            this.dtPickerExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerExpDate.Location = new System.Drawing.Point(129, 171);
            this.dtPickerExpDate.Name = "dtPickerExpDate";
            this.dtPickerExpDate.Size = new System.Drawing.Size(200, 20);
            this.dtPickerExpDate.TabIndex = 10;
            // 
            // richTxtDescription
            // 
            this.richTxtDescription.Location = new System.Drawing.Point(528, 67);
            this.richTxtDescription.Name = "richTxtDescription";
            this.richTxtDescription.Size = new System.Drawing.Size(216, 188);
            this.richTxtDescription.TabIndex = 11;
            this.richTxtDescription.Text = "";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(573, 273);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.Text = "button1";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // gripViewProductList
            // 
            this.gripViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gripViewProductList.Location = new System.Drawing.Point(26, 337);
            this.gripViewProductList.Name = "gripViewProductList";
            this.gripViewProductList.Size = new System.Drawing.Size(718, 96);
            this.gripViewProductList.TabIndex = 13;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gripViewProductList);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.richTxtDescription);
            this.Controls.Add(this.dtPickerExpDate);
            this.Controls.Add(this.dtPicketMfgDate);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.label1);
            this.Name = "frmAddProduct";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gripViewProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DateTimePicker dtPicketMfgDate;
        private System.Windows.Forms.DateTimePicker dtPickerExpDate;
        private System.Windows.Forms.RichTextBox richTxtDescription;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView gripViewProductList;
    }
}

