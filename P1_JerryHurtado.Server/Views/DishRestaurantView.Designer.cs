namespace P1_JerryHurtado.Server.Views
{
    partial class DishRestaurantView
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            tabPageDishRestaurantAddNew = new TabPage();
            btnCancelDishRestaurant = new Button();
            btnSaveDishRestaurant = new Button();
            dataGridViewDishes = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            comboBoxRestaurant = new ComboBox();
            dataGridViewActiveRestaurants = new DataGridView();
            label2 = new Label();
            tabPageDishRestaurantList = new TabPage();
            btnAddNewDishRestaurant = new Button();
            dataGridViewDishRestaurant = new DataGridView();
            tabControlDishRestaurant = new TabControl();
            panel1.SuspendLayout();
            tabPageDishRestaurantAddNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDishes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewActiveRestaurants).BeginInit();
            tabPageDishRestaurantList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDishRestaurant).BeginInit();
            tabControlDishRestaurant.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 41, 66);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 82);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(189, 147, 249);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(270, 28);
            label1.TabIndex = 0;
            label1.Text = "Platos por Restaurante";
            // 
            // tabPageDishRestaurantAddNew
            // 
            tabPageDishRestaurantAddNew.BackColor = Color.FromArgb(40, 41, 66);
            tabPageDishRestaurantAddNew.Controls.Add(btnCancelDishRestaurant);
            tabPageDishRestaurantAddNew.Controls.Add(btnSaveDishRestaurant);
            tabPageDishRestaurantAddNew.Controls.Add(dataGridViewDishes);
            tabPageDishRestaurantAddNew.Controls.Add(label4);
            tabPageDishRestaurantAddNew.Controls.Add(label3);
            tabPageDishRestaurantAddNew.Controls.Add(comboBoxRestaurant);
            tabPageDishRestaurantAddNew.Controls.Add(dataGridViewActiveRestaurants);
            tabPageDishRestaurantAddNew.Controls.Add(label2);
            tabPageDishRestaurantAddNew.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageDishRestaurantAddNew.Location = new Point(4, 24);
            tabPageDishRestaurantAddNew.Name = "tabPageDishRestaurantAddNew";
            tabPageDishRestaurantAddNew.Padding = new Padding(3);
            tabPageDishRestaurantAddNew.Size = new Size(934, 607);
            tabPageDishRestaurantAddNew.TabIndex = 1;
            tabPageDishRestaurantAddNew.Text = "Agregar nuevo";
            // 
            // btnCancelDishRestaurant
            // 
            btnCancelDishRestaurant.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelDishRestaurant.BackColor = Color.FromArgb(56, 58, 89);
            btnCancelDishRestaurant.Cursor = Cursors.Hand;
            btnCancelDishRestaurant.FlatStyle = FlatStyle.Flat;
            btnCancelDishRestaurant.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelDishRestaurant.ForeColor = Color.FromArgb(189, 147, 249);
            btnCancelDishRestaurant.Location = new Point(786, 550);
            btnCancelDishRestaurant.Name = "btnCancelDishRestaurant";
            btnCancelDishRestaurant.Size = new Size(112, 36);
            btnCancelDishRestaurant.TabIndex = 16;
            btnCancelDishRestaurant.Text = "Cancelar";
            btnCancelDishRestaurant.UseVisualStyleBackColor = false;
            // 
            // btnSaveDishRestaurant
            // 
            btnSaveDishRestaurant.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveDishRestaurant.BackColor = Color.FromArgb(56, 58, 89);
            btnSaveDishRestaurant.Cursor = Cursors.Hand;
            btnSaveDishRestaurant.FlatStyle = FlatStyle.Flat;
            btnSaveDishRestaurant.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveDishRestaurant.ForeColor = Color.FromArgb(189, 147, 249);
            btnSaveDishRestaurant.Location = new Point(655, 551);
            btnSaveDishRestaurant.Name = "btnSaveDishRestaurant";
            btnSaveDishRestaurant.Size = new Size(112, 36);
            btnSaveDishRestaurant.TabIndex = 15;
            btnSaveDishRestaurant.Text = "Guardar";
            btnSaveDishRestaurant.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDishes
            // 
            dataGridViewDishes.AllowUserToAddRows = false;
            dataGridViewDishes.AllowUserToDeleteRows = false;
            dataGridViewDishes.AllowUserToResizeRows = false;
            dataGridViewDishes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDishes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDishes.BackgroundColor = Color.FromArgb(40, 41, 66);
            dataGridViewDishes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewDishes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDishes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewDishes.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDishes.GridColor = Color.FromArgb(189, 147, 249);
            dataGridViewDishes.Location = new Point(8, 267);
            dataGridViewDishes.Name = "dataGridViewDishes";
            dataGridViewDishes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(31, 41, 54);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewDishes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewDishes.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 41, 66);
            dataGridViewDishes.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewDishes.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewDishes.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewDishes.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewDishes.RowTemplate.Height = 25;
            dataGridViewDishes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDishes.Size = new Size(911, 219);
            dataGridViewDishes.TabIndex = 14;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(189, 147, 249);
            label4.Location = new Point(11, 803);
            label4.Name = "label4";
            label4.Size = new Size(322, 21);
            label4.TabIndex = 13;
            label4.Text = "Seleccione los platos que quiere asignar.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(189, 147, 249);
            label3.Location = new Point(11, 25);
            label3.Name = "label3";
            label3.Size = new Size(174, 21);
            label3.TabIndex = 12;
            label3.Text = "Restaurantes activos";
            // 
            // comboBoxRestaurant
            // 
            comboBoxRestaurant.BackColor = Color.FromArgb(36, 49, 60);
            comboBoxRestaurant.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRestaurant.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRestaurant.ForeColor = Color.Gainsboro;
            comboBoxRestaurant.FormattingEnabled = true;
            comboBoxRestaurant.Location = new Point(225, 213);
            comboBoxRestaurant.Name = "comboBoxRestaurant";
            comboBoxRestaurant.Size = new Size(275, 25);
            comboBoxRestaurant.TabIndex = 1;
            // 
            // dataGridViewActiveRestaurants
            // 
            dataGridViewActiveRestaurants.AllowUserToAddRows = false;
            dataGridViewActiveRestaurants.AllowUserToDeleteRows = false;
            dataGridViewActiveRestaurants.AllowUserToResizeRows = false;
            dataGridViewActiveRestaurants.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewActiveRestaurants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewActiveRestaurants.BackgroundColor = Color.FromArgb(40, 41, 66);
            dataGridViewActiveRestaurants.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewActiveRestaurants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewActiveRestaurants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewActiveRestaurants.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewActiveRestaurants.GridColor = Color.FromArgb(189, 147, 249);
            dataGridViewActiveRestaurants.Location = new Point(11, 49);
            dataGridViewActiveRestaurants.Name = "dataGridViewActiveRestaurants";
            dataGridViewActiveRestaurants.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(31, 41, 54);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewActiveRestaurants.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewActiveRestaurants.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 41, 66);
            dataGridViewActiveRestaurants.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewActiveRestaurants.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewActiveRestaurants.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewActiveRestaurants.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewActiveRestaurants.RowTemplate.Height = 25;
            dataGridViewActiveRestaurants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewActiveRestaurants.Size = new Size(915, 157);
            dataGridViewActiveRestaurants.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(189, 147, 249);
            label2.Location = new Point(11, 218);
            label2.Name = "label2";
            label2.Size = new Size(211, 21);
            label2.TabIndex = 0;
            label2.Text = "Seleccione el restaurante:";
            // 
            // tabPageDishRestaurantList
            // 
            tabPageDishRestaurantList.BackColor = Color.FromArgb(40, 41, 66);
            tabPageDishRestaurantList.Controls.Add(btnAddNewDishRestaurant);
            tabPageDishRestaurantList.Controls.Add(dataGridViewDishRestaurant);
            tabPageDishRestaurantList.Location = new Point(4, 24);
            tabPageDishRestaurantList.Name = "tabPageDishRestaurantList";
            tabPageDishRestaurantList.Padding = new Padding(3);
            tabPageDishRestaurantList.Size = new Size(934, 607);
            tabPageDishRestaurantList.TabIndex = 0;
            tabPageDishRestaurantList.Text = "Lista de Platos por Restaurante";
            // 
            // btnAddNewDishRestaurant
            // 
            btnAddNewDishRestaurant.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNewDishRestaurant.BackColor = Color.FromArgb(56, 58, 89);
            btnAddNewDishRestaurant.Cursor = Cursors.Hand;
            btnAddNewDishRestaurant.FlatStyle = FlatStyle.Flat;
            btnAddNewDishRestaurant.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNewDishRestaurant.ForeColor = Color.FromArgb(189, 147, 249);
            btnAddNewDishRestaurant.Location = new Point(776, 29);
            btnAddNewDishRestaurant.Name = "btnAddNewDishRestaurant";
            btnAddNewDishRestaurant.Size = new Size(123, 49);
            btnAddNewDishRestaurant.TabIndex = 13;
            btnAddNewDishRestaurant.Text = "Agregar";
            btnAddNewDishRestaurant.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDishRestaurant
            // 
            dataGridViewDishRestaurant.AllowUserToAddRows = false;
            dataGridViewDishRestaurant.AllowUserToDeleteRows = false;
            dataGridViewDishRestaurant.AllowUserToResizeRows = false;
            dataGridViewDishRestaurant.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDishRestaurant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDishRestaurant.BackgroundColor = Color.FromArgb(40, 41, 66);
            dataGridViewDishRestaurant.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewDishRestaurant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewDishRestaurant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewDishRestaurant.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewDishRestaurant.GridColor = Color.FromArgb(189, 147, 249);
            dataGridViewDishRestaurant.Location = new Point(11, 104);
            dataGridViewDishRestaurant.Name = "dataGridViewDishRestaurant";
            dataGridViewDishRestaurant.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(31, 41, 54);
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewDishRestaurant.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewDishRestaurant.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 41, 66);
            dataGridViewDishRestaurant.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewDishRestaurant.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewDishRestaurant.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewDishRestaurant.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewDishRestaurant.RowTemplate.Height = 25;
            dataGridViewDishRestaurant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDishRestaurant.Size = new Size(902, 482);
            dataGridViewDishRestaurant.TabIndex = 1;
            // 
            // tabControlDishRestaurant
            // 
            tabControlDishRestaurant.Controls.Add(tabPageDishRestaurantList);
            tabControlDishRestaurant.Controls.Add(tabPageDishRestaurantAddNew);
            tabControlDishRestaurant.Dock = DockStyle.Fill;
            tabControlDishRestaurant.Location = new Point(0, 82);
            tabControlDishRestaurant.Name = "tabControlDishRestaurant";
            tabControlDishRestaurant.SelectedIndex = 0;
            tabControlDishRestaurant.Size = new Size(942, 635);
            tabControlDishRestaurant.TabIndex = 6;
            // 
            // DishRestaurantView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 717);
            Controls.Add(tabControlDishRestaurant);
            Controls.Add(panel1);
            Name = "DishRestaurantView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DishRestaurantView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageDishRestaurantAddNew.ResumeLayout(false);
            tabPageDishRestaurantAddNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDishes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewActiveRestaurants).EndInit();
            tabPageDishRestaurantList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDishRestaurant).EndInit();
            tabControlDishRestaurant.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabPage tabPageDishRestaurantAddNew;
        private Button btnCancelDishRestaurant;
        private Button btnSaveDishRestaurant;
        private DataGridView dataGridViewDishes;
        private Label label4;
        private Label label3;
        private ComboBox comboBoxRestaurant;
        private DataGridView dataGridViewActiveRestaurants;
        private Label label2;
        private TabPage tabPageDishRestaurantList;
        private Button btnAddNewDishRestaurant;
        private DataGridView dataGridViewDishRestaurant;
        private TabControl tabControlDishRestaurant;
    }
}