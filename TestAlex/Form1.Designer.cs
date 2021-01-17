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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CategoryIdLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CategoriesDGV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UploadButton = new System.Windows.Forms.Button();
            this.GamePictureBox = new System.Windows.Forms.PictureBox();
            this.GameCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.GameTextBox = new System.Windows.Forms.TextBox();
            this.GameLabel = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.ShowAllGamesButton = new System.Windows.Forms.Button();
            this.GamesDGV = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.CategoryIdLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.CategoriesDGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Show all";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DeleteCategoryButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EditCategoryButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // CategoryIdLabel
            // 
            this.CategoryIdLabel.AutoSize = true;
            this.CategoryIdLabel.Location = new System.Drawing.Point(402, 349);
            this.CategoryIdLabel.Name = "CategoryIdLabel";
            this.CategoryIdLabel.Size = new System.Drawing.Size(32, 15);
            this.CategoryIdLabel.TabIndex = 4;
            this.CategoryIdLabel.Text = "Id : 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(451, 290);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // CategoriesDGV
            // 
            this.CategoriesDGV.AllowUserToAddRows = false;
            this.CategoriesDGV.AllowUserToDeleteRows = false;
            this.CategoriesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesDGV.Location = new System.Drawing.Point(3, 6);
            this.CategoriesDGV.MultiSelect = false;
            this.CategoriesDGV.Name = "CategoriesDGV";
            this.CategoriesDGV.ReadOnly = true;
            this.CategoriesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoriesDGV.Size = new System.Drawing.Size(786, 249);
            this.CategoriesDGV.TabIndex = 0;
            this.CategoriesDGV.Text = "dataGridView1";
            this.CategoriesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriesDGV_CellContentClick);
            this.CategoriesDGV.SelectionChanged += new System.EventHandler(this.CategoriesDGV_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.UploadButton);
            this.tabPage2.Controls.Add(this.GamePictureBox);
            this.tabPage2.Controls.Add(this.GameCategoryComboBox);
            this.tabPage2.Controls.Add(this.GameTextBox);
            this.tabPage2.Controls.Add(this.GameLabel);
            this.tabPage2.Controls.Add(this.Add);
            this.tabPage2.Controls.Add(this.ShowAllGamesButton);
            this.tabPage2.Controls.Add(this.GamesDGV);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(684, 380);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(100, 23);
            this.UploadButton.TabIndex = 7;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // GamePictureBox
            // 
            this.GamePictureBox.Location = new System.Drawing.Point(684, 282);
            this.GamePictureBox.Name = "GamePictureBox";
            this.GamePictureBox.Size = new System.Drawing.Size(100, 92);
            this.GamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GamePictureBox.TabIndex = 6;
            this.GamePictureBox.TabStop = false;
            // 
            // GameCategoryComboBox
            // 
            this.GameCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameCategoryComboBox.FormattingEnabled = true;
            this.GameCategoryComboBox.Location = new System.Drawing.Point(506, 321);
            this.GameCategoryComboBox.Name = "GameCategoryComboBox";
            this.GameCategoryComboBox.Size = new System.Drawing.Size(121, 23);
            this.GameCategoryComboBox.TabIndex = 5;
            this.GameCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.GameCategoryComboBox_SelectedIndexChanged);
            // 
            // GameTextBox
            // 
            this.GameTextBox.Location = new System.Drawing.Point(506, 283);
            this.GameTextBox.Name = "GameTextBox";
            this.GameTextBox.Size = new System.Drawing.Size(100, 23);
            this.GameTextBox.TabIndex = 4;
            // 
            // GameLabel
            // 
            this.GameLabel.AutoSize = true;
            this.GameLabel.Location = new System.Drawing.Point(416, 286);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(71, 15);
            this.GameLabel.TabIndex = 3;
            this.GameLabel.Text = "Game name";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(313, 282);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ShowAllGamesButton
            // 
            this.ShowAllGamesButton.Location = new System.Drawing.Point(34, 282);
            this.ShowAllGamesButton.Name = "ShowAllGamesButton";
            this.ShowAllGamesButton.Size = new System.Drawing.Size(75, 23);
            this.ShowAllGamesButton.TabIndex = 1;
            this.ShowAllGamesButton.Text = "Show all";
            this.ShowAllGamesButton.UseVisualStyleBackColor = true;
            this.ShowAllGamesButton.Click += new System.EventHandler(this.ShowAllGamesButton_Click);
            // 
            // GamesDGV
            // 
            this.GamesDGV.AllowUserToAddRows = false;
            this.GamesDGV.AllowUserToDeleteRows = false;
            this.GamesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GamesDGV.Location = new System.Drawing.Point(3, 0);
            this.GamesDGV.MultiSelect = false;
            this.GamesDGV.Name = "GamesDGV";
            this.GamesDGV.ReadOnly = true;
            this.GamesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GamesDGV.Size = new System.Drawing.Size(786, 249);
            this.GamesDGV.TabIndex = 0;
            this.GamesDGV.Text = "dataGridView2";
            this.GamesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GamesDGV_CellContentClick);
            this.GamesDGV.SelectionChanged += new System.EventHandler(this.GamesDGV_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "+";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CategoryIdLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView CategoriesDGV;
        private System.Windows.Forms.Label GameLabel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button ShowAllGamesButton;
        private System.Windows.Forms.DataGridView GamesDGV;
        private System.Windows.Forms.TextBox GameTextBox;
        private System.Windows.Forms.ComboBox GameCategoryComboBox;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.PictureBox GamePictureBox;
    }
}

