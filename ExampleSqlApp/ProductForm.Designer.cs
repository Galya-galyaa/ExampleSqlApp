namespace ExampleSqlApp
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelRecipes = new System.Windows.Forms.Panel();
            this.nameRecipes = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewRecipes = new System.Windows.Forms.DataGridView();
            this.comboBoxChoice = new System.Windows.Forms.ComboBox();
            this.panelRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(1125, 43);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(138, 37);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelRecipes
            // 
            this.panelRecipes.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelRecipes.Controls.Add(this.nameRecipes);
            this.panelRecipes.Controls.Add(this.buttonBack);
            this.panelRecipes.Location = new System.Drawing.Point(-2, 0);
            this.panelRecipes.Name = "panelRecipes";
            this.panelRecipes.Size = new System.Drawing.Size(1279, 182);
            this.panelRecipes.TabIndex = 1;
            // 
            // nameRecipes
            // 
            this.nameRecipes.AutoSize = true;
            this.nameRecipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameRecipes.ForeColor = System.Drawing.Color.White;
            this.nameRecipes.Location = new System.Drawing.Point(57, 84);
            this.nameRecipes.Name = "nameRecipes";
            this.nameRecipes.Size = new System.Drawing.Size(144, 37);
            this.nameRecipes.TabIndex = 1;
            this.nameRecipes.Text = "Рецепты";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(998, 211);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(263, 30);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.Text = "Поиск";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(12, 199);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(169, 48);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewRecipes
            // 
            this.dataGridViewRecipes.AllowUserToAddRows = false;
            this.dataGridViewRecipes.AllowUserToDeleteRows = false;
            this.dataGridViewRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRecipes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRecipes.Location = new System.Drawing.Point(12, 266);
            this.dataGridViewRecipes.Name = "dataGridViewRecipes";
            this.dataGridViewRecipes.ReadOnly = true;
            this.dataGridViewRecipes.RowHeadersWidth = 62;
            this.dataGridViewRecipes.RowTemplate.Height = 28;
            this.dataGridViewRecipes.Size = new System.Drawing.Size(1249, 455);
            this.dataGridViewRecipes.TabIndex = 4;
            this.dataGridViewRecipes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecipes_CellClick);
            // 
            // comboBoxChoice
            // 
            this.comboBoxChoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChoice.FormattingEnabled = true;
            this.comboBoxChoice.Location = new System.Drawing.Point(220, 208);
            this.comboBoxChoice.Name = "comboBoxChoice";
            this.comboBoxChoice.Size = new System.Drawing.Size(210, 33);
            this.comboBoxChoice.TabIndex = 5;
            this.comboBoxChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoice_SelectedIndexChanged);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1275, 733);
            this.Controls.Add(this.comboBoxChoice);
            this.Controls.Add(this.dataGridViewRecipes);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.panelRecipes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.panelRecipes.ResumeLayout(false);
            this.panelRecipes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelRecipes;
        private System.Windows.Forms.Label nameRecipes;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewRecipes;
        private System.Windows.Forms.ComboBox comboBoxChoice;
    }
}