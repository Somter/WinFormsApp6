using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form2 : Form
    {
        private Author author;
        private bool check;

        public Form2(Author author, bool state)
        {
            InitializeComponent();
            this.author = author;
            this.check = state;

            FormBorderStyle = FormBorderStyle.FixedDialog;
            Text = state ? "Добавить автора" : "Редактировать автора";

            if (!state)
            {
                textBox1.Text = author.Name;
            }

            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Имя автора не может быть пустым.");
                return;
            }
            author.Name = textBox1.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
