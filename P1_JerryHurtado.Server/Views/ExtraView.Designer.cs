namespace P1_JerryHurtado.Server.Views
{
    partial class ExtraView
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
            tabControlExtras = new TabControl();
            tabPageExtasList = new TabPage();
            btnAddNewExtras = new Button();
            dataGridViewExtras = new DataGridView();
            tabPageAddNewExtras = new TabPage();
            comboBoxStatus = new ComboBox();
            label4 = new Label();
            maskedTextBoxPrice = new MaskedTextBox();
            btnCancelExtras = new Button();
            btnSaveExtras = new Button();
            comboBoxCategory = new ComboBox();
            textBoxDescription = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            tabControlExtras.SuspendLayout();
            tabPageExtasList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExtras).BeginInit();
            tabPageAddNewExtras.SuspendLayout();
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
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(189, 147, 249);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 0;
            label1.Text = "Extras";
            // 
            // tabControlExtras
            // 
            tabControlExtras.Controls.Add(tabPageExtasList);
            tabControlExtras.Controls.Add(tabPageAddNewExtras);
            tabControlExtras.Dock = DockStyle.Fill;
            tabControlExtras.Location = new Point(0, 82);
            tabControlExtras.Name = "tabControlExtras";
            tabControlExtras.SelectedIndex = 0;
            tabControlExtras.Size = new Size(806, 469);
            tabControlExtras.TabIndex = 5;
            // 
            // tabPageExtasList
            // 
            tabPageExtasList.BackColor = Color.FromArgb(40, 41, 66);
            tabPageExtasList.Controls.Add(btnAddNewExtras);
            tabPageExtasList.Controls.Add(dataGridViewExtras);
            tabPageExtasList.Location = new Point(4, 24);
            tabPageExtasList.Name = "tabPageExtasList";
            tabPageExtasList.Padding = new Padding(3);
            tabPageExtasList.Size = new Size(798, 441);
            tabPageExtasList.TabIndex = 0;
            tabPageExtasList.Text = "Lista de Extras";
            // 
            // btnAddNewExtras
            // 
            btnAddNewExtras.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNewExtras.BackColor = Color.FromArgb(56, 58, 89);
            btnAddNewExtras.Cursor = Cursors.Hand;
            btnAddNewExtras.FlatStyle = FlatStyle.Flat;
            btnAddNewExtras.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNewExtras.ForeColor = Color.FromArgb(189, 147, 249);
            btnAddNewExtras.Location = new Point(656, 20);
            btnAddNewExtras.Name = "btnAddNewExtras";
            btnAddNewExtras.Size = new Size(123, 49);
            btnAddNewExtras.TabIndex = 12;
            btnAddNewExtras.Text = "Agregar";
            btnAddNewExtras.UseVisualStyleBackColor = false;
            // 
            // dataGridViewExtras
            // 
            dataGridViewExtras.AllowUserToAddRows = false;
            dataGridViewExtras.AllowUserToDeleteRows = false;
            dataGridViewExtras.AllowUserToResizeRows = false;
            dataGridViewExtras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewExtras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewExtras.BackgroundColor = Color.FromArgb(40, 41, 66);
            dataGridViewExtras.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewExtras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewExtras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewExtras.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewExtras.GridColor = Color.FromArgb(189, 147, 249);
            dataGridViewExtras.Location = new Point(6, 86);
            dataGridViewExtras.Name = "dataGridViewExtras";
            dataGridViewExtras.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(31, 41, 54);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewExtras.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewExtras.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 41, 66);
            dataGridViewExtras.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewExtras.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewExtras.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewExtras.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewExtras.RowTemplate.Height = 25;
            dataGridViewExtras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewExtras.Size = new Size(782, 317);
            dataGridViewExtras.TabIndex = 1;
            // 
            // tabPageAddNewExtras
            // 
            tabPageAddNewExtras.BackColor = Color.FromArgb(40, 41, 66);
            tabPageAddNewExtras.Controls.Add(comboBoxStatus);
            tabPageAddNewExtras.Controls.Add(label4);
            tabPageAddNewExtras.Controls.Add(maskedTextBoxPrice);
            tabPageAddNewExtras.Controls.Add(btnCancelExtras);
            tabPageAddNewExtras.Controls.Add(btnSaveExtras);
            tabPageAddNewExtras.Controls.Add(comboBoxCategory);
            tabPageAddNewExtras.Controls.Add(textBoxDescription);
            tabPageAddNewExtras.Controls.Add(label5);
            tabPageAddNewExtras.Controls.Add(label3);
            tabPageAddNewExtras.Controls.Add(label2);
            tabPageAddNewExtras.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageAddNewExtras.Location = new Point(4, 24);
            tabPageAddNewExtras.Name = "tabPageAddNewExtras";
            tabPageAddNewExtras.Padding = new Padding(3);
            tabPageAddNewExtras.Size = new Size(798, 441);
            tabPageAddNewExtras.TabIndex = 1;
            tabPageAddNewExtras.Text = "Agregar nuevo";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.BackColor = Color.FromArgb(36, 49, 60);
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStatus.ForeColor = Color.Gainsboro;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(286, 253);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(275, 25);
            comboBoxStatus.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(189, 147, 249);
            label4.Location = new Point(215, 257);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 7;
            label4.Text = "Estado:";
            // 
            // maskedTextBoxPrice
            // 
            maskedTextBoxPrice.Location = new Point(286, 151);
            maskedTextBoxPrice.Mask = "99999";
            maskedTextBoxPrice.Name = "maskedTextBoxPrice";
            maskedTextBoxPrice.Size = new Size(276, 23);
            maskedTextBoxPrice.TabIndex = 2;
            maskedTextBoxPrice.ValidatingType = typeof(int);
            // 
            // btnCancelExtras
            // 
            btnCancelExtras.BackColor = Color.FromArgb(56, 58, 89);
            btnCancelExtras.Cursor = Cursors.Hand;
            btnCancelExtras.FlatStyle = FlatStyle.Flat;
            btnCancelExtras.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelExtras.ForeColor = Color.FromArgb(189, 147, 249);
            btnCancelExtras.Location = new Point(450, 319);
            btnCancelExtras.Name = "btnCancelExtras";
            btnCancelExtras.Size = new Size(112, 36);
            btnCancelExtras.TabIndex = 6;
            btnCancelExtras.Text = "Cancelar";
            btnCancelExtras.UseVisualStyleBackColor = false;
            // 
            // btnSaveExtras
            // 
            btnSaveExtras.BackColor = Color.FromArgb(56, 58, 89);
            btnSaveExtras.Cursor = Cursors.Hand;
            btnSaveExtras.FlatStyle = FlatStyle.Flat;
            btnSaveExtras.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveExtras.ForeColor = Color.FromArgb(189, 147, 249);
            btnSaveExtras.Location = new Point(286, 319);
            btnSaveExtras.Name = "btnSaveExtras";
            btnSaveExtras.Size = new Size(112, 36);
            btnSaveExtras.TabIndex = 5;
            btnSaveExtras.Text = "Guardar";
            btnSaveExtras.UseVisualStyleBackColor = false;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.BackColor = Color.FromArgb(36, 49, 60);
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCategory.ForeColor = Color.Gainsboro;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(286, 201);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(275, 25);
            comboBoxCategory.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(287, 52);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(275, 72);
            textBoxDescription.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(189, 147, 249);
            label5.Location = new Point(193, 208);
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
            label3.Location = new Point(229, 154);
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
            label2.Location = new Point(184, 53);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 0;
            label2.Text = "Descripción:";
            // 
            // ExtraView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 551);
            Controls.Add(tabControlExtras);
            Controls.Add(panel1);
            Name = "ExtraView";
            Text = "ExtraView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControlExtras.ResumeLayout(false);
            tabPageExtasList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewExtras).EndInit();
            tabPageAddNewExtras.ResumeLayout(false);
            tabPageAddNewExtras.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControlExtras;
        private TabPage tabPageExtasList;
        private Button btnAddNewExtras;
        private DataGridView dataGridViewExtras;
        private TabPage tabPageAddNewExtras;
        private ComboBox comboBoxStatus;
        private Label label4;
        private MaskedTextBox maskedTextBoxPrice;
        private Button btnCancelExtras;
        private Button btnSaveExtras;
        private ComboBox comboBoxCategory;
        private TextBox textBoxDescription;
        private Label label5;
        private Label label3;
        private Label label2;
    }
}