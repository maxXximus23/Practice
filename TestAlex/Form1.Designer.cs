namespace TestAlex
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CategoriesDGV = new System.Windows.Forms.DataGridView();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriesDGV
            // 
            this.CategoriesDGV.AllowUserToAddRows = false;
            this.CategoriesDGV.AllowUserToDeleteRows = false;
            this.CategoriesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesDGV.Location = new System.Drawing.Point(2, -1);
            this.CategoriesDGV.Name = "CategoriesDGV";
            this.CategoriesDGV.ReadOnly = true;
            this.CategoriesDGV.Size = new System.Drawing.Size(786, 249);
            this.CategoriesDGV.TabIndex = 0;
            this.CategoriesDGV.Text = "dataGridView1";
            this.CategoriesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriesDGV_CellContentClick);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(25, 282);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(75, 23);
            this.ShowAllButton.TabIndex = 1;
            this.ShowAllButton.Text = "Show all";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Location = new System.Drawing.Point(185, 282);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.AddCategoryButton.TabIndex = 1;
            this.AddCategoryButton.Text = "Add";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(450, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category name";
            // 
            // CategoryIdLabel
            // 
            this.CategoryIdLabel.AutoSize = true;
            this.CategoryIdLabel.Location = new System.Drawing.Point(401, 342);
            this.CategoryIdLabel.Name = "CategoryIdLabel";
            this.CategoryIdLabel.Size = new System.Drawing.Size(32, 15);
            this.CategoryIdLabel.TabIndex = 4;
            this.CategoryIdLabel.Text = "Id : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CategoryIdLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.CategoriesDGV);
            this.Name = "Form1";
            this.Text = "+";
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CategoriesDGV;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CategoryIdLabel;
    }
}

