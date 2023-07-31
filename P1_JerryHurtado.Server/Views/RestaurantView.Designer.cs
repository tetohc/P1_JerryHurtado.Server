namespace P1_JerryHurtado.Server.Views
{
    partial class RestaurantView
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
            tabControlRestaurant = new TabControl();
            tabPageRestaurantList = new TabPage();
            dataGridViewRestaurant = new DataGridView();
            btnAddNewRestaurant = new Button();
            tabPageRestaurantAddNew = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            maskedTextBoxPhone = new MaskedTextBox();
            comboBoxStatus = new ComboBox();
            textBoxAddress = new TextBox();
            textBoxName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            tabControlRestaurant.SuspendLayout();
            tabPageRestaurantList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRestaurant).BeginInit();
            tabPageRestaurantAddNew.SuspendLayout();
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
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(189, 147, 249);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 0;
            label1.Text = "Restaurantes";
            // 
            // tabControlRestaurant
            // 
            tabControlRestaurant.Controls.Add(tabPageRestaurantList);
            tabControlRestaurant.Controls.Add(tabPageRestaurantAddNew);
            tabControlRestaurant.Dock = DockStyle.Fill;
            tabControlRestaurant.Location = new Point(0, 82);
            tabControlRestaurant.Name = "tabControlRestaurant";
            tabControlRestaurant.SelectedIndex = 0;
            tabControlRestaurant.Size = new Size(806, 469);
            tabControlRestaurant.TabIndex = 2;
            // 
            // tabPageRestaurantList
            // 
            tabPageRestaurantList.BackColor = Color.FromArgb(40, 41, 66);
            tabPageRestaurantList.Controls.Add(dataGridViewRestaurant);
            tabPageRestaurantList.Controls.Add(btnAddNewRestaurant);
            tabPageRestaurantList.Location = new Point(4, 24);
            tabPageRestaurantList.Name = "tabPageRestaurantList";
            tabPageRestaurantList.Padding = new Padding(3);
            tabPageRestaurantList.Size = new Size(798, 441);
            tabPageRestaurantList.TabIndex = 0;
            tabPageRestaurantList.Text = "Lista de Restaurantes";
            // 
            // dataGridViewRestaurant
            // 
            dataGridViewRestaurant.AllowUserToAddRows = false;
            dataGridViewRestaurant.AllowUserToDeleteRows = false;
            dataGridViewRestaurant.AllowUserToResizeRows = false;
            dataGridViewRestaurant.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRestaurant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewRestaurant.BackgroundColor = Color.FromArgb(40, 41, 66);
            dataGridViewRestaurant.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewRestaurant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRestaurant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewRestaurant.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewRestaurant.GridColor = Color.FromArgb(189, 147, 249);
            dataGridViewRestaurant.Location = new Point(11, 92);
            dataGridViewRestaurant.Name = "dataGridViewRestaurant";
            dataGridViewRestaurant.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(31, 41, 54);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewRestaurant.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewRestaurant.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 41, 66);
            dataGridViewRestaurant.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewRestaurant.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewRestaurant.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewRestaurant.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewRestaurant.RowTemplate.Height = 25;
            dataGridViewRestaurant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRestaurant.Size = new Size(759, 341);
            dataGridViewRestaurant.TabIndex = 10;
            // 
            // btnAddNewRestaurant
            // 
            btnAddNewRestaurant.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNewRestaurant.BackColor = Color.FromArgb(56, 58, 89);
            btnAddNewRestaurant.Cursor = Cursors.Hand;
            btnAddNewRestaurant.FlatStyle = FlatStyle.Flat;
            btnAddNewRestaurant.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNewRestaurant.ForeColor = Color.FromArgb(189, 147, 249);
            btnAddNewRestaurant.Location = new Point(647, 20);
            btnAddNewRestaurant.Name = "btnAddNewRestaurant";
            btnAddNewRestaurant.Size = new Size(123, 49);
            btnAddNewRestaurant.TabIndex = 9;
            btnAddNewRestaurant.Text = "Agregar";
            btnAddNewRestaurant.UseVisualStyleBackColor = false;
            // 
            // tabPageRestaurantAddNew
            // 
            tabPageRestaurantAddNew.BackColor = Color.FromArgb(40, 41, 66);
            tabPageRestaurantAddNew.Controls.Add(btnCancel);
            tabPageRestaurantAddNew.Controls.Add(btnSave);
            tabPageRestaurantAddNew.Controls.Add(maskedTextBoxPhone);
            tabPageRestaurantAddNew.Controls.Add(comboBoxStatus);
            tabPageRestaurantAddNew.Controls.Add(textBoxAddress);
            tabPageRestaurantAddNew.Controls.Add(textBoxName);
            tabPageRestaurantAddNew.Controls.Add(label5);
            tabPageRestaurantAddNew.Controls.Add(label4);
            tabPageRestaurantAddNew.Controls.Add(label3);
            tabPageRestaurantAddNew.Controls.Add(label2);
            tabPageRestaurantAddNew.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageRestaurantAddNew.Location = new Point(4, 24);
            tabPageRestaurantAddNew.Name = "tabPageRestaurantAddNew";
            tabPageRestaurantAddNew.Padding = new Padding(3);
            tabPageRestaurantAddNew.Size = new Size(798, 441);
            tabPageRestaurantAddNew.TabIndex = 1;
            tabPageRestaurantAddNew.Text = "Agregar nuevo";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(56, 58, 89);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(189, 147, 249);
            btnCancel.Location = new Point(450, 358);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 36);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(56, 58, 89);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.FromArgb(189, 147, 249);
            btnSave.Location = new Point(286, 358);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 36);
            btnSave.TabIndex = 8;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Location = new Point(286, 277);
            maskedTextBoxPhone.Mask = "0000-00-00";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(276, 23);
            maskedTextBoxPhone.TabIndex = 7;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.BackColor = Color.FromArgb(36, 49, 60);
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStatus.ForeColor = Color.Gainsboro;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(287, 233);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(275, 25);
            comboBoxStatus.TabIndex = 6;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(286, 104);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(276, 107);
            textBoxAddress.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(287, 50);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(275, 23);
            textBoxName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(189, 147, 249);
            label5.Location = new Point(206, 234);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 3;
            label5.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(189, 147, 249);
            label4.Location = new Point(195, 282);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 2;
            label4.Text = "Teléfono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(189, 147, 249);
            label3.Location = new Point(196, 105);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 1;
            label3.Text = "Dirección:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(189, 147, 249);
            label2.Location = new Point(206, 51);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // RestaurantView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 551);
            Controls.Add(tabControlRestaurant);
            Controls.Add(panel1);
            Name = "RestaurantView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RestaurantView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControlRestaurant.ResumeLayout(false);
            tabPageRestaurantList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRestaurant).EndInit();
            tabPageRestaurantAddNew.ResumeLayout(false);
            tabPageRestaurantAddNew.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControlRestaurant;
        private TabPage tabPageRestaurantList;
        private DataGridView dataGridViewRestaurant;
        private Button btnAddNewRestaurant;
        private TabPage tabPageRestaurantAddNew;
        private Button btnCancel;
        private Button btnSave;
        private MaskedTextBox maskedTextBoxPhone;
        private ComboBox comboBoxStatus;
        private TextBox textBoxAddress;
        private TextBox textBoxName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}