namespace P1_JerryHurtado.Server.Views
{
    partial class UserControlMainView
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            topPanel = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            bottomPanel = new Panel();
            label2 = new Label();
            label3 = new Label();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            bottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(40, 41, 66);
            topPanel.Controls.Add(label1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1043, 61);
            topPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(189, 147, 249);
            label1.Location = new Point(336, 11);
            label1.Name = "label1";
            label1.Size = new Size(335, 41);
            label1.TabIndex = 0;
            label1.Text = "Servidor REST UNED";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(40, 41, 66);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.main_view;
            pictureBox1.Location = new Point(0, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1043, 592);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.FromArgb(40, 41, 66);
            bottomPanel.Controls.Add(label3);
            bottomPanel.Controls.Add(label2);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 607);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(1043, 46);
            bottomPanel.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(189, 147, 249);
            label2.Location = new Point(759, -36);
            label2.Name = "label2";
            label2.Size = new Size(306, 19);
            label2.TabIndex = 1;
            label2.Text = "Desarrollado por Jerry Hurtado © 2023.";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(189, 147, 249);
            label3.Location = new Point(368, 14);
            label3.Name = "label3";
            label3.Size = new Size(306, 19);
            label3.TabIndex = 2;
            label3.Text = "Desarrollado por Jerry Hurtado © 2023.";
            // 
            // UserControlMainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bottomPanel);
            Controls.Add(pictureBox1);
            Controls.Add(topPanel);
            Name = "UserControlMainView";
            Size = new Size(1043, 653);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel bottomPanel;
        private Label label3;
        private Label label2;
    }
}
