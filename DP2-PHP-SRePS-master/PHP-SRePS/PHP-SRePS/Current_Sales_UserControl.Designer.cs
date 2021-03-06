﻿namespace PHP_SRePS
{
    partial class Current_Sales_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.currentsaleslistView = new System.Windows.Forms.ListView();
            this.products_in_stocks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rent_sale_user_control = new System.Windows.Forms.Button();
            this.ProductPriceTxt = new System.Windows.Forms.TextBox();
            this.ProductQuantityTxt = new System.Windows.Forms.TextBox();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select an item from list to purchase";
            // 
            // currentsaleslistView
            // 
            this.currentsaleslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.products_in_stocks});
            this.currentsaleslistView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentsaleslistView.Location = new System.Drawing.Point(446, 51);
            this.currentsaleslistView.Name = "currentsaleslistView";
            this.currentsaleslistView.Size = new System.Drawing.Size(244, 384);
            this.currentsaleslistView.TabIndex = 1;
            this.currentsaleslistView.UseCompatibleStateImageBehavior = false;
            this.currentsaleslistView.View = System.Windows.Forms.View.Details;
            this.currentsaleslistView.ItemActivate += new System.EventHandler(this.currentsaleslistView_ItemActivate);
            // 
            // products_in_stocks
            // 
            this.products_in_stocks.Text = "Choose Items To Purchase";
            this.products_in_stocks.Width = 328;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.rent_sale_user_control);
            this.panel1.Controls.Add(this.ProductPriceTxt);
            this.panel1.Controls.Add(this.ProductQuantityTxt);
            this.panel1.Controls.Add(this.ProductNameTxt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 350);
            this.panel1.TabIndex = 16;
            this.panel1.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(279, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // rent_sale_user_control
            // 
            this.rent_sale_user_control.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rent_sale_user_control.Location = new System.Drawing.Point(136, 281);
            this.rent_sale_user_control.Name = "rent_sale_user_control";
            this.rent_sale_user_control.Size = new System.Drawing.Size(173, 42);
            this.rent_sale_user_control.TabIndex = 25;
            this.rent_sale_user_control.Text = "Purchase";
            this.rent_sale_user_control.UseMnemonic = false;
            this.rent_sale_user_control.UseVisualStyleBackColor = true;
            this.rent_sale_user_control.Click += new System.EventHandler(this.rent_sale_user_control_Click);
            // 
            // ProductPriceTxt
            // 
            this.ProductPriceTxt.Location = new System.Drawing.Point(136, 208);
            this.ProductPriceTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ProductPriceTxt.Name = "ProductPriceTxt";
            this.ProductPriceTxt.ReadOnly = true;
            this.ProductPriceTxt.Size = new System.Drawing.Size(279, 20);
            this.ProductPriceTxt.TabIndex = 23;
            // 
            // ProductQuantityTxt
            // 
            this.ProductQuantityTxt.Location = new System.Drawing.Point(136, 151);
            this.ProductQuantityTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ProductQuantityTxt.Name = "ProductQuantityTxt";
            this.ProductQuantityTxt.Size = new System.Drawing.Size(279, 20);
            this.ProductQuantityTxt.TabIndex = 22;
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.Location = new System.Drawing.Point(137, 25);
            this.ProductNameTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.ReadOnly = true;
            this.ProductNameTxt.Size = new System.Drawing.Size(279, 20);
            this.ProductNameTxt.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Product Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Product Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Purchase Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "This section should only be used for Current sales";
            // 
            // Current_Sales_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.currentsaleslistView);
            this.Controls.Add(this.label1);
            this.Name = "Current_Sales_UserControl";
            this.Size = new System.Drawing.Size(936, 505);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView currentsaleslistView;
        private System.Windows.Forms.ColumnHeader products_in_stocks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button rent_sale_user_control;
        public System.Windows.Forms.TextBox ProductPriceTxt;
        public System.Windows.Forms.TextBox ProductQuantityTxt;
        public System.Windows.Forms.TextBox ProductNameTxt;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}
