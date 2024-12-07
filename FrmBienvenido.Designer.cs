namespace proyecto_colegio
{
    partial class FrmBienvenido
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("BankGothic Lt BT", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 92);
            label1.Name = "label1";
            label1.Size = new Size(516, 46);
            label1.TabIndex = 2;
            label1.Text = "BIENVENIDO SEÑOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("BankGothic Lt BT", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(313, 138);
            label2.Name = "label2";
            label2.Size = new Size(284, 49);
            label2.TabIndex = 3;
            label2.Text = "DIRECTOR";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(231, 215);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(467, 37);
            progressBar1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 277);
            label3.Name = "label3";
            label3.Size = new Size(203, 20);
            label3.TabIndex = 5;
            label3.Text = "espere un momento porfavor";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Tick += timer2_Tick;
            // 
            // FrmBienvenido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 340);
            Controls.Add(label3);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmBienvenido";
            Text = "FrmBienvenido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private ProgressBar progressBar1;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}