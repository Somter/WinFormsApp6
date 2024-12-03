namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        List<Author> authors = new List<Author>();

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
        }

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author newAuthor = new Author();

            using (Form2 form2 = new Form2(newAuthor, true))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    authors.Add(newAuthor);
                    comboBox1.Items.Add(newAuthor);
                    comboBox1.SelectedItem = newAuthor; // �������� ������������ ������
                    MessageBox.Show($"����� {newAuthor.Name} ��������");
                }
            }

            UpdateBooksList(null);
        }

        private void �������������ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Author selectedAuthor = comboBox1.SelectedItem as Author;
            if (selectedAuthor == null)
            {
                MessageBox.Show("�������� ������ ����� ����������� �����.");
                return;
            }

            Book newBook = new Book();

            using (Form3 form3 = new Form3(newBook, authors, true))
            {
                if (form3.ShowDialog() == DialogResult.OK)
                {
                    selectedAuthor.Books.Add(newBook);
                    newBook.Author = selectedAuthor;

                    MessageBox.Show($"����� \"{newBook.Title}\" ��������� ������ {selectedAuthor.Name}");
                    UpdateBooksList(null);
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBooksList(null);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBooksList(null);
        }

        private void UpdateBooksList(Author author)
        {
            listBox1.Items.Clear();

            if (checkBox1.Checked)
            {
                if (comboBox1.SelectedItem is Author selectedAuthor)
                {
                    foreach (var book in selectedAuthor.Books)
                    {
                        listBox1.Items.Add(book);
                    }
                }
            }
            else
            {
                foreach (var authorItem in authors)
                {
                    foreach (var book in authorItem.Books)
                    {
                        listBox1.Items.Add(book);
                    }
                }
            }
        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author selectedAuthor = comboBox1.SelectedItem as Author;
            if (selectedAuthor == null)
            {
                MessageBox.Show("�������� ������, �������� ������ �������.");
                return;
            }

            var result = MessageBox.Show(
                $"������������� �� �� ������ ������� ������ \"{selectedAuthor.Name}\" � ��� ��� �����?",
                "�������� ������",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            { 
                authors.Remove(selectedAuthor);
                comboBox1.Items.Remove(selectedAuthor);

                UpdateBooksList(null);

            }
        }

        private void �������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author selectedAuthor = comboBox1.SelectedItem as Author;
            if (selectedAuthor == null)
            {
                MessageBox.Show("�������� ������, �������� ������ �������������.");
                return;
            }

            using (Form2 form2 = new Form2(selectedAuthor, false))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    int index = comboBox1.Items.IndexOf(selectedAuthor);
                    comboBox1.Items[index] = selectedAuthor;
                    UpdateBooksList(null);

                    MessageBox.Show($"����� \"{selectedAuthor.Name}\" ������� ��������������.");
                }
            }
        }

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Book selectedBook)
            {
                using (Form3 form3 = new Form3(selectedBook, authors, false))
                {
                    if (form3.ShowDialog() == DialogResult.OK)
                    {
                          UpdateBooksList(null);
                    }
                }
            }
            else
            {
                MessageBox.Show("�������� �����, ������� ������ �������������.");
            }
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Book selectedBook)
            {
                var result = MessageBox.Show(
                    $"������������� �� �� ������ ������� ����� \"{selectedBook.Title}\"?",
                    "�������� �����",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    selectedBook.Author.Books.Remove(selectedBook);
                    UpdateBooksList(null);
                }
            }
            else
            {
                MessageBox.Show("�������� �����, ������� ������ �������.");
            }
        }

        private void ���������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "��������� ������ � ����";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (var author in authors)
                        {
                            writer.WriteLine($"Author:{author.Name}");

                            foreach (var book in author.Books)
                            {
                                writer.WriteLine($"Book:{book.Title}");
                            }
                        }
                    }

                    MessageBox.Show("������ ������� ��������� � ����.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void �������ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "������� ����";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        authors.Clear();
                        comboBox1.Items.Clear();

                        string line;
                        Author currentAuthor = null;

                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.StartsWith("Author:"))
                            {
                                string authorName = line.Substring(7).Trim();
                                currentAuthor = new Author { Name = authorName };
                                authors.Add(currentAuthor);
                                comboBox1.Items.Add(currentAuthor);
                            }
                            else if (line.StartsWith("Book:") && currentAuthor != null)
                            {
                                string bookTitle = line.Substring(5).Trim();
                                Book newBook = new Book { Title = bookTitle, Author = currentAuthor };
                                currentAuthor.Books.Add(newBook);
                            }
                        }
                    }

                    MessageBox.Show("������ ������� ��������� �� �����.");
                    UpdateBooksList(null); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void �����ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
