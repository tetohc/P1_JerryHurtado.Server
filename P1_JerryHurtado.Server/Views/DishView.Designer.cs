namespace P1_JerryHurtado.Server.Views
{
    partial class DishView
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
            tabControlDish = new TabControl();
            tabPageDishList = new TabPage();
            btnAddNewDish = new Button();
            dataGridViewDish = new DataGridView();
            tabPageDishAddNew = new TabPage();
            maskedTextBoxPrice = new MaskedTextBox();
            btnCancelDish = new Button();
            btnSaveDish = new Button();
            comboBoxCategory = new ComboBox();
            textBoxName = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            tabControlDish.SuspendLayout();
            tabPageDishList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDish).BeginInit();
            tabPageDishAddNew.SuspendLayout();
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
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(189, 147, 249);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 0;
            label1.Text = "Platos";
            // 
            // tabControlDish
            // 
            tabControlDish.Controls.Add(tabPageDishList);
            tabControlDish.Controls.Add(tabPageDishAddNew);
            tabControlDish.Dock = DockStyle.Fill;
            tabControlDish.Location = new Point(0, 82);
            tabControlDish.Name = "tabControlDish";
            tabControlDish.SelectedIndex = 0;
            tabControlDish.Size = new Size(806, 469);
            tabControlDish.TabIndex = 4;
            // 
            // tabPageDishList
            // 
            tabPageDishList.BackColor = Color.FromArgb(40, 41, 66);
            tabPageDishList.Controls.Add(btnAddNewDish);
            tabPageDishList.Controls.Add(dataGridViewDish);
            tabPageDishList.Location = new Point(4, 24);
            tabPageDishList.Name = "tabPageDishList";
            tabPageDishList.Padding = new Padding(3);
            tabPageDishList.Size = new Size(798, 441);
            tabPageDishList.TabIndex = 0;
            tabPageDishList.Text = "Lista de Platos";
            // 
            // btnAddNewDish
            // 
            btnAddNewDish.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNewDish.BackColor = Color.FromArgb(56, 58, 89);
            btnAddNewDish.Cursor = Cursors.Hand;
            btnAddNewDish.FlatStyle = FlatStyle.Flat;
            btnAddNewDish.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNewDish.ForeColor = Color.FromArgb(189, 147, 249);
            btnAddNewDish.Location = new Point(651, 18);
            btnAddNewDish.Name = "btnAddNewDish";
            btnAddNewDish.Size = new Size(123, 49);
            btnAddNewDish.TabIndex = 11;
            btnAddNewDish.Text = "Agregar";
            btnAddNewDish.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDish
            // 
            dataGridViewDish.AllowUserToAddRows = false;
            dataGridViewDish.AllowUserToDeleteRows = false;
            dataGridViewDish.AllowUserToResizeRows = false;
            dataGridViewDish.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDish.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDish.BackgroundColor = Color.FromArgb(40, 41, 66);
            dataGridViewDish.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewDish.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDish.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewDish.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDish.GridColor = Color.FromArgb(189, 147, 249);
            dataGridViewDish.Location = new Point(11, 87);
            dataGridViewDish.Name = "dataGridViewDish";
            dataGridViewDish.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(31, 41, 54);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewDish.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewDish.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 41, 66);
            dataGridViewDish.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewDish.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewDish.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewDish.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewDish.RowTemplate.Height = 25;
            dataGridViewDish.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDish.Size = new Size(763, 331);
            dataGridViewDish.TabIndex = 1;
            // 
            // tabPageDishAddNew
            // 
            tabPageDishAddNew.BackColor = Color.FromArgb(40, 41, 66);
            tabPageDishAddNew.Controls.Add(maskedTextBoxPrice);
            tabPageDishAddNew.Controls.Add(btnCancelDish);
            tabPageDishAddNew.Controls.Add(btnSaveDish);
            tabPageDishAddNew.Controls.Add(comboBoxCategory);
            tabPageDishAddNew.Controls.Add(textBoxName);
            tabPageDishAddNew.Controls.Add(label5);
            tabPageDishAddNew.Controls.Add(label3);
            tabPageDishAddNew.Controls.Add(label2);
            tabPageDishAddNew.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageDishAddNew.Location = new Point(4, 24);
            tabPageDishAddNew.Name = "tabPageDishAddNew";
            tabPageDishAddNew.Padding = new Padding(3);
            tabPageDishAddNew.Size = new Size(798, 441);
            tabPageDishAddNew.TabIndex = 1;
            tabPageDishAddNew.Text = "Agregar nuevo";
            // 
            // maskedTextBoxPrice
            // 
            maskedTextBoxPrice.Location = new Point(286, 156);
            maskedTextBoxPrice.Mask = "99999";
            maskedTextBoxPrice.Name = "maskedTextBoxPrice";
            maskedTextBoxPrice.Size = new Size(276, 23);
            maskedTextBoxPrice.TabIndex = 2;
            maskedTextBoxPrice.ValidatingType = typeof(int);
            // 
            // btnCancelDish
            // 
            btnCancelDish.BackColor = Color.FromArgb(56, 58, 89);
            btnCancelDish.Cursor = Cursors.Hand;
            btnCancelDish.FlatStyle = FlatStyle.Flat;
            btnCancelDish.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelDish.ForeColor = Color.FromArgb(189, 147, 249);
            btnCancelDish.Location = new Point(450, 319);
            btnCancelDish.Name = "btnCancelDish";
            btnCancelDish.Size = new Size(112, 36);
            btnCancelDish.TabIndex = 5;
            btnCancelDish.Text = "Cancelar";
            btnCancelDish.UseVisualStyleBackColor = false;
            // 
            // btnSaveDish
            // 
            btnSaveDish.BackColor = Color.FromArgb(56, 58, 89);
            btnSaveDish.Cursor = Cursors.Hand;
            btnSaveDish.FlatStyle = FlatStyle.Flat;
            btnSaveDish.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveDish.ForeColor = Color.FromArgb(189, 147, 249);
            btnSaveDish.Location = new Point(286, 319);
            btnSaveDish.Name = "btnSaveDish";
            btnSaveDish.Size = new Size(112, 36);
            btnSaveDish.TabIndex = 4;
            btnSaveDish.Text = "Guardar";
            btnSaveDish.UseVisualStyleBackColor = false;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.BackColor = Color.FromArgb(36, 49, 60);
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCategory.ForeColor = Color.Gainsboro;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(286, 211);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(275, 25);
            comboBoxCategory.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(287, 101);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(275, 23);
            textBoxName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(189, 147, 249);
            label5.Location = new Point(194, 216);
            label5.Name = "label5";
            label5.Size = new Size(95, 21);
            label5.TabIndex = 3;
            label5.Text = "Categoría:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(189, 147, 249);
            label3.Location = new Point(226, 160);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 1;
            label3.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(189, 147, 249);
            label2.Location = new Point(212, 106);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // DishView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 551);
            Controls.Add(tabControlDish);
            Controls.Add(panel1);
            Name = "DishView";
            Text = "DishView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControlDish.ResumeLayout(false);
            tabPageDishList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDish).EndInit();
            tabPageDishAddNew.ResumeLayout(false);
            tabPageDishAddNew.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControlDish;
        private TabPage tabPageDishList;
        private Button btnAddNewDish;
        private DataGridView dataGridViewDish;
        private TabPage tabPageDishAddNew;
        private MaskedTextBox maskedTextBoxPrice;
        private Button btnCancelDish;
        private Button btnSaveDish;
        private ComboBox comboBoxCategory;
        private TextBox textBoxName;
        private Label label5;
        private Label label3;
        private Label label2;
    }
}