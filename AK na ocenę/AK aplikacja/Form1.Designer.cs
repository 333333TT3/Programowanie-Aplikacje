namespace AK_aplikacja
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
            Konto = new Label();
            mail = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Konto
            // 
            Konto.BackColor = Color.Teal;
            Konto.Dock = DockStyle.Top;
            Konto.Font = new Font("Microsoft Sans Serif", 20F);
            Konto.ForeColor = Color.White;
            Konto.Location = new Point(0, 0);
            Konto.Name = "Konto";
            Konto.Size = new Size(398, 44);
            Konto.TabIndex = 0;
            Konto.Text = "Rejestruj konto";
            Konto.Click += label1_Click;
            // 
            // mail
            // 
            mail.Font = new Font("Segoe UI", 15F);
            mail.Location = new Point(0, 44);
            mail.Name = "mail";
            mail.Size = new Size(398, 27);
            mail.TabIndex = 1;
            mail.Text = "Podaj e-mail";
            mail.TextAlign = ContentAlignment.MiddleLeft;
            mail.Click += mail_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(0, 140);
            label1.Name = "label1";
            label1.Size = new Size(398, 27);
            label1.TabIndex = 2;
            label1.Text = "Podaj hasło";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(0, 254);
            label2.Name = "label2";
            label2.Size = new Size(398, 27);
            label2.TabIndex = 3;
            label2.Text = "Powtórz hasło";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(398, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(398, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(0, 302);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(398, 23);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(118, 385);
            button1.Name = "button1";
            button1.Size = new Size(139, 49);
            button1.TabIndex = 7;
            button1.Text = "ZATWIERDŹ";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 613);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mail);
            Controls.Add(Konto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Konto;
        private Label mail;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
    }
}
