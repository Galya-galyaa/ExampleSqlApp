using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSqlApp
{
    public partial class EditForm : Form
    {
        private int recipeId;
        private DB db = new DB();

        private bool isEditMode;

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            if (!isEditMode && recipeId == 0)
            {
                if (!SaveRecipeTemporarily())
                    return;
            }

            if (cmbIngredients.SelectedValue == null)
            {
                MessageBox.Show("Выберите ингредиент из списка!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ingredientId = (int)cmbIngredients.SelectedValue;
            string ingredientName = cmbIngredients.Text;

            DataTable check = db.ExecuteQuery($@"
                SELECT * FROM recipe_ingredients 
                WHERE recipe_id = {recipeId} AND ingredient_id = {ingredientId}");

            if (check.Rows.Count > 0)
            {
                MessageBox.Show($"Ингредиент '{ingredientName}' уже добавлен!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insertQuery = $@"
                INSERT INTO recipe_ingredients (recipe_id, ingredient_id) 
                VALUES ({recipeId}, {ingredientId})";
            db.ExecuteNonQuery(insertQuery);

            LoadIngredientsList();
        }

        private void btnRemoveIngredient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIngredientsList.Text))
            {
                MessageBox.Show("Нет ингредиентов для удаления!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form selectForm = new Form();
            selectForm.Text = "Выберите ингредиент для удаления";
            selectForm.Size = new Size(300, 250);
            selectForm.StartPosition = FormStartPosition.CenterParent;
            selectForm.FormBorderStyle = FormBorderStyle.FixedDialog;

            ListBox lbIngredients = new ListBox();
            lbIngredients.Location = new Point(10, 10);
            lbIngredients.Size = new Size(260, 150);

            DataTable ingredients = db.ExecuteQuery($@"
                SELECT i.id, i.name 
                FROM recipe_ingredients ri
                JOIN ingredients i ON ri.ingredient_id = i.id
                WHERE ri.recipe_id = {recipeId}
                ORDER BY i.name");

            foreach (DataRow row in ingredients.Rows)
            {
                lbIngredients.Items.Add(row["name"].ToString());
            }

            Button btnConfirm = new Button();
            btnConfirm.Text = "Удалить";
            btnConfirm.Location = new Point(10, 170);
            btnConfirm.Size = new Size(100, 30);
            btnConfirm.BackColor = System.Drawing.Color.LightCoral;
            btnConfirm.Click += (s, ev) =>
            {
                if (lbIngredients.SelectedItem != null)
                {
                    string selectedName = lbIngredients.SelectedItem.ToString();
                    DataTable ingId = db.ExecuteQuery($"SELECT id FROM ingredients WHERE name = '{selectedName.Replace("'", "''")}'");
                    if (ingId.Rows.Count > 0)
                    {
                        int ingIdValue = Convert.ToInt32(ingId.Rows[0]["id"]);
                        db.ExecuteNonQuery($"DELETE FROM recipe_ingredients WHERE recipe_id = {recipeId} AND ingredient_id = {ingIdValue}");
                        LoadIngredientsList();
                    }
                    selectForm.Close();
                }
                else
                {
                    MessageBox.Show("Выберите ингредиент для удаления!");
                }
            };

            Button btnCancelSelect = new Button();
            btnCancelSelect.Text = "Отмена";
            btnCancelSelect.Location = new Point(120, 170);
            btnCancelSelect.Size = new Size(100, 30);
            btnCancelSelect.Click += (s, ev) => selectForm.Close();

            selectForm.Controls.Add(lbIngredients);
            selectForm.Controls.Add(btnConfirm);
            selectForm.Controls.Add(btnCancelSelect);
            selectForm.ShowDialog();
        }

        private void btnAddNewIngredient_Click(object sender, EventArgs e)
        {
            if (!isEditMode && recipeId == 0)
            {
                if (!SaveRecipeTemporarily())
                    return;
            }

            Form inputForm = new Form();
            inputForm.Text = "Новый ингредиент";
            inputForm.Size = new Size(350, 180);
            inputForm.StartPosition = FormStartPosition.CenterParent;
            inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputForm.MaximizeBox = false;
            inputForm.MinimizeBox = false;

            Label lblInstruction = new Label();
            lblInstruction.Text = "Введите название нового ингредиента:";
            lblInstruction.Location = new Point(20, 20);
            lblInstruction.Size = new Size(290, 25);
            lblInstruction.Font = new Font("Segoe UI", 10);

            TextBox txtNewIngredient = new TextBox();
            txtNewIngredient.Location = new Point(20, 50);
            txtNewIngredient.Size = new Size(290, 25);
            txtNewIngredient.Font = new Font("Segoe UI", 10);

            Button btnAdd = new Button();
            btnAdd.Text = "Добавить";
            btnAdd.Location = new Point(20, 90);
            btnAdd.Size = new Size(120, 35);
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnAdd.Click += (s, ev) =>
            {
                string newIngredientName = txtNewIngredient.Text.Trim();
                if (string.IsNullOrEmpty(newIngredientName))
                {
                    MessageBox.Show("Введите название ингредиента!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable check = db.ExecuteQuery($"SELECT id FROM ingredients WHERE name = '{newIngredientName.Replace("'", "''")}'");
                if (check.Rows.Count > 0)
                {
                    MessageBox.Show("Такой ингредиент уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string insertQuery = $"INSERT INTO ingredients (name) VALUES ('{newIngredientName.Replace("'", "''")}')";
                db.ExecuteNonQuery(insertQuery);

                MessageBox.Show($"Ингредиент '{newIngredientName}' добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadIngredientsComboBox();

                inputForm.Close();
            };

            Button btnCancelAdd = new Button();
            btnCancelAdd.Text = "Отмена";
            btnCancelAdd.Location = new Point(150, 90);
            btnCancelAdd.Size = new Size(120, 35);
            btnCancelAdd.BackColor = Color.LightCoral;
            btnCancelAdd.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnCancelAdd.Click += (s, ev) => inputForm.Close();

            inputForm.Controls.Add(lblInstruction);
            inputForm.Controls.Add(txtNewIngredient);
            inputForm.Controls.Add(btnAdd);
            inputForm.Controls.Add(btnCancelAdd);

            inputForm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int mealTypeId = GetMealTypeId();
                int dishTypeId = GetDishTypeId();
                int difficultyId = GetDifficultyId();

                if (isEditMode && recipeId > 0)
                {
                    string query = $@"
                        UPDATE recipes SET 
                            title = '{txtTitle.Text.Replace("'", "''")}',
                            description = '{txtDescription.Text.Replace("'", "''")}',
                            type_dish_id = {dishTypeId},
                            difficulty_id = {difficultyId},
                            meal_type_id = {mealTypeId}
                        WHERE id = {recipeId}";

                    db.ExecuteNonQuery(query);
                    MessageBox.Show("Рецепт обновлён!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string query = $@"
                        INSERT INTO recipes (title, description, type_dish_id, difficulty_id, meal_type_id) 
                        VALUES ('{txtTitle.Text.Replace("'", "''")}', 
                                '{txtDescription.Text.Replace("'", "''")}', 
                                {dishTypeId}, 
                                {difficultyId}, 
                                {mealTypeId})";

                    db.ExecuteNonQuery(query);
                    MessageBox.Show("Рецепт добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetMealTypeId()
        {
            if (rbMealBreakfast.Checked) return 1;
            if (rbMealLunch.Checked) return 2;
            if (rbMealDinner.Checked) return 3;
            return 2;
        }

        private int GetDishTypeId()
        {
            if (rbTypeFirst.Checked) return 1;
            if (rbTypeSecond.Checked) return 2;
            if (rbTypeThird.Checked) return 3;
            return 2;
        }

        private int GetDifficultyId()
        {
            if (rbDifficultyEasy.Checked) return 1;
            if (rbDifficultyMedium.Checked) return 2;
            if (rbDifficultyHard.Checked) return 3;
            return 2;
        }

        public EditForm(int id)
        {
            InitializeComponent();
            recipeId = id;
            isEditMode = true;
            this.Text = "Редактирование рецепта"; 
            labelTitle.Text = "Редактирование блюда";
            LoadRecipeData();
            LoadIngredientsComboBox();
        }
        public EditForm()
        {
            InitializeComponent();
            recipeId = 0;
            isEditMode = false;
            this.Text = "Добавление рецепта";
            labelTitle.Text = "Добавление блюда";
            ClearForm();
            LoadIngredientsComboBox();
        }
        private void ClearForm()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            txtIngredientsList.Clear();
            rbMealBreakfast.Checked = false;
            rbMealLunch.Checked = false;
            rbMealDinner.Checked = false;
            rbTypeFirst.Checked = false;
            rbTypeSecond.Checked = false;
            rbTypeThird.Checked = false;
            rbDifficultyEasy.Checked = false;
            rbDifficultyMedium.Checked = false;
            rbDifficultyHard.Checked = false;
        }
        private void LoadRecipeData()
        {
            string query = $"SELECT * FROM recipes WHERE id = {recipeId}";
            DataTable recipe = db.ExecuteQuery(query);

            if (recipe.Rows.Count > 0)
            {
                DataRow row = recipe.Rows[0];
                txtTitle.Text = row["title"].ToString();
                txtDescription.Text = row["description"].ToString();

                int mealTypeId = Convert.ToInt32(row["meal_type_id"]);
                string mealTypeName = GetMealTypeName(mealTypeId);
                if (mealTypeName == "Завтрак") rbMealBreakfast.Checked = true;
                else if (mealTypeName == "Обед") rbMealLunch.Checked = true;
                else if (mealTypeName == "Ужин") rbMealDinner.Checked = true;

                int dishTypeId = Convert.ToInt32(row["type_dish_id"]);
                string dishTypeName = GetDishTypeName(dishTypeId);
                if (dishTypeName == "Супы" || dishTypeName == "Первое") rbTypeFirst.Checked = true;
                else if (dishTypeName == "Вторые блюда" || dishTypeName == "Второе") rbTypeSecond.Checked = true;
                else if (dishTypeName == "Десерты" || dishTypeName == "Третье") rbTypeThird.Checked = true;

                int difficultyId = Convert.ToInt32(row["difficulty_id"]);
                string difficultyName = GetDifficultyName(difficultyId);
                if (difficultyName == "Легко") rbDifficultyEasy.Checked = true;
                else if (difficultyName == "Средне") rbDifficultyMedium.Checked = true;
                else if (difficultyName == "Сложно") rbDifficultyHard.Checked = true;
            }

            LoadIngredientsList();
        }
        private string GetMealTypeName(int id)
        {
            DataTable dt = db.ExecuteQuery($"SELECT name FROM meal_types WHERE id = {id}");
            return dt.Rows.Count > 0 ? dt.Rows[0]["name"].ToString() : "";
        }

        private string GetDishTypeName(int id)
        {
            DataTable dt = db.ExecuteQuery($"SELECT name FROM tipe_dishes WHERE id = {id}");
            return dt.Rows.Count > 0 ? dt.Rows[0]["name"].ToString() : "";
        }

        private string GetDifficultyName(int id)
        {
            DataTable dt = db.ExecuteQuery($"SELECT name FROM type_difficults WHERE id = {id}");
            return dt.Rows.Count > 0 ? dt.Rows[0]["name"].ToString() : "";
        }

        private void LoadIngredientsComboBox()
        {
            DataTable ingredients = db.ExecuteQuery("SELECT id, name FROM ingredients ORDER BY name");
            cmbIngredients.DataSource = ingredients;
            cmbIngredients.DisplayMember = "name";
            cmbIngredients.ValueMember = "id";
        }

        private void LoadIngredientsList()
        {
            string query = $@"
                SELECT i.name 
                FROM recipe_ingredients ri
                JOIN ingredients i ON ri.ingredient_id = i.id
                WHERE ri.recipe_id = {recipeId}
                ORDER BY i.name";

            DataTable ingredients = db.ExecuteQuery(query);
            txtIngredientsList.Clear();
            foreach (DataRow row in ingredients.Rows)
            {
                txtIngredientsList.AppendText(row["name"].ToString() + Environment.NewLine);
            }
        }
        private bool SaveRecipeTemporarily()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    MessageBox.Show("Сначала введите название рецепта!",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                int mealTypeId = GetMealTypeId();
                int dishTypeId = GetDishTypeId();
                int difficultyId = GetDifficultyId();

                string query = $@"
                    INSERT INTO recipes (title, description, type_dish_id, difficulty_id, meal_type_id) 
                    VALUES ('{txtTitle.Text.Replace("'", "''")}', 
                            '{txtDescription.Text.Replace("'", "''")}', 
                            {dishTypeId}, 
                            {difficultyId}, 
                            {mealTypeId})";

                db.ExecuteNonQuery(query);

                DataTable result = db.ExecuteQuery("SELECT LAST_INSERT_ID() as id");
                if (result.Rows.Count > 0)
                {
                    recipeId = Convert.ToInt32(result.Rows[0]["id"]);
                    isEditMode = true;
                    this.Text = "Редактирование рецепта (ID: " + recipeId + ")";
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении рецепта: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
