namespace Notepad
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
            components = new System.ComponentModel.Container();
            menuStripMainMenu = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            nowyToolStripMenuItem = new ToolStripMenuItem();
            otwórzToolStripMenuItem = new ToolStripMenuItem();
            zapiszToolStripMenuItem = new ToolStripMenuItem();
            zapiszJakoToolStripMenuItem = new ToolStripMenuItem();
            zamknijToolStripMenuItem = new ToolStripMenuItem();
            edycjaToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            pomocToolStripMenuItem = new ToolStripMenuItem();
            textBoxNotepad = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            statusStrip1 = new StatusStrip();
            menuStripMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            menuStripMainMenu.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem, edycjaToolStripMenuItem, formatToolStripMenuItem, pomocToolStripMenuItem });
            menuStripMainMenu.Location = new Point(0, 0);
            menuStripMainMenu.Name = "menuStripMainMenu";
            menuStripMainMenu.Size = new Size(800, 24);
            menuStripMainMenu.TabIndex = 0;
            menuStripMainMenu.Text = "menuStrip1";
            menuStripMainMenu.ItemClicked += menuStrip1_ItemClicked;
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nowyToolStripMenuItem, otwórzToolStripMenuItem, zapiszToolStripMenuItem, zapiszJakoToolStripMenuItem, zamknijToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(38, 20);
            plikToolStripMenuItem.Text = "Plik";
            plikToolStripMenuItem.Click += plikToolStripMenuItem_Click;
            // 
            // nowyToolStripMenuItem
            // 
            nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            nowyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            nowyToolStripMenuItem.Size = new Size(204, 22);
            nowyToolStripMenuItem.Text = "Nowy";
            nowyToolStripMenuItem.Click += nowyToolStripMenuItem_Click;
            // 
            // otwórzToolStripMenuItem
            // 
            otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            otwórzToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            otwórzToolStripMenuItem.Size = new Size(204, 22);
            otwórzToolStripMenuItem.Text = "Otwórz";
            // 
            // zapiszToolStripMenuItem
            // 
            zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            zapiszToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            zapiszToolStripMenuItem.Size = new Size(204, 22);
            zapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // zapiszJakoToolStripMenuItem
            // 
            zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            zapiszJakoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            zapiszJakoToolStripMenuItem.Size = new Size(204, 22);
            zapiszJakoToolStripMenuItem.Text = "Zapisz jako";
            // 
            // zamknijToolStripMenuItem
            // 
            zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            zamknijToolStripMenuItem.Size = new Size(204, 22);
            zamknijToolStripMenuItem.Text = "Zamknij";
            zamknijToolStripMenuItem.Click += zamknijToolStripMenuItem_Click;
            // 
            // edycjaToolStripMenuItem
            // 
            edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            edycjaToolStripMenuItem.Size = new Size(53, 20);
            edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "Format";
            // 
            // pomocToolStripMenuItem
            // 
            pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            pomocToolStripMenuItem.Size = new Size(57, 20);
            pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // textBoxNotepad
            // 
            textBoxNotepad.Dock = DockStyle.Fill;
            textBoxNotepad.Location = new Point(0, 24);
            textBoxNotepad.Multiline = true;
            textBoxNotepad.Name = "textBoxNotepad";
            textBoxNotepad.Size = new Size(800, 426);
            textBoxNotepad.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStripInfo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(textBoxNotepad);
            Controls.Add(menuStripMainMenu);
            MainMenuStrip = menuStripMainMenu;
            Name = "Form1";
            Text = "Form1";
            menuStripMainMenu.ResumeLayout(false);
            menuStripMainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMainMenu;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem nowyToolStripMenuItem;
        private ToolStripMenuItem otwórzToolStripMenuItem;
        private ToolStripMenuItem zapiszToolStripMenuItem;
        private ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private ToolStripMenuItem zamknijToolStripMenuItem;
        private ToolStripMenuItem edycjaToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem pomocToolStripMenuItem;
        private TextBox textBoxNotepad;
        private ContextMenuStrip contextMenuStrip1;
        private StatusStrip statusStrip1;
    }
}
