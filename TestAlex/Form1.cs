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
using TestAlex.AutoMapper;
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
            var ViewModels = MapperFactory.GetMapper().Map<List<CategoryViewModel>>(await _categoryService.GetAll());

            foreach (var category in ViewModels)
            {
                category.Count = await GetCountGames(category.Id);
            }
            CategoriesDGV.DataSource = ViewModels;
        }

        private async Task<int> GetCountGames(int categoryId)
        {
            int count = 0;
            foreach (var game in await _gameService.GetAll())
            {
                if (game.CategoryId == categoryId)
                    count++;
            }
            return count;
        }

        private async void RefreshGames()
        {
            GameCategoryComboBox.DataSource = await _categoryService.GetAll();
            GameCategoryComboBox.DisplayMember = "Name";

            var ViewModels = MapperFactory.GetMapper().Map<List<GameViewModel>>(await _gameService.GetAll());

            GamesDGV.DataSource = ViewModels;
        }

        private async void EditCategoryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Category name must be fill!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            if(category.Count > 0)
            {
                MessageBox.Show("Category have link to game!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                SetCategoryNameInComboBox(game.CategoryName);
                GameTextBox.Text = game.Name;
                DescriptionRichTextBox.Text = game.Description;
            }
        }

        private void SetCategoryNameInComboBox(string categoryName)
        {
                GameCategoryComboBox.SelectedIndex = GameCategoryComboBox.FindStringExact(categoryName);
        }

        private async void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GameTextBox.Text))
            {
                MessageBox.Show("Game name must be fill!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var addGame = new Game()
            {
                CategoryId = (GameCategoryComboBox.SelectedItem as Category).Id,
                Name = GameTextBox.Text,
                Description = DescriptionRichTextBox.Text,
            };

            using (var ms = new MemoryStream())
            {
                GamePictureBox.Image.Save(ms, GamePictureBox.Image.RawFormat);
                addGame.Logo = ms.GetBuffer();
            }
            await _gameService.Create(addGame);
            RefreshGames();
        }

        private async void DeleteGameButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Do you really want to delete {game.Name}?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (game != null && result == DialogResult.Yes)
            {
                await _gameService.Delete(game.Id);
                RefreshGames();
            }
        }

        private async void EditGameButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Do you really want to edit {game.Name}?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (game != null && result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(GameTextBox.Text))
                {
                    MessageBox.Show("Game name must be fill!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                game.Name = GameTextBox.Text;
                Game editGame = new Game()
                {
                    Name = GameTextBox.Text,
                    Id = game.Id,
                    CategoryId = game.CategoryId,
                    Description = DescriptionRichTextBox.Text,
                    Category = GameCategoryComboBox.SelectedItem as Category

                };

                using (var ms = new MemoryStream())
                {
                    GamePictureBox.Image.Save(ms, GamePictureBox.Image.RawFormat);
                    editGame.Logo = ms.GetBuffer();
                }

                await _gameService.Update(editGame);
                RefreshGames();
            }
        }

        private void DescriptionRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
