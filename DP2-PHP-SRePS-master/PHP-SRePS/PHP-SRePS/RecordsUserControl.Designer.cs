namespace PHP_SRePS
{
    partial class RecordsUserControl
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Reset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductNOTxt = new System.Windows.Forms.TextBox();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.ProductPriceTxt = new System.Windows.Forms.TextBox();
            this.ProductQuantityTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProviderRecord = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(243, 86);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(419, 30);
            this.dateTimePicker2.TabIndex = 41;
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(456, 337);
            this.Reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(177, 33);
            this.Reset.TabIndex = 40;
            this.Reset.Text = "Reset Form";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(243, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 33);
            this.button1.TabIndex = 39;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductNOTxt
            // 
            this.ProductNOTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNOTxt.Location = new System.Drawing.Point(243, 21);
            this.ProductNOTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductNOTxt.Name = "ProductNOTxt";
            this.ProductNOTxt.Size = new System.Drawing.Size(419, 30);
            this.ProductNOTxt.TabIndex = 35;
            this.ProductNOTxt.Validating += new System.ComponentModel.CancelEventHandler(this.ProductNoTxt_Validating);
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameTxt.Location = new System.Drawing.Point(243, 255);
            this.ProductNameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(419, 30);
            this.ProductNameTxt.TabIndex = 36;
            this.ProductNameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.productNameTxt_Validating);
            // 
            // ProductPriceTxt
            // 
            this.ProductPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPriceTxt.Location = new System.Drawing.Point(243, 190);
            this.ProductPriceTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductPriceTxt.Name = "ProductPriceTxt";
            this.ProductPriceTxt.Size = new System.Drawing.Size(419, 30);
            this.ProductPriceTxt.TabIndex = 37;
            this.ProductPriceTxt.Validating += new System.ComponentModel.CancelEventHandler(this.productPriceTxt_Validating);
            // 
            // ProductQuantityTxt
            // 
            this.ProductQuantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQuantityTxt.Location = new System.Drawing.Point(243, 139);
            this.ProductQuantityTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductQuantityTxt.Name = "ProductQuantityTxt";
            this.ProductQuantityTxt.Size = new System.Drawing.Size(419, 30);
            this.ProductQuantityTxt.TabIndex = 38;
            this.ProductQuantityTxt.Validating += new System.ComponentModel.CancelEventHandler(this.productQuantityTxt_Vaidating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Product NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Purchase Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Product Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Product Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 411);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(694, 25);
            this.label6.TabIndex = 42;
            this.label6.Text = "This section should only be used to add previous records to the system";
            // 
            // errorProviderRecord
            // 
            this.errorProviderRecord.BlinkRate = 0;
            this.errorProviderRecord.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderRecord.ContainerControl = this;
            // 
            // RecordsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductNOTxt);
            this.Controls.Add(this.ProductNameTxt);
            this.Controls.Add(this.ProductPriceTxt);
            this.Controls.Add(this.ProductQuantityTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RecordsUserControl";
            this.Size = new System.Drawing.Size(1248, 622);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button Reset;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox ProductNOTxt;
        public System.Windows.Forms.TextBox ProductNameTxt;
        public System.Windows.Forms.TextBox ProductPriceTxt;
        public System.Windows.Forms.TextBox ProductQuantityTxt;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProviderRecord;
    }
}
