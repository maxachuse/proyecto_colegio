namespace proyecto_colegio
{
    partial class FrmOpcionesDeAministracion
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(703, 214);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 222);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(703, 223);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(257, 101);
            button1.Name = "button1";
            button1.Size = new Size(208, 29);
            button1.TabIndex = 2;
            button1.Text = "Administrar Estudiante";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(244, 312);
            button2.Name = "button2";
            button2.Size = new Size(221, 29);
            button2.TabIndex = 3;
            button2.Text = "Administrar Personal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmOpcionesDeAministracion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "FrmOpcionesDeAministracion";
            Text = "FrmOpcionesDeAministracion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
    }
}