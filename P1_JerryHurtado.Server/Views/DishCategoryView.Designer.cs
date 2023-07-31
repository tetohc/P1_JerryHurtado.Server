namespace P1_JerryHurtado.Server.Views
{
    partial class DishCategoryView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            tabControlDishCategory = new TabControl();
            tabPageDishCategoryList = new TabPage();
            dataGridViewDishCategory = new DataGridView();
            btnAddNewDishCategory = new Button();
            tabPageDishCategoryAddNew = new TabPage();
            btnCancelDishCategory = new Button();
            btnSaveDishCategory = new Button();
            comboBoxStatus = new ComboBox();
            textBoxDescription = new TextBox();
            label5 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            tabControlDishCategory.SuspendLayout();
            tabPageDishCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDishCategory).BeginInit();
            tabPageDishCategoryAddNew.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 41, 66);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 82);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(189, 147, 249);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(232, 28);
            label1.TabIndex = 0;
            label1.Text = "Categoría de Plato";
            // 
            // tabControlDishCategory
            // 
            tabControlDishCategory.Controls.Add(tabPageDishCategoryList);
            tabControlDishCategory.Controls.Add(tabPageDishCategoryAddNew);
            tabControlDishCategory.Dock = DockStyle.Fill;
            tabControlDishCategory.Location = new Point(0, 82);
            tabControlDishCategory.Name = "tabControlDishCategory";
            tabControlDishCategory.SelectedIndex = 0;
            tabControlDishCategory.Size = new Size(806, 469);
            tabControlDishCategory.TabIndex = 3;
            // 
            // tabPageDishCategoryList
            // 
            tabPageDishCategoryList.BackColor = Color.FromArgb(40, 41, 66);
            tabPageDishCategoryList.Controls.Add(dataGridViewDishCategory);
            tabPageDishCategoryList.Controls.Add(btnAddNewDishCategory);
            tabPageDishCategoryList.Location = new Point(4, 24);
            tabPageDishCategoryList.Name = "tabPageDishCategoryList";
            tabPageDishCategoryList.Padding = new Padding(3);
            tabPageDishCategoryList.Size = new Size(798, 441);
            tabPageDishCategoryList.TabIndex = 0;
            tabPageDishCategoryList.Text = "Lista de Categorías de plato";
            // 
            // dataGridViewDishCategory
            // 
            dataGridViewDishCategory.AllowUserToAddRows = false;
            dataGridViewDishCategory.AllowUserToDeleteRows = false;
            dataGridViewDishCategory.AllowUserToResizeRows = false;
            dataGridViewDishCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDishCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDishCategory.BackgroundColor = Color.FromArgb(40, 41, 66);
            dataGridViewDishCategory.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewDishCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDishCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewDishCategory.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDishCategory.GridColor = Color.FromArgb(189, 147, 249);
            dataGridViewDishCategory.Location = new Point(11, 94);
            dataGridViewDishCategory.Name = "dataGridViewDishCategory";
            dataGridViewDishCategory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(31, 41, 54);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewDishCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewDishCategory.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 41, 66);
            dataGridViewDishCategory.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewDishCategory.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewDishCategory.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewDishCategory.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewDishCategory.RowTemplate.Height = 25;
            dataGridViewDishCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDishCategory.Size = new Size(757, 339);
            dataGridViewDishCategory.TabIndex = 11;
            // 
            // btnAddNewDishCategory
            // 
            btnAddNewDishCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNewDishCategory.BackColor = Color.FromArgb(56, 58, 89);
            btnAddNewDishCategory.Cursor = Cursors.Hand;
            btnAddNewDishCategory.FlatStyle = FlatStyle.Flat;
            btnAddNewDishCategory.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNewDishCategory.ForeColor = Color.FromArgb(189, 147, 249);
            btnAddNewDishCategory.Location = new Point(645, 18);
            btnAddNewDishCategory.Name = "btnAddNewDishCategory";
            btnAddNewDishCategory.Size = new Size(123, 49);
            btnAddNewDishCategory.TabIndex = 10;
            btnAddNewDishCategory.Text = "Agregar";
            btnAddNewDishCategory.UseVisualStyleBackColor = false;
            // 
            // tabPageDishCategoryAddNew
            // 
            tabPageDishCategoryAddNew.BackColor = Color.FromArgb(40, 41, 66);
            tabPageDishCategoryAddNew.Controls.Add(btnCancelDishCategory);
            tabPageDishCategoryAddNew.Controls.Add(btnSaveDishCategory);
            tabPageDishCategoryAddNew.Controls.Add(comboBoxStatus);
            tabPageDishCategoryAddNew.Controls.Add(textBoxDescription);
            tabPageDishCategoryAddNew.Controls.Add(label5);
            tabPageDishCategoryAddNew.Controls.Add(label3);
            tabPageDishCategoryAddNew.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageDishCategoryAddNew.Location = new Point(4, 24);
            tabPageDishCategoryAddNew.Name = "tabPageDishCategoryAddNew";
            tabPageDishCategoryAddNew.Padding = new Padding(3);
            tabPageDishCategoryAddNew.Size = new Size(798, 441);
            tabPageDishCategoryAddNew.TabIndex = 1;
            tabPageDishCategoryAddNew.Text = "Agregar nuevo";
            // 
            // btnCancelDishCategory
            // 
            btnCancelDishCategory.BackColor = Color.FromArgb(56, 58, 89);
            btnCancelDishCategory.Cursor = Cursors.Hand;
            btnCancelDishCategory.FlatStyle = FlatStyle.Flat;
            btnCancelDishCategory.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelDishCategory.ForeColor = Color.FromArgb(189, 147, 249);
            btnCancelDishCategory.Location = new Point(450, 314);
            btnCancelDishCategory.Name = "btnCancelDishCategory";
            btnCancelDishCategory.Size = new Size(112, 36);
            btnCancelDishCategory.TabIndex = 4;
            btnCancelDishCategory.Text = "Cancelar";
            btnCancelDishCategory.UseVisualStyleBackColor = false;
            // 
            // btnSaveDishCategory
            // 
            btnSaveDishCategory.BackColor = Color.FromArgb(56, 58, 89);
            btnSaveDishCategory.Cursor = Cursors.Hand;
            btnSaveDishCategory.FlatStyle = FlatStyle.Flat;
            btnSaveDishCategory.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveDishCategory.ForeColor = Color.FromArgb(189, 147, 249);
            btnSaveDishCategory.Location = new Point(286, 314);
            btnSaveDishCategory.Name = "btnSaveDishCategory";
            btnSaveDishCategory.Size = new Size(112, 36);
            btnSaveDishCategory.TabIndex = 3;
            btnSaveDishCategory.Text = "Guardar";
            btnSaveDishCategory.UseVisualStyleBackColor = false;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.BackColor = Color.FromArgb(36, 49, 60);
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStatus.ForeColor = Color.Gainsboro;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(287, 246);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(275, 25);
            comboBoxStatus.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(286, 117);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(276, 107);
            textBoxDescription.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(189, 147, 249);
            label5.Location = new Point(209, 250);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 3;
            label5.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(189, 147, 249);
            label3.Location = new Point(182, 120);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 1;
            label3.Text = "Descripción:";
            // 
            // DishCategoryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 551);
            Controls.Add(tabControlDishCategory);
            Controls.Add(panel1);
            Name = "DishCategoryView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DishCategoryView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControlDishCategory.ResumeLayout(false);
            tabPageDishCategoryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDishCategory).EndInit();
            tabPageDishCategoryAddNew.ResumeLayout(false);
            tabPageDishCategoryAddNew.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControlDishCategory;
        private TabPage tabPageDishCategoryList;
        private DataGridView dataGridViewDishCategory;
        private Button btnAddNewDishCategory;
        private TabPage tabPageDishCategoryAddNew;
        private Button btnCancelDishCategory;
        private Button btnSaveDishCategory;
        private ComboBox comboBoxStatus;
        private TextBox textBoxDescription;
        private Label label5;
        private Label label3;
    }
}