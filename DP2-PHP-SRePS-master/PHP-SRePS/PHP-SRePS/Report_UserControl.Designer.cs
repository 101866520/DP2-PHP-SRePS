namespace PHP_SRePS
{
    partial class Report_UserControl
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
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridview = new System.Windows.Forms.DataGridView();
            this.download_reports_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(487, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Set a Date range and click Display data button to view Data";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Location = new System.Drawing.Point(7, 50);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(252, 22);
            this.dateTimePicker3.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "To";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(299, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(555, 48);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 20);
            this.button2.TabIndex = 21;
            this.button2.Text = "Display Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.dataGridview.Location = new System.Drawing.Point(19, 101);
            this.dataGridview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridview.MultiSelect = false;
            this.dataGridview.Name = "dataGridview";
            this.dataGridview.ReadOnly = true;
            this.dataGridview.Size = new System.Drawing.Size(620, 270);
            this.dataGridview.TabIndex = 26;
            this.dataGridview.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridview_CellContentDoubleClick);
            // 
            // download_reports_button
            // 
            this.download_reports_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download_reports_button.Location = new System.Drawing.Point(508, 378);
            this.download_reports_button.Name = "download_reports_button";
            this.download_reports_button.Size = new System.Drawing.Size(131, 24);
            this.download_reports_button.TabIndex = 27;
            this.download_reports_button.Text = "DownLoad";
            this.download_reports_button.UseVisualStyleBackColor = true;
            this.download_reports_button.Visible = false;
            this.download_reports_button.Click += new System.EventHandler(this.download_reports_button_Click);
            // 
            // Report_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.download_reports_button);
            this.Controls.Add(this.dataGridview);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Name = "Report_UserControl";
            this.Size = new System.Drawing.Size(936, 505);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridview;
        private System.Windows.Forms.Button download_reports_button;
    }
}
