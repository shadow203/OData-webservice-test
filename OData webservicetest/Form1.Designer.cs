namespace OData_webservicetest
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Read_Data = new System.Windows.Forms.Button();
            this.Insert_Data = new System.Windows.Forms.Button();
            this.Edite_Data = new System.Windows.Forms.Button();
            this.Delete_Data = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // Read_Data
            // 
            this.Read_Data.Location = new System.Drawing.Point(535, 246);
            this.Read_Data.Name = "Read_Data";
            this.Read_Data.Size = new System.Drawing.Size(96, 31);
            this.Read_Data.TabIndex = 1;
            this.Read_Data.Text = "Load data";
            this.Read_Data.UseVisualStyleBackColor = true;
            this.Read_Data.Click += new System.EventHandler(this.button1_Click);
            // 
            // Insert_Data
            // 
            this.Insert_Data.Location = new System.Drawing.Point(12, 253);
            this.Insert_Data.Name = "Insert_Data";
            this.Insert_Data.Size = new System.Drawing.Size(101, 24);
            this.Insert_Data.TabIndex = 2;
            this.Insert_Data.Text = "added";
            this.Insert_Data.UseVisualStyleBackColor = true;
            this.Insert_Data.Click += new System.EventHandler(this.button2_Click);
            // 
            // Edite_Data
            // 
            this.Edite_Data.Location = new System.Drawing.Point(155, 254);
            this.Edite_Data.Name = "Edite_Data";
            this.Edite_Data.Size = new System.Drawing.Size(116, 23);
            this.Edite_Data.TabIndex = 3;
            this.Edite_Data.Text = "Modify";
            this.Edite_Data.UseVisualStyleBackColor = true;
            this.Edite_Data.Click += new System.EventHandler(this.button3_Click);
            // 
            // Delete_Data
            // 
            this.Delete_Data.Location = new System.Drawing.Point(314, 253);
            this.Delete_Data.Name = "Delete_Data";
            this.Delete_Data.Size = new System.Drawing.Size(75, 23);
            this.Delete_Data.TabIndex = 4;
            this.Delete_Data.Text = "Delete";
            this.Delete_Data.UseVisualStyleBackColor = true;
            this.Delete_Data.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 308);
            this.Controls.Add(this.Delete_Data);
            this.Controls.Add(this.Edite_Data);
            this.Controls.Add(this.Insert_Data);
            this.Controls.Add(this.Read_Data);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Read_Data;
        private System.Windows.Forms.Button Insert_Data;
        private System.Windows.Forms.Button Edite_Data;
        private System.Windows.Forms.Button Delete_Data;
    }
}

