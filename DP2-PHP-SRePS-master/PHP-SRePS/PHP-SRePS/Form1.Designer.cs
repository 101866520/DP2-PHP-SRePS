using System;

namespace PHP_SRePS
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.ProductNOTxt = new System.Windows.Forms.TextBox();
            this.ProductDateTxt = new System.Windows.Forms.TextBox();
            this.ProductPriceTxt = new System.Windows.Forms.TextBox();
            this.ProductQuantityTxt = new System.Windows.Forms.TextBox();

            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Purchase Date";

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Price";

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Product Quantity";

            // 
            // ProductNOTxt
            // 
            this.ProductNOTxt.Location = new System.Drawing.Point(127, 41);
            this.ProductNOTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductNOTxt.Name = "ProductNOTxt";
            this.ProductNOTxt.Size = new System.Drawing.Size(211, 20);
            this.ProductNOTxt.TabIndex = 7;

            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.Location = new System.Drawing.Point(127, 65);
            this.ProductNameTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(211, 20);
            this.ProductNameTxt.TabIndex = 8;
         

            // 
            // Product_DateTxt
            // 
            this.ProductDateTxt.Location = new System.Drawing.Point(127, 89);
            this.ProductDateTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductDateTxt.Name = "ProductDateTxt";
            this.ProductDateTxt.Size = new System.Drawing.Size(211, 20);
            this.ProductDateTxt.TabIndex = 9;

            // 
            // Product_PriceTxt
            // 
            this.ProductPriceTxt.Location = new System.Drawing.Point(127, 119);
            this.ProductPriceTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductPriceTxt.Name = "ProductPriceTxt";
            this.ProductPriceTxt.Size = new System.Drawing.Size(211, 20);
            this.ProductPriceTxt.TabIndex = 10;

            // 
            // Product_QuantityTxt
            // 
            this.ProductQuantityTxt.Location = new System.Drawing.Point(127, 143);
            this.ProductQuantityTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductQuantityTxt.Name = "ProductQuantityTxt";
            this.ProductQuantityTxt.Size = new System.Drawing.Size(211, 20);
            this.ProductQuantityTxt.TabIndex = 11;

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 223);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 13;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.submit_Click);

            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 223);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 13;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.view_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);

            this.Controls.Add(this.ProductNOTxt);
            this.Controls.Add(this.ProductNameTxt);
            this.Controls.Add(this.ProductDateTxt);
            this.Controls.Add(this.ProductPriceTxt);
            this.Controls.Add(this.ProductQuantityTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox ProductNOTxt;
        public System.Windows.Forms.TextBox ProductNameTxt;
        public System.Windows.Forms.TextBox ProductDateTxt;
        public System.Windows.Forms.TextBox ProductPriceTxt;
        public System.Windows.Forms.TextBox ProductQuantityTxt;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
    }
}