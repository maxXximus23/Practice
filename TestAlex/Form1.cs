using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAlex.DataAccess.Entities;
using TestAlex.DataAccess.Services;

namespace TestAlex
{
    public partial class Form1 : Form
    {
        private readonly ICRUDService<Category> _categoryService;
        public Form1()
        {
            InitializeComponent();
            _categoryService = new CategoryService();
        }

        private void CategoriesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            RefreshCategories();
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            var newCategory = new Category { Name = textBox1.Text };
            _categoryService.Create(newCategory);
            RefreshCategories();
        }

        private async void RefreshCategories()
        {
            CategoriesDGV.DataSource = await _categoryService.GetAll();
        }
    }
}
