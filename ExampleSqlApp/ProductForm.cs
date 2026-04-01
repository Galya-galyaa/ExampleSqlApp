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

namespace ExampleSqlApp
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();

            textBoxSearch.Text = "Поиск";
            textBoxSearch.ForeColor = Color.Gray;

            dataGridViewRecipes.AutoGenerateColumns = false;
            dataGridViewRecipes.RowTemplate.Height = 40;
            dataGridViewRecipes.AllowUserToAddRows = false;
            dataGridViewRecipes.AllowUserToDeleteRows = false;
            dataGridViewRecipes.ReadOnly = true;
            dataGridViewRecipes.RowHeadersVisible = false;
            dataGridViewRecipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRecipes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            CreateColumns();
            LoadRecipes();
        }
        private void CreateColumns()
        {
            dataGridViewRecipes.Columns.Clear();

            // колонка с номером
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "Id";
            idCol.HeaderText = "№";
            idCol.DataPropertyName = "Id";
            idCol.Width = 50;
            dataGridViewRecipes.Columns.Add(idCol);

            // название
            DataGridViewTextBoxColumn titleCol = new DataGridViewTextBoxColumn();
            titleCol.Name = "Title";
            titleCol.HeaderText = "Название";
            titleCol.DataPropertyName = "Title";
            titleCol.Width = 100;
            dataGridViewRecipes.Columns.Add(titleCol);

            //описание
            DataGridViewTextBoxColumn descCol = new DataGridViewTextBoxColumn();
            descCol.Name = "Description";
            descCol.HeaderText = "Описание";
            descCol.DataPropertyName = "Description";
            descCol.Width = 200;
            descCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewRecipes.Columns.Add(descCol);

            // ингредиенты
            DataGridViewTextBoxColumn ingCol = new DataGridViewTextBoxColumn();
            ingCol.Name = "Ingredients";
            ingCol.HeaderText = "Ингредиенты";
            ingCol.DataPropertyName = "Ingredients";
            ingCol.Width = 100;
            dataGridViewRecipes.Columns.Add(ingCol);

            // тип блюда
            DataGridViewTextBoxColumn typeCol = new DataGridViewTextBoxColumn();
            typeCol.Name = "TypeDish";
            typeCol.HeaderText = "Тип блюда";
            typeCol.DataPropertyName = "TypeDish";
            typeCol.Width = 80;
            dataGridViewRecipes.Columns.Add(typeCol);

            // сложность
            DataGridViewTextBoxColumn diffCol = new DataGridViewTextBoxColumn();
            diffCol.Name = "Difficulty";
            diffCol.HeaderText = "Сложность";
            diffCol.DataPropertyName = "Difficulty";
            diffCol.Width = 80;
            dataGridViewRecipes.Columns.Add(diffCol);

            // приём пищи
            DataGridViewTextBoxColumn mealCol = new DataGridViewTextBoxColumn();
            mealCol.Name = "MealType";
            mealCol.HeaderText = "Прием пищи";
            mealCol.DataPropertyName = "MealType";
            mealCol.Width = 80;
            dataGridViewRecipes.Columns.Add(mealCol);

            // кнопка изменить
            DataGridViewButtonColumn editCol = new DataGridViewButtonColumn();
            editCol.Name = "Edit";
            editCol.HeaderText = "";
            editCol.Text = "Изменить";
            editCol.UseColumnTextForButtonValue = true;
            editCol.Width = 100;
            editCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editCol.Resizable = DataGridViewTriState.False;
            dataGridViewRecipes.Columns.Add(editCol);

            // кнопка удалить
            DataGridViewButtonColumn deleteCol = new DataGridViewButtonColumn();
            deleteCol.Name = "Delete";
            deleteCol.HeaderText = "";
            deleteCol.Text = "Удалить";
            deleteCol.UseColumnTextForButtonValue = true;
            deleteCol.Width = 100;
            deleteCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteCol.Resizable = DataGridViewTriState.False;
            dataGridViewRecipes.Columns.Add(deleteCol);
        }

        private void LoadRecipes()
        {
            string query = @"
                SELECT 
                    r.id AS Id,
                    r.title AS Title,
                    r.description AS Description,
                    GROUP_CONCAT(i.name ORDER BY i.name SEPARATOR '\n') AS Ingredients,
                    td.name AS TypeDish,
                    tdf.name AS Difficulty,
                    mt.name AS MealType
                FROM recipes r
                JOIN tipe_dishes td ON r.type_dish_id = td.id
                JOIN type_difficults tdf ON r.difficulty_id = tdf.id
                JOIN meal_types mt ON r.meal_type_id = mt.id
                LEFT JOIN recipe_ingredients ri ON r.id = ri.recipe_id
                LEFT JOIN ingredients i ON ri.ingredient_id = i.id";
            string searchText = textBoxSearch.Text.Trim();
            if (!string.IsNullOrWhiteSpace(searchText) && searchText != "Поиск")
            {
                string search = searchText.Replace("'", "''");
                query += $" WHERE r.title LIKE '{search}%'";
            }
            query += " GROUP BY r.id ORDER BY r.id";
            DB db = new DB();
            DataTable table = db.ExecuteQuery(query);
            dataGridViewRecipes.DataSource = table;

            dataGridViewRecipes.Columns["Ingredients"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewRecipes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
            if (loginForm != null)
            {
                loginForm.Show();
            }
            else
            {
                LoginForm newLoginForm = new LoginForm();
                newLoginForm.Show();
            }
        }
        private void DeleteRecipe(int recipeId)
        {
            try
            {
                DB db = new DB();
                db.ExecuteNonQuery($"DELETE FROM recipes WHERE id = {recipeId}");
                MessageBox.Show("Рецепт удалён!");
                LoadRecipes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void dataGridViewRecipes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int recipeId = Convert.ToInt32(dataGridViewRecipes.Rows[e.RowIndex].Cells["Id"].Value);
                string recipeTitle = dataGridViewRecipes.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                if (e.ColumnIndex == dataGridViewRecipes.Columns["Edit"].Index)
                {
                    EditForm editForm = new EditForm(recipeId);
                    editForm.ShowDialog();
                    LoadRecipes(); 
                }
                else if (e.ColumnIndex == dataGridViewRecipes.Columns["Delete"].Index)
                {
                    DialogResult result = MessageBox.Show($"Удалить рецепт '{recipeTitle}'?",
                        "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DeleteRecipe(recipeId);
                    }
                }
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EditForm addForm = new EditForm();
            addForm.ShowDialog();
            LoadRecipes();
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Поиск")
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                textBoxSearch.Text = "Поиск";
                textBoxSearch.ForeColor = Color.Gray;
            }
        }
        

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRecipes();
        }
    }
    
}
