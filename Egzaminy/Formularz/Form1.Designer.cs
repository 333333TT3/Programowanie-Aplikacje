namespace Formularz
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
            worker_data = new GroupBox();
            name_box = new TextBox();
            secName_box = new TextBox();
            job_select = new ComboBox();
            Job = new Label();
            sec_name = new Label();
            name = new Label();
            pass_generator = new GroupBox();
            special = new CheckBox();
            generate = new Button();
            type_pass = new TextBox();
            digits = new CheckBox();
            characters = new CheckBox();
            signs = new Label();
            alter = new Button();
            worker_data.SuspendLayout();
            pass_generator.SuspendLayout();
            SuspendLayout();
            // 
            // worker_data
            // 
            worker_data.Controls.Add(name_box);
            worker_data.Controls.Add(secName_box);
            worker_data.Controls.Add(job_select);
            worker_data.Controls.Add(Job);
            worker_data.Controls.Add(sec_name);
            worker_data.Controls.Add(name);
            worker_data.Location = new Point(31, 118);
            worker_data.Name = "worker_data";
            worker_data.Size = new Size(332, 205);
            worker_data.TabIndex = 0;
            worker_data.TabStop = false;
            worker_data.Text = "Dane Pracownika";
            // 
            // name_box
            // 
            name_box.Location = new Point(167, 44);
            name_box.Name = "name_box";
            name_box.Size = new Size(100, 23);
            name_box.TabIndex = 5;
            // 
            // secName_box
            // 
            secName_box.Location = new Point(167, 97);
            secName_box.Name = "secName_box";
            secName_box.Size = new Size(100, 23);
            secName_box.TabIndex = 4;
            // 
            // job_select
            // 
            job_select.FormattingEnabled = true;
            job_select.Items.AddRange(new object[] { "Asystent", "Kierownik", "Starszy Programista", "Młodszy Programista" });
            job_select.Location = new Point(156, 153);
            job_select.Name = "job_select";
            job_select.Size = new Size(121, 23);
            job_select.TabIndex = 3;
            // 
            // Job
            // 
            Job.Location = new Point(37, 156);
            Job.Name = "Job";
            Job.Size = new Size(74, 15);
            Job.TabIndex = 2;
            Job.Text = "Stanowisko";
            // 
            // sec_name
            // 
            sec_name.AutoSize = true;
            sec_name.Location = new Point(37, 100);
            sec_name.Name = "sec_name";
            sec_name.Size = new Size(57, 15);
            sec_name.TabIndex = 1;
            sec_name.Text = "Nazwisko";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(37, 52);
            name.Name = "name";
            name.Size = new Size(30, 15);
            name.TabIndex = 0;
            name.Text = "Imię";
            // 
            // pass_generator
            // 
            pass_generator.Controls.Add(special);
            pass_generator.Controls.Add(generate);
            pass_generator.Controls.Add(type_pass);
            pass_generator.Controls.Add(digits);
            pass_generator.Controls.Add(characters);
            pass_generator.Controls.Add(signs);
            pass_generator.Location = new Point(421, 118);
            pass_generator.Name = "pass_generator";
            pass_generator.Size = new Size(332, 205);
            pass_generator.TabIndex = 1;
            pass_generator.TabStop = false;
            pass_generator.Text = "Generator Hasła";
            // 
            // special
            // 
            special.AutoSize = true;
            special.Location = new Point(43, 140);
            special.Name = "special";
            special.Size = new Size(108, 19);
            special.TabIndex = 8;
            special.Text = "Znaki Specjalne";
            special.UseVisualStyleBackColor = true;
            // 
            // generate
            // 
            generate.BackColor = Color.SteelBlue;
            generate.Location = new Point(109, 165);
            generate.Name = "generate";
            generate.Size = new Size(106, 23);
            generate.TabIndex = 7;
            generate.Text = "Generuj hasło";
            generate.UseVisualStyleBackColor = false;
            generate.Click += generate_Click;
            // 
            // type_pass
            // 
            type_pass.Location = new Point(164, 27);
            type_pass.Name = "type_pass";
            type_pass.Size = new Size(138, 23);
            type_pass.TabIndex = 6;
            // 
            // digits
            // 
            digits.AutoSize = true;
            digits.Location = new Point(43, 101);
            digits.Name = "digits";
            digits.Size = new Size(54, 19);
            digits.TabIndex = 3;
            digits.Text = "Cyfry";
            digits.UseVisualStyleBackColor = true;
            // 
            // characters
            // 
            characters.AutoSize = true;
            characters.Location = new Point(43, 65);
            characters.Name = "characters";
            characters.Size = new Size(126, 19);
            characters.TabIndex = 2;
            characters.Text = "Małe i wielkie litery";
            characters.UseVisualStyleBackColor = true;
            // 
            // signs
            // 
            signs.AutoSize = true;
            signs.Location = new Point(52, 35);
            signs.Name = "signs";
            signs.Size = new Size(69, 15);
            signs.TabIndex = 1;
            signs.Text = "Ile Znaków?";
            // 
            // alter
            // 
            alter.BackColor = Color.SteelBlue;
            alter.Location = new Point(338, 351);
            alter.Name = "alter";
            alter.Size = new Size(115, 51);
            alter.TabIndex = 8;
            alter.Text = "Zatwierdź";
            alter.UseVisualStyleBackColor = false;
            alter.Click += alter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(783, 450);
            Controls.Add(alter);
            Controls.Add(pass_generator);
            Controls.Add(worker_data);
            Name = "Form1";
            Text = "Form1";
            worker_data.ResumeLayout(false);
            worker_data.PerformLayout();
            pass_generator.ResumeLayout(false);
            pass_generator.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox worker_data;
        private TextBox name_box;
        private TextBox secName_box;
        private ComboBox job_select;
        private Label Job;
        private Label sec_name;
        private Label name;
        private GroupBox pass_generator;
        private CheckBox digits;
        private CheckBox characters;
        private Label signs;
        private TextBox type_pass;
        private Button generate;
        private Button alter;
        private CheckBox special;
    }
}