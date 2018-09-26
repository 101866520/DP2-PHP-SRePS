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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.prediction_button = new System.Windows.Forms.Button();
            this.scrolPanel = new System.Windows.Forms.Panel();
            this.previously_sold_record_button = new System.Windows.Forms.Button();
            this.reports_button = new System.Windows.Forms.Button();
            this.stock_button = new System.Windows.Forms.Button();
            this.current_sales_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.user_control_container_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.prediction_button);
            this.panel1.Controls.Add(this.scrolPanel);
            this.panel1.Controls.Add(this.previously_sold_record_button);
            this.panel1.Controls.Add(this.reports_button);
            this.panel1.Controls.Add(this.stock_button);
            this.panel1.Controls.Add(this.current_sales_button);
            this.panel1.Controls.Add(this.home_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 772);
            this.panel1.TabIndex = 22;
            // 
            // prediction_button
            // 
            this.prediction_button.FlatAppearance.BorderSize = 0;
            this.prediction_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prediction_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.prediction_button.ForeColor = System.Drawing.Color.Transparent;
            this.prediction_button.Location = new System.Drawing.Point(39, 620);
            this.prediction_button.Name = "prediction_button";
            this.prediction_button.Size = new System.Drawing.Size(163, 48);
            this.prediction_button.TabIndex = 25;
            this.prediction_button.Text = "Prediction";
            this.prediction_button.UseVisualStyleBackColor = true;
            this.prediction_button.Click += new System.EventHandler(this.prediction_button_Click);
            // 
            // scrolPanel
            // 
            this.scrolPanel.BackColor = System.Drawing.Color.Red;
            this.scrolPanel.Location = new System.Drawing.Point(0, 110);
            this.scrolPanel.Name = "scrolPanel";
            this.scrolPanel.Size = new System.Drawing.Size(10, 48);
            this.scrolPanel.TabIndex = 25;
            // 
            // previously_sold_record_button
            // 
            this.previously_sold_record_button.FlatAppearance.BorderSize = 0;
            this.previously_sold_record_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previously_sold_record_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.previously_sold_record_button.ForeColor = System.Drawing.Color.Transparent;
            this.previously_sold_record_button.Location = new System.Drawing.Point(39, 527);
            this.previously_sold_record_button.Name = "previously_sold_record_button";
            this.previously_sold_record_button.Size = new System.Drawing.Size(163, 48);
            this.previously_sold_record_button.TabIndex = 4;
            this.previously_sold_record_button.Text = "Records";
            this.previously_sold_record_button.UseVisualStyleBackColor = true;
            this.previously_sold_record_button.Click += new System.EventHandler(this.previously_sold_record_button_Click);
            // 
            // reports_button
            // 
            this.reports_button.FlatAppearance.BorderSize = 0;
            this.reports_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reports_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.reports_button.ForeColor = System.Drawing.Color.Transparent;
            this.reports_button.Location = new System.Drawing.Point(39, 417);
            this.reports_button.Name = "reports_button";
            this.reports_button.Size = new System.Drawing.Size(163, 48);
            this.reports_button.TabIndex = 3;
            this.reports_button.Text = "Reports";
            this.reports_button.UseVisualStyleBackColor = true;
            this.reports_button.Click += new System.EventHandler(this.reports_button_Click);
            // 
            // stock_button
            // 
            this.stock_button.FlatAppearance.BorderSize = 0;
            this.stock_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.stock_button.ForeColor = System.Drawing.Color.Transparent;
            this.stock_button.Location = new System.Drawing.Point(39, 313);
            this.stock_button.Name = "stock_button";
            this.stock_button.Size = new System.Drawing.Size(163, 48);
            this.stock_button.TabIndex = 2;
            this.stock_button.Text = "Stock";
            this.stock_button.UseVisualStyleBackColor = true;
            this.stock_button.Click += new System.EventHandler(this.stock_button_Click);
            // 
            // current_sales_button
            // 
            this.current_sales_button.FlatAppearance.BorderSize = 0;
            this.current_sales_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.current_sales_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.current_sales_button.ForeColor = System.Drawing.Color.Transparent;
            this.current_sales_button.Location = new System.Drawing.Point(39, 204);
            this.current_sales_button.Name = "current_sales_button";
            this.current_sales_button.Size = new System.Drawing.Size(163, 48);
            this.current_sales_button.TabIndex = 1;
            this.current_sales_button.Text = "Sale";
            this.current_sales_button.UseVisualStyleBackColor = true;
            this.current_sales_button.Click += new System.EventHandler(this.current_sales_button_Click);
            // 
            // home_button
            // 
            this.home_button.FlatAppearance.BorderSize = 0;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.home_button.ForeColor = System.Drawing.Color.Transparent;
            this.home_button.Location = new System.Drawing.Point(37, 110);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(163, 48);
            this.home_button.TabIndex = 0;
            this.home_button.Text = "Home";
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.DarkRed;
            this.panel2.Location = new System.Drawing.Point(202, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 17);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(5)))), ((int)(((byte)(40)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(202, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 120);
            this.panel3.TabIndex = 24;
            // 
            // user_control_container_panel
            // 
            this.user_control_container_panel.Location = new System.Drawing.Point(202, 122);
            this.user_control_container_panel.Name = "user_control_container_panel";
            this.user_control_container_panel.Size = new System.Drawing.Size(936, 650);
            this.user_control_container_panel.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 104);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 772);
            this.Controls.Add(this.user_control_container_panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stock_button;
        private System.Windows.Forms.Button current_sales_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button previously_sold_record_button;
        private System.Windows.Forms.Button reports_button;
        private System.Windows.Forms.Panel scrolPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button prediction_button;
        private System.Windows.Forms.Panel user_control_container_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}