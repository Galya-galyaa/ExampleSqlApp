namespace ExampleSqlApp
{
    partial class EditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIngredients = new System.Windows.Forms.ComboBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnRemoveIngredient = new System.Windows.Forms.Button();
            this.txtIngredientsList = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNewIngredient = new System.Windows.Forms.Button();
            this.gbMealType = new System.Windows.Forms.GroupBox();
            this.rbMealDinner = new System.Windows.Forms.RadioButton();
            this.rbMealLunch = new System.Windows.Forms.RadioButton();
            this.rbMealBreakfast = new System.Windows.Forms.RadioButton();
            this.gbDishType = new System.Windows.Forms.GroupBox();
            this.rbTypeThird = new System.Windows.Forms.RadioButton();
            this.rbTypeSecond = new System.Windows.Forms.RadioButton();
            this.rbTypeFirst = new System.Windows.Forms.RadioButton();
            this.gbDifficulty = new System.Windows.Forms.GroupBox();
            this.rbDifficultyHard = new System.Windows.Forms.RadioButton();
            this.rbDifficultyMedium = new System.Windows.Forms.RadioButton();
            this.rbDifficultyEasy = new System.Windows.Forms.RadioButton();
            this.gbMealType.SuspendLayout();
            this.gbDishType.SuspendLayout();
            this.gbDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название: ";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(241, 90);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(194, 26);
            this.txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ингредиенты: ";
            // 
            // cmbIngredients
            // 
            this.cmbIngredients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbIngredients.FormattingEnabled = true;
            this.cmbIngredients.Location = new System.Drawing.Point(241, 162);
            this.cmbIngredients.Name = "cmbIngredients";
            this.cmbIngredients.Size = new System.Drawing.Size(194, 28);
            this.cmbIngredients.TabIndex = 3;
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddIngredient.Location = new System.Drawing.Point(512, 162);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(120, 34);
            this.btnAddIngredient.TabIndex = 4;
            this.btnAddIngredient.Text = "Добавить";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // btnRemoveIngredient
            // 
            this.btnRemoveIngredient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveIngredient.Location = new System.Drawing.Point(512, 229);
            this.btnRemoveIngredient.Name = "btnRemoveIngredient";
            this.btnRemoveIngredient.Size = new System.Drawing.Size(119, 33);
            this.btnRemoveIngredient.TabIndex = 5;
            this.btnRemoveIngredient.Text = "Удалить";
            this.btnRemoveIngredient.UseVisualStyleBackColor = true;
            this.btnRemoveIngredient.Click += new System.EventHandler(this.btnRemoveIngredient_Click);
            // 
            // txtIngredientsList
            // 
            this.txtIngredientsList.Location = new System.Drawing.Point(677, 162);
            this.txtIngredientsList.Multiline = true;
            this.txtIngredientsList.Name = "txtIngredientsList";
            this.txtIngredientsList.Size = new System.Drawing.Size(320, 143);
            this.txtIngredientsList.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Описание:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(206, 330);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(358, 167);
            this.txtDescription.TabIndex = 8;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(87, 32);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(212, 20);
            this.labelTitle.TabIndex = 21;
            this.labelTitle.Text = "Редактирование блюда";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(717, 582);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 37);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(888, 582);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 37);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddNewIngredient
            // 
            this.btnAddNewIngredient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewIngredient.Location = new System.Drawing.Point(241, 229);
            this.btnAddNewIngredient.Name = "btnAddNewIngredient";
            this.btnAddNewIngredient.Size = new System.Drawing.Size(194, 53);
            this.btnAddNewIngredient.TabIndex = 24;
            this.btnAddNewIngredient.Text = "Добавить новый ингредиент";
            this.btnAddNewIngredient.UseVisualStyleBackColor = true;
            this.btnAddNewIngredient.Click += new System.EventHandler(this.btnAddNewIngredient_Click);
            // 
            // gbMealType
            // 
            this.gbMealType.Controls.Add(this.rbMealDinner);
            this.gbMealType.Controls.Add(this.rbMealLunch);
            this.gbMealType.Controls.Add(this.rbMealBreakfast);
            this.gbMealType.Location = new System.Drawing.Point(74, 515);
            this.gbMealType.Name = "gbMealType";
            this.gbMealType.Size = new System.Drawing.Size(176, 112);
            this.gbMealType.TabIndex = 25;
            this.gbMealType.TabStop = false;
            this.gbMealType.Text = "Тип приема пищи:";
            // 
            // rbMealDinner
            // 
            this.rbMealDinner.AutoSize = true;
            this.rbMealDinner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMealDinner.Location = new System.Drawing.Point(36, 85);
            this.rbMealDinner.Name = "rbMealDinner";
            this.rbMealDinner.Size = new System.Drawing.Size(73, 24);
            this.rbMealDinner.TabIndex = 15;
            this.rbMealDinner.TabStop = true;
            this.rbMealDinner.Text = "Ужин";
            this.rbMealDinner.UseVisualStyleBackColor = true;
            // 
            // rbMealLunch
            // 
            this.rbMealLunch.AutoSize = true;
            this.rbMealLunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMealLunch.Location = new System.Drawing.Point(36, 55);
            this.rbMealLunch.Name = "rbMealLunch";
            this.rbMealLunch.Size = new System.Drawing.Size(75, 24);
            this.rbMealLunch.TabIndex = 14;
            this.rbMealLunch.TabStop = true;
            this.rbMealLunch.Text = "Обед";
            this.rbMealLunch.UseVisualStyleBackColor = true;
            // 
            // rbMealBreakfast
            // 
            this.rbMealBreakfast.AutoSize = true;
            this.rbMealBreakfast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMealBreakfast.Location = new System.Drawing.Point(36, 25);
            this.rbMealBreakfast.Name = "rbMealBreakfast";
            this.rbMealBreakfast.Size = new System.Drawing.Size(98, 24);
            this.rbMealBreakfast.TabIndex = 13;
            this.rbMealBreakfast.TabStop = true;
            this.rbMealBreakfast.Text = "Завтрак";
            this.rbMealBreakfast.UseVisualStyleBackColor = true;
            // 
            // gbDishType
            // 
            this.gbDishType.Controls.Add(this.rbTypeThird);
            this.gbDishType.Controls.Add(this.rbTypeSecond);
            this.gbDishType.Controls.Add(this.rbTypeFirst);
            this.gbDishType.Location = new System.Drawing.Point(256, 513);
            this.gbDishType.Name = "gbDishType";
            this.gbDishType.Size = new System.Drawing.Size(149, 123);
            this.gbDishType.TabIndex = 26;
            this.gbDishType.TabStop = false;
            this.gbDishType.Text = "Тип блюда:";
            // 
            // rbTypeThird
            // 
            this.rbTypeThird.AutoSize = true;
            this.rbTypeThird.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTypeThird.Location = new System.Drawing.Point(23, 87);
            this.rbTypeThird.Name = "rbTypeThird";
            this.rbTypeThird.Size = new System.Drawing.Size(88, 24);
            this.rbTypeThird.TabIndex = 19;
            this.rbTypeThird.TabStop = true;
            this.rbTypeThird.Text = "Третье";
            this.rbTypeThird.UseVisualStyleBackColor = true;
            // 
            // rbTypeSecond
            // 
            this.rbTypeSecond.AutoSize = true;
            this.rbTypeSecond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTypeSecond.Location = new System.Drawing.Point(23, 57);
            this.rbTypeSecond.Name = "rbTypeSecond";
            this.rbTypeSecond.Size = new System.Drawing.Size(90, 24);
            this.rbTypeSecond.TabIndex = 18;
            this.rbTypeSecond.TabStop = true;
            this.rbTypeSecond.Text = "Второе";
            this.rbTypeSecond.UseVisualStyleBackColor = true;
            // 
            // rbTypeFirst
            // 
            this.rbTypeFirst.AutoSize = true;
            this.rbTypeFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTypeFirst.Location = new System.Drawing.Point(23, 27);
            this.rbTypeFirst.Name = "rbTypeFirst";
            this.rbTypeFirst.Size = new System.Drawing.Size(91, 24);
            this.rbTypeFirst.TabIndex = 17;
            this.rbTypeFirst.TabStop = true;
            this.rbTypeFirst.Text = "Первое";
            this.rbTypeFirst.UseVisualStyleBackColor = true;
            // 
            // gbDifficulty
            // 
            this.gbDifficulty.Controls.Add(this.rbDifficultyHard);
            this.gbDifficulty.Controls.Add(this.rbDifficultyMedium);
            this.gbDifficulty.Controls.Add(this.rbDifficultyEasy);
            this.gbDifficulty.Location = new System.Drawing.Point(446, 515);
            this.gbDifficulty.Name = "gbDifficulty";
            this.gbDifficulty.Size = new System.Drawing.Size(186, 121);
            this.gbDifficulty.TabIndex = 27;
            this.gbDifficulty.TabStop = false;
            this.gbDifficulty.Text = "Степень сложности:";
            // 
            // rbDifficultyHard
            // 
            this.rbDifficultyHard.AutoSize = true;
            this.rbDifficultyHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDifficultyHard.Location = new System.Drawing.Point(49, 85);
            this.rbDifficultyHard.Name = "rbDifficultyHard";
            this.rbDifficultyHard.Size = new System.Drawing.Size(93, 24);
            this.rbDifficultyHard.TabIndex = 22;
            this.rbDifficultyHard.TabStop = true;
            this.rbDifficultyHard.Text = "Сложно";
            this.rbDifficultyHard.UseVisualStyleBackColor = true;
            // 
            // rbDifficultyMedium
            // 
            this.rbDifficultyMedium.AutoSize = true;
            this.rbDifficultyMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDifficultyMedium.Location = new System.Drawing.Point(49, 55);
            this.rbDifficultyMedium.Name = "rbDifficultyMedium";
            this.rbDifficultyMedium.Size = new System.Drawing.Size(92, 24);
            this.rbDifficultyMedium.TabIndex = 21;
            this.rbDifficultyMedium.TabStop = true;
            this.rbDifficultyMedium.Text = "Средне";
            this.rbDifficultyMedium.UseVisualStyleBackColor = true;
            // 
            // rbDifficultyEasy
            // 
            this.rbDifficultyEasy.AutoSize = true;
            this.rbDifficultyEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDifficultyEasy.Location = new System.Drawing.Point(49, 25);
            this.rbDifficultyEasy.Name = "rbDifficultyEasy";
            this.rbDifficultyEasy.Size = new System.Drawing.Size(79, 24);
            this.rbDifficultyEasy.TabIndex = 20;
            this.rbDifficultyEasy.TabStop = true;
            this.rbDifficultyEasy.Text = "Легко";
            this.rbDifficultyEasy.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 662);
            this.Controls.Add(this.gbDifficulty);
            this.Controls.Add(this.gbDishType);
            this.Controls.Add(this.gbMealType);
            this.Controls.Add(this.btnAddNewIngredient);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIngredientsList);
            this.Controls.Add(this.btnRemoveIngredient);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.cmbIngredients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.gbMealType.ResumeLayout(false);
            this.gbMealType.PerformLayout();
            this.gbDishType.ResumeLayout(false);
            this.gbDishType.PerformLayout();
            this.gbDifficulty.ResumeLayout(false);
            this.gbDifficulty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIngredients;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Button btnRemoveIngredient;
        private System.Windows.Forms.TextBox txtIngredientsList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNewIngredient;
        private System.Windows.Forms.GroupBox gbMealType;
        private System.Windows.Forms.GroupBox gbDishType;
        private System.Windows.Forms.GroupBox gbDifficulty;
        private System.Windows.Forms.RadioButton rbMealDinner;
        private System.Windows.Forms.RadioButton rbMealLunch;
        private System.Windows.Forms.RadioButton rbMealBreakfast;
        private System.Windows.Forms.RadioButton rbTypeThird;
        private System.Windows.Forms.RadioButton rbTypeSecond;
        private System.Windows.Forms.RadioButton rbTypeFirst;
        private System.Windows.Forms.RadioButton rbDifficultyHard;
        private System.Windows.Forms.RadioButton rbDifficultyMedium;
        private System.Windows.Forms.RadioButton rbDifficultyEasy;
    }
}