namespace P1_JerryHurtado.Server.Views
{
    partial class CustomerView
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
            tabControlCustomer = new TabControl();
            tabPageCustomerAddNew = new TabPage();
            label6 = new Label();
            dateTimePickerBirthDate = new DateTimePicker();
            textBoxLastSurname = new TextBox();
            label4 = new Label();
            textBoxFirstSurname = new TextBox();
            btnCancelCustomer = new Button();
            btnSaveCustomer = new Button();
            comboBoxGender = new ComboBox();
            textBoxName = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPageCustomerList = new TabPage();
            btnAddNewCustomer = new Button();
            dataGridViewCustomers = new DataGridView();
            textBoxClientId = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            tabControlCustomer.SuspendLayout();
            tabPageCustomerAddNew.SuspendLayout();
            tabPageCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
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
            label1.Size = new Size(105, 28);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // tabControlCustomer
            // 
            tabControlCustomer.Controls.Add(tabPageCustomerAddNew);
            tabControlCustomer.Controls.Add(tabPageCustomerList);
            tabControlCustomer.Dock = DockStyle.Fill;
            tabControlCustomer.Location = new Point(0, 82);
            tabControlCustomer.Name = "tabControlCustomer";
            tabControlCustomer.SelectedIndex = 0;
            tabControlCustomer.Size = new Size(806, 469);
            tabControlCustomer.TabIndex = 9;
            // 
            // tabPageCustomerAddNew
            // 
            tabPageCustomerAddNew.BackColor = Color.FromArgb(40, 41, 66);
            tabPageCustomerAddNew.Controls.Add(textBoxClientId);
            tabPageCustomerAddNew.Controls.Add(label7);
            tabPageCustomerAddNew.Controls.Add(label6);
            tabPageCustomerAddNew.Controls.Add(dateTimePickerBirthDate);
            tabPageCustomerAddNew.Controls.Add(textBoxLastSurname);
            tabPageCustomerAddNew.Controls.Add(label4);
            tabPageCustomerAddNew.Controls.Add(textBoxFirstSurname);
            tabPageCustomerAddNew.Controls.Add(btnCancelCustomer);
            tabPageCustomerAddNew.Controls.Add(btnSaveCustomer);
            tabPageCustomerAddNew.Controls.Add(comboBoxGender);
            tabPageCustomerAddNew.Controls.Add(textBoxName);
            tabPageCustomerAddNew.Controls.Add(label5);
            tabPageCustomerAddNew.Controls.Add(label3);
            tabPageCustomerAddNew.Controls.Add(label2);
            tabPageCustomerAddNew.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageCustomerAddNew.Location = new Point(4, 24);
            tabPageCustomerAddNew.Name = "tabPageCustomerAddNew";
            tabPageCustomerAddNew.Padding = new Padding(3);
            tabPageCustomerAddNew.Size = new Size(798, 441);
            tabPageCustomerAddNew.TabIndex = 1;
            tabPageCustomerAddNew.Text = "Agregar nuevo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(189, 147, 249);
            label6.Location = new Point(106, 283);
            label6.Name = "label6";
            label6.Size = new Size(181, 21);
            label6.TabIndex = 14;
            label6.Text = "Fecha de nacimiento:";
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Location = new Point(304, 279);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(275, 23);
            dateTimePickerBirthDate.TabIndex = 6;
            // 
            // textBoxLastSurname
            // 
            textBoxLastSurname.Location = new Point(304, 183);
            textBoxLastSurname.Name = "textBoxLastSurname";
            textBoxLastSurname.Size = new Size(275, 23);
            textBoxLastSurname.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(189, 147, 249);
            label4.Location = new Point(137, 188);
            label4.Name = "label4";
            label4.Size = new Size(150, 21);
            label4.TabIndex = 11;
            label4.Text = "Segundo apellido:";
            // 
            // textBoxFirstSurname
            // 
            textBoxFirstSurname.Location = new Point(304, 136);
            textBoxFirstSurname.Name = "textBoxFirstSurname";
            textBoxFirstSurname.Size = new Size(275, 23);
            textBoxFirstSurname.TabIndex = 3;
            // 
            // btnCancelCustomer
            // 
            btnCancelCustomer.BackColor = Color.FromArgb(56, 58, 89);
            btnCancelCustomer.Cursor = Cursors.Hand;
            btnCancelCustomer.FlatStyle = FlatStyle.Flat;
            btnCancelCustomer.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelCustomer.ForeColor = Color.FromArgb(189, 147, 249);
            btnCancelCustomer.Location = new Point(463, 335);
            btnCancelCustomer.Name = "btnCancelCustomer";
            btnCancelCustomer.Size = new Size(112, 36);
            btnCancelCustomer.TabIndex = 8;
            btnCancelCustomer.Text = "Cancelar";
            btnCancelCustomer.UseVisualStyleBackColor = false;
            // 
            // btnSaveCustomer
            // 
            btnSaveCustomer.BackColor = Color.FromArgb(56, 58, 89);
            btnSaveCustomer.Cursor = Cursors.Hand;
            btnSaveCustomer.FlatStyle = FlatStyle.Flat;
            btnSaveCustomer.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveCustomer.ForeColor = Color.FromArgb(189, 147, 249);
            btnSaveCustomer.Location = new Point(308, 335);
            btnSaveCustomer.Name = "btnSaveCustomer";
            btnSaveCustomer.Size = new Size(112, 36);
            btnSaveCustomer.TabIndex = 7;
            btnSaveCustomer.Text = "Guardar";
            btnSaveCustomer.UseVisualStyleBackColor = false;
            // 
            // comboBoxGender
            // 
            comboBoxGender.BackColor = Color.FromArgb(36, 49, 60);
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxGender.ForeColor = Color.Gainsboro;
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(304, 230);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(275, 25);
            comboBoxGender.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(305, 89);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(275, 23);
            textBoxName.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(189, 147, 249);
            label5.Location = new Point(214, 237);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 3;
            label5.Text = "Género:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(189, 147, 249);
            label3.Location = new Point(160, 141);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 1;
            label3.Text = "Primer apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(189, 147, 249);
            label2.Location = new Point(210, 94);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // tabPageCustomerList
            // 
            tabPageCustomerList.BackColor = Color.FromArgb(40, 41, 66);
            tabPageCustomerList.Controls.Add(btnAddNewCustomer);
            tabPageCustomerList.Controls.Add(dataGridViewCustomers);
            tabPageCustomerList.Location = new Point(4, 24);
            tabPageCustomerList.Name = "tabPageCustomerList";
            tabPageCustomerList.Padding = new Padding(3);
            tabPageCustomerList.Size = new Size(798, 441);
            tabPageCustomerList.TabIndex = 0;
            tabPageCustomerList.Text = "Lista de Clientes";
            // 
            // btnAddNewCustomer
            // 
            btnAddNewCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNewCustomer.BackColor = Color.FromArgb(56, 58, 89);
            btnAddNewCustomer.Cursor = Cursors.Hand;
            btnAddNewCustomer.FlatStyle = FlatStyle.Flat;
            btnAddNewCustomer.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNewCustomer.ForeColor = Color.FromArgb(189, 147, 249);
            btnAddNewCustomer.Location = new Point(652, 18);
            btnAddNewCustomer.Name = "btnAddNewCustomer";
            btnAddNewCustomer.Size = new Size(123, 49);
            btnAddNewCustomer.TabIndex = 12;
            btnAddNewCustomer.Text = "Agregar";
            btnAddNewCustomer.UseVisualStyleBackColor = false;
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.AllowUserToAddRows = false;
            dataGridViewCustomers.AllowUserToDeleteRows = false;
            dataGridViewCustomers.AllowUserToResizeRows = false;
            dataGridViewCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCustomers.BackgroundColor = Color.FromArgb(40, 41, 66);
            dataGridViewCustomers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCustomers.GridColor = Color.FromArgb(189, 147, 249);
            dataGridViewCustomers.Location = new Point(8, 83);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(31, 41, 54);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCustomers.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 41, 66);
            dataGridViewCustomers.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCustomers.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(189, 147, 249);
            dataGridViewCustomers.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(56, 58, 89);
            dataGridViewCustomers.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewCustomers.RowTemplate.Height = 25;
            dataGridViewCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCustomers.Size = new Size(782, 337);
            dataGridViewCustomers.TabIndex = 1;
            // 
            // textBoxClientId
            // 
            textBoxClientId.Location = new Point(305, 47);
            textBoxClientId.Name = "textBoxClientId";
            textBoxClientId.Size = new Size(275, 23);
            textBoxClientId.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(189, 147, 249);
            label7.Location = new Point(257, 49);
            label7.Name = "label7";
            label7.Size = new Size(30, 21);
            label7.TabIndex = 15;
            label7.Text = "Id:";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 551);
            Controls.Add(tabControlCustomer);
            Controls.Add(panel1);
            Name = "CustomerView";
            Text = "CustomerView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControlCustomer.ResumeLayout(false);
            tabPageCustomerAddNew.ResumeLayout(false);
            tabPageCustomerAddNew.PerformLayout();
            tabPageCustomerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControlCustomer;
        private TabPage tabPageCustomerAddNew;
        private TextBox textBoxClientId;
        private Label label7;
        private Label label6;
        private DateTimePicker dateTimePickerBirthDate;
        private TextBox textBoxLastSurname;
        private Label label4;
        private TextBox textBoxFirstSurname;
        private Button btnCancelCustomer;
        private Button btnSaveCustomer;
        private ComboBox comboBoxGender;
        private TextBox textBoxName;
        private Label label5;
        private Label label3;
        private Label label2;
        private TabPage tabPageCustomerList;
        private Button btnAddNewCustomer;
        private DataGridView dataGridViewCustomers;
    }
}