namespace proyecto_colegio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 336);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.WindowText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.DimGray;
            textBox1.Location = new Point(306, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(432, 19);
            textBox1.TabIndex = 5;
            textBox1.Text = "USUARIO";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaptionText;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.DimGray;
            textBox2.Location = new Point(306, 197);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(432, 19);
            textBox2.TabIndex = 6;
            textBox2.Text = "CONTRASEÑA";
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(422, 139);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 4;
            label1.Text = "INICIAR SECCIÓN";
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Navy;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(306, 238);
            button1.Name = "button1";
            button1.Size = new Size(359, 40);
            button1.TabIndex = 5;
            button1.Text = "ACCEDER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(652, 24);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 1;
            textBox3.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(706, 336);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Opacity = 0.9D;
            RightToLeft = RightToLeft.No;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button button1;
        private TextBox textBox3;
    }
}
