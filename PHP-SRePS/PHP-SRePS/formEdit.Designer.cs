namespace PHP_SRePS
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.editForm = new System.Windows.Forms.Button();
            this.cancelAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prodNoText
            // 
            this.prodNoText.Location = new System.Drawing.Point(134, 24);
            this.prodNoText.Name = "prodNoText";
            this.prodNoText.Size = new System.Drawing.Size(200, 20);
            this.prodNoText.TabIndex = 0;
            // 
            // prodNoLabel
            // 
            this.prodNoLabel.AutoSize = true;
            this.prodNoLabel.Location = new System.Drawing.Point(61, 27);
            this.prodNoLabel.Name = "prodNoLabel";
            this.prodNoLabel.Size = new System.Drawing.Size(67, 13);
            this.prodNoLabel.TabIndex = 1;
            this.prodNoLabel.Text = "Product No.:";
            // 
            // prodNameLabel
            // 
            this.prodNameLabel.AutoSize = true;
            this.prodNameLabel.Location = new System.Drawing.Point(50, 57);
            this.prodNameLabel.Name = "prodNameLabel";
            this.prodNameLabel.Size = new System.Drawing.Size(78, 13);
            this.prodNameLabel.TabIndex = 2;
            this.prodNameLabel.Text = "Product Name:";
            // 
            // prodNameText
            // 
            this.prodNameText.Location = new System.Drawing.Point(134, 54);
            this.prodNameText.Name = "prodNameText";
            this.prodNameText.Size = new System.Drawing.Size(200, 20);
            this.prodNameText.TabIndex = 3;
            // 
            // buyDateLabel
            // 
            this.buyDateLabel.AutoSize = true;
            this.buyDateLabel.Location = new System.Drawing.Point(47, 87);
            this.buyDateLabel.Name = "buyDateLabel";
            this.buyDateLabel.Size = new System.Drawing.Size(81, 13);
            this.buyDateLabel.TabIndex = 4;
            this.buyDateLabel.Text = "Purchase Date:";
            // 
            // prodPriceLabel
            // 
            this.prodPriceLabel.AutoSize = true;
            this.prodPriceLabel.Location = new System.Drawing.Point(54, 117);
            this.prodPriceLabel.Name = "prodPriceLabel";
            this.prodPriceLabel.Size = new System.Drawing.Size(74, 13);
            this.prodPriceLabel.TabIndex = 5;
            this.prodPriceLabel.Text = "Product Price:";
            // 
            // prodQuanLabel
            // 
            this.prodQuanLabel.AutoSize = true;
            this.prodQuanLabel.Location = new System.Drawing.Point(39, 147);
            this.prodQuanLabel.Name = "prodQuanLabel";
            this.prodQuanLabel.Size = new System.Drawing.Size(89, 13);
            this.prodQuanLabel.TabIndex = 6;
            this.prodQuanLabel.Text = "Product Quantity:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // editForm
            // 
            this.editForm.Location = new System.Drawing.Point(59, 201);
            this.editForm.Name = "editForm";
            this.editForm.Size = new System.Drawing.Size(75, 23);
            this.editForm.TabIndex = 10;
            this.editForm.Text = "Confirm";
            this.editForm.UseVisualStyleBackColor = true;
            // 
            // cancelAdd
            // 
            this.cancelAdd.Location = new System.Drawing.Point(259, 201);
            this.cancelAdd.Name = "cancelAdd";
            this.cancelAdd.Size = new System.Drawing.Size(75, 23);
            this.cancelAdd.TabIndex = 12;
            this.cancelAdd.Text = "Cancel";
            this.cancelAdd.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.cancelAdd);
            this.Controls.Add(this.editForm);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.prodQuanLabel);
            this.Controls.Add(this.prodPriceLabel);
            this.Controls.Add(this.buyDateLabel);
            this.Controls.Add(this.prodNameText);
            this.Controls.Add(this.prodNameLabel);
            this.Controls.Add(this.prodNoLabel);
            this.Controls.Add(this.prodNoText);
            this.Name = "Form2";
            this.Text = "Edit a new Product";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button editForm;
        private System.Windows.Forms.Button cancelAdd;
    }
}