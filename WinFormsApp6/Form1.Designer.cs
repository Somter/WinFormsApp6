namespace WinFormsApp6
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
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            файлToolStripMenuItem1 = new ToolStripMenuItem();
            файлToolStripMenuItem2 = new ToolStripMenuItem();
            открытьToolStripMenuItem2 = new ToolStripMenuItem();
            сохранитьToolStripMenuItem1 = new ToolStripMenuItem();
            выйтиToolStripMenuItem1 = new ToolStripMenuItem();
            опцииToolStripMenuItem = new ToolStripMenuItem();
            добавитьАвтораToolStripMenuItem = new ToolStripMenuItem();
            удалитьАвтораToolStripMenuItem = new ToolStripMenuItem();
            редактироватьАвтораToolStripMenuItem = new ToolStripMenuItem();
            добавитьКнигуToolStripMenuItem = new ToolStripMenuItem();
            удалитьКнигуToolStripMenuItem = new ToolStripMenuItem();
            реедактироватьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem1 = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            выйтиToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, файлToolStripMenuItem1, файлToolStripMenuItem2, опцииToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(519, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(14, 24);
            // 
            // файлToolStripMenuItem1
            // 
            файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            файлToolStripMenuItem1.Size = new Size(14, 24);
            // 
            // файлToolStripMenuItem2
            // 
            файлToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem2, сохранитьToolStripMenuItem1, выйтиToolStripMenuItem1 });
            файлToolStripMenuItem2.Name = "файлToolStripMenuItem2";
            файлToolStripMenuItem2.Size = new Size(59, 24);
            файлToolStripMenuItem2.Text = "Файл";
            // 
            // открытьToolStripMenuItem2
            // 
            открытьToolStripMenuItem2.Name = "открытьToolStripMenuItem2";
            открытьToolStripMenuItem2.Size = new Size(224, 26);
            открытьToolStripMenuItem2.Text = "Открыть ";
            открытьToolStripMenuItem2.Click += открытьToolStripMenuItem2_Click;
            // 
            // сохранитьToolStripMenuItem1
            // 
            сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            сохранитьToolStripMenuItem1.Size = new Size(224, 26);
            сохранитьToolStripMenuItem1.Text = "Сохранить";
            сохранитьToolStripMenuItem1.Click += сохранитьToolStripMenuItem1_Click;
            // 
            // выйтиToolStripMenuItem1
            // 
            выйтиToolStripMenuItem1.Name = "выйтиToolStripMenuItem1";
            выйтиToolStripMenuItem1.Size = new Size(224, 26);
            выйтиToolStripMenuItem1.Text = "Выйти";
            выйтиToolStripMenuItem1.Click += выйтиToolStripMenuItem1_Click;
            // 
            // опцииToolStripMenuItem
            // 
            опцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьАвтораToolStripMenuItem, удалитьАвтораToolStripMenuItem, редактироватьАвтораToolStripMenuItem, добавитьКнигуToolStripMenuItem, удалитьКнигуToolStripMenuItem, реедактироватьToolStripMenuItem });
            опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            опцииToolStripMenuItem.Size = new Size(70, 24);
            опцииToolStripMenuItem.Text = "Опции";
            // 
            // добавитьАвтораToolStripMenuItem
            // 
            добавитьАвтораToolStripMenuItem.Name = "добавитьАвтораToolStripMenuItem";
            добавитьАвтораToolStripMenuItem.Size = new Size(246, 26);
            добавитьАвтораToolStripMenuItem.Text = "Добавить автора";
            добавитьАвтораToolStripMenuItem.Click += добавитьАвтораToolStripMenuItem_Click;
            // 
            // удалитьАвтораToolStripMenuItem
            // 
            удалитьАвтораToolStripMenuItem.Name = "удалитьАвтораToolStripMenuItem";
            удалитьАвтораToolStripMenuItem.Size = new Size(246, 26);
            удалитьАвтораToolStripMenuItem.Text = "Удалить автора";
            удалитьАвтораToolStripMenuItem.Click += удалитьАвтораToolStripMenuItem_Click;
            // 
            // редактироватьАвтораToolStripMenuItem
            // 
            редактироватьАвтораToolStripMenuItem.Name = "редактироватьАвтораToolStripMenuItem";
            редактироватьАвтораToolStripMenuItem.Size = new Size(246, 26);
            редактироватьАвтораToolStripMenuItem.Text = "Редактировать автора";
            редактироватьАвтораToolStripMenuItem.Click += редактироватьАвтораToolStripMenuItem_Click;
            // 
            // добавитьКнигуToolStripMenuItem
            // 
            добавитьКнигуToolStripMenuItem.Name = "добавитьКнигуToolStripMenuItem";
            добавитьКнигуToolStripMenuItem.Size = new Size(246, 26);
            добавитьКнигуToolStripMenuItem.Text = "Добавить книгу";
            добавитьКнигуToolStripMenuItem.Click += добавитьКнигуToolStripMenuItem_Click_1;
            // 
            // удалитьКнигуToolStripMenuItem
            // 
            удалитьКнигуToolStripMenuItem.Name = "удалитьКнигуToolStripMenuItem";
            удалитьКнигуToolStripMenuItem.Size = new Size(246, 26);
            удалитьКнигуToolStripMenuItem.Text = "Удалить книгу";
            удалитьКнигуToolStripMenuItem.Click += удалитьКнигуToolStripMenuItem_Click;
            // 
            // реедактироватьToolStripMenuItem
            // 
            реедактироватьToolStripMenuItem.Name = "реедактироватьToolStripMenuItem";
            реедактироватьToolStripMenuItem.Size = new Size(246, 26);
            реедактироватьToolStripMenuItem.Text = "Редактировать книгу";
            реедактироватьToolStripMenuItem.Click += реедактироватьToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem1
            // 
            открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            открытьToolStripMenuItem1.Size = new Size(224, 26);
            открытьToolStripMenuItem1.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(224, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // выйтиToolStripMenuItem
            // 
            выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            выйтиToolStripMenuItem.Size = new Size(224, 26);
            выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(224, 26);
            открытьToolStripMenuItem.Text = "Открыть";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(28, 90);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(467, 164);
            listBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(28, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(467, 28);
            comboBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(204, 271);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(116, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Фильтрация";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 303);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Authors and books";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem1;
        private ToolStripMenuItem открытьToolStripMenuItem1;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem выйтиToolStripMenuItem;
        private ToolStripMenuItem опцииToolStripMenuItem;
        private ToolStripMenuItem добавитьАвтораToolStripMenuItem;
        private ToolStripMenuItem удалитьАвтораToolStripMenuItem;
        private ToolStripMenuItem редактироватьАвтораToolStripMenuItem;
        private ToolStripMenuItem добавитьКнигуToolStripMenuItem;
        private ToolStripMenuItem удалитьКнигуToolStripMenuItem;
        private ToolStripMenuItem реедактироватьToolStripMenuItem;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private ToolStripMenuItem файлToolStripMenuItem2;
        private ToolStripMenuItem открытьToolStripMenuItem2;
        private ToolStripMenuItem сохранитьToolStripMenuItem1;
        private ToolStripMenuItem выйтиToolStripMenuItem1;
    }
}
