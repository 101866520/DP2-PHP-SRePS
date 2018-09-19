namespace PHP_SRePS
{
    partial class formAdd
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
            this.prodNoText = new System.Windows.Forms.TextBox();
            this.prodNoLabel = new System.Windows.Forms.Label();
            this.prodNameLabel = new System.Windows.Forms.Label();
            this.prodNameText = new System.Windows.Forms.TextBox();
            this.buyDateLabel = new System.Windows.Forms.Label();
            this.prodPriceLabel = new System.Windows.Forms.Label();
            this.prodQuanLabel = new System.Windows.Forms.Label();
            this.prodPriceText = new System.Windows.Forms.TextBox();
            this.prodQtyText = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addForm = new System.Windows.Forms.Button();
            this.clearForm = new System.Windows.Forms.Button();
            this.cancelAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prodNoText
            // 
            this.prodNoText.Location = new System.Drawing.Point(179, 30);
            this.prodNoText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prodNoText.Name = "prodNoText";
            this.prodNoText.Size = new System.Drawing.Size(265, 22);
            this.prodNoText.TabIndex = 0;
            // 
            // prodNoLabel
            // 
            this.prodNoLabel.AutoSize = true;
            this.prodNoLabel.Location = new System.Drawing.Point(81, 33);
            this.prodNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prodNoLabel.Name = "prodNoLabel";
            this.prodNoLabel.Size = new System.Drawing.Size(87, 17);
            this.prodNoLabel.TabIndex = 1;
            this.prodNoLabel.Text = "Product No.:";
            // 
            // prodNameLabel
            // 
            this.prodNameLabel.AutoSize = true;
            this.prodNameLabel.Location = new System.Drawing.Point(67, 70);
            this.prodNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prodNameLabel.Name = "prodNameLabel";
            this.prodNameLabel.Size = new System.Drawing.Size(102, 17);
            this.prodNameLabel.TabIndex = 2;
            this.prodNameLabel.Text = "Product Name:";
            // 
            // prodNameText
            // 
            this.prodNameText.Location = new System.Drawing.Point(179, 66);
            this.prodNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prodNameText.Name = "prodNameText";
            this.prodNameText.Size = new System.Drawing.Size(265, 22);
            this.prodNameText.TabIndex = 3;
            // 
            // buyDateLabel
            // 
            this.buyDateLabel.AutoSize = true;
            this.buyDateLabel.Location = new System.Drawing.Point(63, 107);
            this.buyDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buyDateLabel.Name = "buyDateLabel";
            this.buyDateLabel.Size = new System.Drawing.Size(106, 17);
            this.buyDateLabel.TabIndex = 4;
            this.buyDateLabel.Text = "Purchase Date:";
            // 
            // prodPriceLabel
            // 
            this.prodPriceLabel.AutoSize = true;
            this.prodPriceLabel.Location = new System.Drawing.Point(72, 144);
            this.prodPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prodPriceLabel.Name = "prodPriceLabel";
            this.prodPriceLabel.Size = new System.Drawing.Size(97, 17);
            this.prodPriceLabel.TabIndex = 5;
            this.prodPriceLabel.Text = "Product Price:";
            // 
            // prodQuanLabel
            // 
            this.prodQuanLabel.AutoSize = true;
            this.prodQuanLabel.Location = new System.Drawing.Point(52, 181);
            this.prodQuanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prodQuanLabel.Name = "prodQuanLabel";
            this.prodQuanLabel.Size = new System.Drawing.Size(118, 17);
            this.prodQuanLabel.TabIndex = 6;
            this.prodQuanLabel.Text = "Product Quantity:";
            // 
            // prodPriceText
            // 
            this.prodPriceText.Location = new System.Drawing.Point(179, 140);
            this.prodPriceText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prodPriceText.Name = "prodPriceText";
            this.prodPriceText.Size = new System.Drawing.Size(265, 22);
            this.prodPriceText.TabIndex = 7;
            // 
            // prodQtyText
            // 
            this.prodQtyText.Location = new System.Drawing.Point(179, 177);
            this.prodQtyText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prodQtyText.Name = "prodQtyText";
            this.prodQtyText.Size = new System.Drawing.Size(265, 22);
            this.prodQtyText.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 103);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2018, 9, 19, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // addForm
            // 
            this.addForm.Location = new System.Drawing.Point(79, 247);
            this.addForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addForm.Name = "addForm";
            this.addForm.Size = new System.Drawing.Size(100, 28);
            this.addForm.TabIndex = 10;
            this.addForm.Text = "Add";
            this.addForm.UseVisualStyleBackColor = true;
            this.addForm.Click += new System.EventHandler(this.submit_Click);
            // 
            // clearForm
            // 
            this.clearForm.Location = new System.Drawing.Point(212, 247);
            this.clearForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearForm.Name = "clearForm";
            this.clearForm.Size = new System.Drawing.Size(100, 28);
            this.clearForm.TabIndex = 11;
            this.clearForm.Text = "Clear";
            this.clearForm.UseVisualStyleBackColor = true;
            this.clearForm.Click += new System.EventHandler(this.clear_Click);
            // 
            // cancelAdd
            // 
            this.cancelAdd.Location = new System.Drawing.Point(345, 247);
            this.cancelAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelAdd.Name = "cancelAdd";
            this.cancelAdd.Size = new System.Drawing.Size(100, 28);
            this.cancelAdd.TabIndex = 12;
            this.cancelAdd.Text = "Cancel";
            this.cancelAdd.UseVisualStyleBackColor = true;
            this.cancelAdd.Click += new System.EventHandler(this.cancel_Click);
            // 
            // formAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 321);
            this.Controls.Add(this.cancelAdd);
            this.Controls.Add(this.clearForm);
            this.Controls.Add(this.addForm);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.prodQtyText);
            this.Controls.Add(this.prodPriceText);
            this.Controls.Add(this.prodQuanLabel);
            this.Controls.Add(this.prodPriceLabel);
            this.Controls.Add(this.buyDateLabel);
            this.Controls.Add(this.prodNameText);
            this.Controls.Add(this.prodNameLabel);
            this.Controls.Add(this.prodNoLabel);
            this.Controls.Add(this.prodNoText);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formAdd";
            this.Text = "Add a new Product";
            this.Load += new System.EventHandler(this.formAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prodNoText;
        private System.Windows.Forms.Label prodNoLabel;
        private System.Windows.Forms.Label prodNameLabel;
        private System.Windows.Forms.TextBox prodNameText;
        private System.Windows.Forms.Label buyDateLabel;
        private System.Windows.Forms.Label prodPriceLabel;
        private System.Windows.Forms.Label prodQuanLabel;
        private System.Windows.Forms.TextBox prodPriceText;
        private System.Windows.Forms.TextBox prodQtyText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button addForm;
        private System.Windows.Forms.Button clearForm;
        private System.Windows.Forms.Button cancelAdd;
    }
}