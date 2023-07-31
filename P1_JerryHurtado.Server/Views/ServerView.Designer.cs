namespace P1_JerryHurtado.Server.Views
{
    partial class ServerView
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
            panel1 = new Panel();
            label1 = new Label();
            panelContainer = new Panel();
            groupBoxLogbook = new GroupBox();
            textBoxLogbook = new TextBox();
            groupBoxCustomers = new GroupBox();
            listBoxConnectedCustomers = new ListBox();
            groupBoxStatus = new GroupBox();
            btnStopServer = new Button();
            btnStartServer = new Button();
            labelStatus = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panelContainer.SuspendLayout();
            groupBoxLogbook.SuspendLayout();
            groupBoxCustomers.SuspendLayout();
            groupBoxStatus.SuspendLayout();
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
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(189, 147, 249);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(295, 28);
            label1.TabIndex = 0;
            label1.Text = "Información del servidor";
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(40, 41, 66);
            panelContainer.Controls.Add(groupBoxLogbook);
            panelContainer.Controls.Add(groupBoxCustomers);
            panelContainer.Controls.Add(groupBoxStatus);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 82);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(942, 635);
            panelContainer.TabIndex = 7;
            // 
            // groupBoxLogbook
            // 
            groupBoxLogbook.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBoxLogbook.Controls.Add(textBoxLogbook);
            groupBoxLogbook.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxLogbook.ForeColor = Color.FromArgb(189, 147, 249);
            groupBoxLogbook.Location = new Point(485, 211);
            groupBoxLogbook.Margin = new Padding(4, 3, 4, 3);
            groupBoxLogbook.Name = "groupBoxLogbook";
            groupBoxLogbook.Padding = new Padding(4, 3, 4, 3);
            groupBoxLogbook.Size = new Size(444, 412);
            groupBoxLogbook.TabIndex = 4;
            groupBoxLogbook.TabStop = false;
            groupBoxLogbook.Text = "Bitácora";
            // 
            // textBoxLogbook
            // 
            textBoxLogbook.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxLogbook.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogbook.Location = new Point(63, 37);
            textBoxLogbook.Margin = new Padding(4, 3, 4, 3);
            textBoxLogbook.Multiline = true;
            textBoxLogbook.Name = "textBoxLogbook";
            textBoxLogbook.ReadOnly = true;
            textBoxLogbook.ScrollBars = ScrollBars.Vertical;
            textBoxLogbook.Size = new Size(337, 364);
            textBoxLogbook.TabIndex = 1;
            // 
            // groupBoxCustomers
            // 
            groupBoxCustomers.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxCustomers.Controls.Add(listBoxConnectedCustomers);
            groupBoxCustomers.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxCustomers.ForeColor = Color.FromArgb(189, 147, 249);
            groupBoxCustomers.Location = new Point(27, 211);
            groupBoxCustomers.Margin = new Padding(4, 3, 4, 3);
            groupBoxCustomers.Name = "groupBoxCustomers";
            groupBoxCustomers.Padding = new Padding(4, 3, 4, 3);
            groupBoxCustomers.Size = new Size(422, 412);
            groupBoxCustomers.TabIndex = 3;
            groupBoxCustomers.TabStop = false;
            groupBoxCustomers.Text = "Clientes conectados";
            // 
            // listBoxConnectedCustomers
            // 
            listBoxConnectedCustomers.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxConnectedCustomers.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxConnectedCustomers.FormattingEnabled = true;
            listBoxConnectedCustomers.ItemHeight = 17;
            listBoxConnectedCustomers.Location = new Point(38, 37);
            listBoxConnectedCustomers.Margin = new Padding(4, 3, 4, 3);
            listBoxConnectedCustomers.Name = "listBoxConnectedCustomers";
            listBoxConnectedCustomers.Size = new Size(337, 361);
            listBoxConnectedCustomers.TabIndex = 0;
            // 
            // groupBoxStatus
            // 
            groupBoxStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxStatus.Controls.Add(btnStopServer);
            groupBoxStatus.Controls.Add(btnStartServer);
            groupBoxStatus.Controls.Add(labelStatus);
            groupBoxStatus.Controls.Add(label2);
            groupBoxStatus.Location = new Point(27, 30);
            groupBoxStatus.Margin = new Padding(4, 3, 4, 3);
            groupBoxStatus.Name = "groupBoxStatus";
            groupBoxStatus.Padding = new Padding(4, 3, 4, 3);
            groupBoxStatus.Size = new Size(902, 162);
            groupBoxStatus.TabIndex = 2;
            groupBoxStatus.TabStop = false;
            // 
            // btnStopServer
            // 
            btnStopServer.BackColor = Color.FromArgb(56, 58, 89);
            btnStopServer.Cursor = Cursors.Hand;
            btnStopServer.FlatStyle = FlatStyle.Flat;
            btnStopServer.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnStopServer.ForeColor = Color.FromArgb(189, 147, 249);
            btnStopServer.Location = new Point(157, 97);
            btnStopServer.Name = "btnStopServer";
            btnStopServer.Size = new Size(123, 49);
            btnStopServer.TabIndex = 15;
            btnStopServer.Text = "Detener";
            btnStopServer.UseVisualStyleBackColor = false;
            // 
            // btnStartServer
            // 
            btnStartServer.BackColor = Color.FromArgb(56, 58, 89);
            btnStartServer.Cursor = Cursors.Hand;
            btnStartServer.FlatStyle = FlatStyle.Flat;
            btnStartServer.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartServer.ForeColor = Color.FromArgb(189, 147, 249);
            btnStartServer.Location = new Point(10, 97);
            btnStartServer.Name = "btnStartServer";
            btnStartServer.Size = new Size(123, 49);
            btnStartServer.TabIndex = 14;
            btnStartServer.Text = "Iniciar";
            btnStartServer.UseVisualStyleBackColor = false;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStatus.ForeColor = Color.FromArgb(189, 147, 249);
            labelStatus.Location = new Point(97, 39);
            labelStatus.Margin = new Padding(4, 0, 4, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(88, 21);
            labelStatus.TabIndex = 1;
            labelStatus.Text = "Apagado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(189, 147, 249);
            label2.Location = new Point(9, 37);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 0;
            label2.Text = "Estado:";
            // 
            // ServerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 717);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            Name = "ServerView";
            Text = "ServerView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelContainer.ResumeLayout(false);
            groupBoxLogbook.ResumeLayout(false);
            groupBoxLogbook.PerformLayout();
            groupBoxCustomers.ResumeLayout(false);
            groupBoxStatus.ResumeLayout(false);
            groupBoxStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panelContainer;
        private GroupBox groupBoxStatus;
        private Label labelStatus;
        private Label label2;
        private Button btnStopServer;
        private Button btnStartServer;
        private GroupBox groupBoxCustomers;
        private ListBox listBoxConnectedCustomers;
        private GroupBox groupBoxLogbook;
        private TextBox textBoxLogbook;
    }
}