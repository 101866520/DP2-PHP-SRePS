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
            this.ProductPriceTxt = new System.Windows.Forms.TextBox();
            this.ProductQuantityTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridview = new System.Windows.Forms.DataGridView();
            this.Reset = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 329);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Purchase Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Product Quantity";
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.Location = new System.Drawing.Point(134, 321);
            this.ProductNameTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(279, 27);
            this.ProductNameTxt.TabIndex = 8;
            // 
            // ProductNOTxt
            // 
            this.ProductNOTxt.Location = new System.Drawing.Point(134, 23);
            this.ProductNOTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ProductNOTxt.Name = "ProductNOTxt";
            this.ProductNOTxt.Size = new System.Drawing.Size(279, 27);
            this.ProductNOTxt.TabIndex = 7;
            // 
            // ProductPriceTxt
            // 
            this.ProductPriceTxt.Location = new System.Drawing.Point(134, 242);
            this.ProductPriceTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ProductPriceTxt.Name = "ProductPriceTxt";
            this.ProductPriceTxt.Size = new System.Drawing.Size(279, 27);
            this.ProductPriceTxt.TabIndex = 10;
            // 
            // ProductQuantityTxt
            // 
            this.ProductQuantityTxt.Location = new System.Drawing.Point(134, 168);
            this.ProductQuantityTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ProductQuantityTxt.Name = "ProductQuantityTxt";
            this.ProductQuantityTxt.Size = new System.Drawing.Size(279, 27);
            this.ProductQuantityTxt.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 453);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.submit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(957, 665);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Display Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.view_Click);
            // 
            // dataGridview
            // 
            this.dataGridview.AllowUserToAddRows = false;
            this.dataGridview.AllowUserToDeleteRows = false;
            this.dataGridview.AllowUserToResizeColumns = false;
            this.dataGridview.AllowUserToResizeRows = false;
            this.dataGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridview.BackgroundColor = System.Drawing.Color.White;
            this.dataGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridview.Location = new System.Drawing.Point(434, 13);
            this.dataGridview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridview.MultiSelect = false;
            this.dataGridview.Name = "dataGridview";
            this.dataGridview.ReadOnly = true;
            this.dataGridview.Size = new System.Drawing.Size(688, 492);
            this.dataGridview.TabIndex = 14;
            this.dataGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridview_CellContentClick);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(203, 453);
            this.Reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(182, 42);
            this.Reset.TabIndex = 15;
            this.Reset.Text = "Reset Form";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(726, 668);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(134, 104);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(279, 27);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 674);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "To";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(434, 668);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(279, 27);
            this.dateTimePicker3.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 646);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(416, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Set a Date range and click Display data button to view Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(328, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Select one from any  of the above rows to edit";
            this.label8.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 772);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.dataGridview);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ProductNOTxt);
            this.Controls.Add(this.ProductNameTxt);
            this.Controls.Add(this.ProductPriceTxt);
            this.Controls.Add(this.ProductQuantityTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).EndInit();
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
        public System.Windows.Forms.TextBox ProductPriceTxt;
        public System.Windows.Forms.TextBox ProductQuantityTxt;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridview;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}