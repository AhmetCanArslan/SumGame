namespace SumGame
{
    partial class Form2
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
            progressBar1 = new ProgressBar();
            lblSayi1 = new Label();
            lblIslem = new Label();
            lblSayi2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            lblTrue = new Label();
            label3 = new Label();
            label4 = new Label();
            lblFalse = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 289);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(585, 29);
            progressBar1.TabIndex = 0;
            // 
            // lblSayi1
            // 
            lblSayi1.AutoSize = true;
            lblSayi1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSayi1.Location = new Point(12, 207);
            lblSayi1.Name = "lblSayi1";
            lblSayi1.Size = new Size(117, 57);
            lblSayi1.TabIndex = 1;
            lblSayi1.Text = "sayi1";
            lblSayi1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIslem
            // 
            lblIslem.AutoSize = true;
            lblIslem.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblIslem.Location = new Point(135, 207);
            lblIslem.Name = "lblIslem";
            lblIslem.Size = new Size(121, 57);
            lblIslem.TabIndex = 2;
            lblIslem.Text = "islem";
            lblIslem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSayi2
            // 
            lblSayi2.AutoSize = true;
            lblSayi2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSayi2.Location = new Point(277, 207);
            lblSayi2.Name = "lblSayi2";
            lblSayi2.Size = new Size(117, 57);
            lblSayi2.TabIndex = 3;
            lblSayi2.Text = "sayi2";
            lblSayi2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(400, 207);
            label1.Name = "label1";
            label1.Size = new Size(54, 57);
            label1.TabIndex = 4;
            label1.Text = "=";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(460, 204);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 63);
            textBox1.TabIndex = 5;
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // lblTrue
            // 
            lblTrue.AutoSize = true;
            lblTrue.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTrue.Location = new Point(460, 9);
            lblTrue.Name = "lblTrue";
            lblTrue.Size = new Size(48, 57);
            lblTrue.TabIndex = 6;
            lblTrue.Text = "0";
            lblTrue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(264, 57);
            label3.TabIndex = 7;
            label3.Text = "True answers";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 83);
            label4.Name = "label4";
            label4.Size = new Size(276, 57);
            label4.TabIndex = 8;
            label4.Text = "False answers";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFalse
            // 
            lblFalse.AutoSize = true;
            lblFalse.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFalse.Location = new Point(460, 83);
            lblFalse.Name = "lblFalse";
            lblFalse.Size = new Size(48, 57);
            lblFalse.TabIndex = 9;
            lblFalse.Text = "0";
            lblFalse.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 330);
            Controls.Add(lblFalse);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblTrue);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lblSayi2);
            Controls.Add(lblIslem);
            Controls.Add(lblSayi1);
            Controls.Add(progressBar1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label lblSayi1;
        private Label lblIslem;
        private Label lblSayi2;
        private Label label1;
        private TextBox textBox1;
        private Label lblTrue;
        private Label label3;
        private Label label4;
        private Label lblFalse;
    }
}