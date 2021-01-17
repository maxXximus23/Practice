using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAlex.DataAccess.Entities;
using TestAlex.DataAccess.Services;
using TestAlex.Viewmodels;

namespace TestAlex
{
    public partial class Form1 : Form
    {
        private readonly ICRUDService<Category> _categoryService;
        private readonly ICRUDService<Game> _gameService;
        private CategoryViewModel category
        {
            get
            {
                if (CategoriesDGV.SelectedRows.Count > 0)
                    return CategoriesDGV.SelectedRows[0].DataBoundItem as CategoryViewModel;
                else
                    return null;
            }
        }

        private GameViewModel game
        {
            get
            {
                if (GamesDGV.SelectedRows.Count > 0)
                    return GamesDGV.SelectedRows[0].DataBoundItem as GameViewModel;
                else
                    return null;
            }
        }
        public Form1()
        {
            InitializeComponent();
            _categoryService = new CategoryService();
            _gameService = new GameService();
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            RefreshCategories();
        }

        private async void AddCategoryButton_Click(object sender, EventArgs e)
        {
            var newCategory = new Category { Name = textBox1.Text };
            if (string.IsNullOrWhiteSpace(newCategory.Name))
            {
                MessageBox.Show("Category name is empty", "Validation failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                await _categoryService.Create(newCategory);
                RefreshCategories();
            }
        }

        private async void RefreshCategories()
        {
            var ViewModels = new List<CategoryViewModel>();
            foreach (var category in await _categoryService.GetAll())
            {
                ViewModels.Add(new CategoryViewModel
                {
                    Name = category.Name,
                    Count = category.Games == null ? 0 : category.Games.Count,
                    Id = category.Id
                });
            }
            CategoriesDGV.DataSource = ViewModels;
        }

        private async void RefreshGames()
        {
            GameCategoryComboBox.DataSource = await _categoryService.GetAll();
            GameCategoryComboBox.DisplayMember = "Name";

            var ViewModels = new List<GameViewModel>();
            foreach (var game in await _gameService.GetAll())
            {
                var gameViewModel = new GameViewModel
                {
                    Name = game.Name,
                    CategoryId = (GameCategoryComboBox.SelectedItem as Category).Id,
                    Id = game.Id,
                    Description = game.Description,
                };
                using (var ms = new MemoryStream(game.Logo))
                {
                    gameViewModel.Logo = Image.FromStream(ms);
                }
                ViewModels.Add(gameViewModel);
            }
            GamesDGV.DataSource = ViewModels;
        }

        private async void EditCategoryButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Do you really want to edit {category.Name}?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (category != null && result == DialogResult.Yes)
            {
                category.Name = textBox1.Text;
                Category editCategory = new Category() { Name = category.Name, Id = category.Id };
                await _categoryService.Update(editCategory);
                RefreshCategories();
            }
        }

        private void CategoriesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(CategoriesDGV.SelectedCells[0].Value.ToString());
        }

        private void CategoriesDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (category != null)
            {
                textBox1.Text = category.Name;
                CategoryIdLabel.Text = "Id : " + category.Id.ToString();
            }
        }

        private async void DeleteCategoryButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Do you really want to delete {category.Name}?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (category != null && result == DialogResult.Yes)
            {
                await _categoryService.Delete(category.Id);
                RefreshCategories();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GamesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowAllGamesButton_Click(object sender, EventArgs e)
        {
            RefreshGames();
        }

        private void GameCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDlg = new OpenFileDialog();
            ofDlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (ofDlg.ShowDialog() == DialogResult.OK)
            {
                GamePictureBox.Image = Image.FromFile(ofDlg.FileName);
            }
        }

        private void GamesDGV_SelectionChanged(object sender, EventArgs e)
        {
            if(game != null)
            {
                GamePictureBox.Image = game.Logo;
            }
        }

        private async void Add_Click(object sender, EventArgs e)
        {
            var addGame = new Game()
            {
                CategoryId = (GameCategoryComboBox.SelectedItem as Category).Id,
                Name = GameTextBox.Text,
            };

            using (var ms = new MemoryStream())
            {
                GamePictureBox.Image.Save(ms, GamePictureBox.Image.RawFormat);
                addGame.Logo = ms.GetBuffer();
            }
            await _gameService.Create(addGame);
            RefreshGames();
        }
    }
}
