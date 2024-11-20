using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_s
{
    public partial class Form1 : Form
    {
        private BookManager bookManager = new BookManager();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

            string title = txtTitle.Text;
            string author = txtAuthor.Text;

            if (int.TryParse(txtYear.Text, out int year))
            {
                bookManager.AddBook(title, author, year);
                MessageBox.Show("Книга успешно добавлена.");
                ClearInputs();
                DisplayBooks(bookManager.GetAllBooks());
            }
            else
            {
                MessageBox.Show("Пожалуйста введите год.");
            }
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {

            if (lstBooks.SelectedItem is Book selectedBook)
            {
                bookManager.RemoveBook(selectedBook.Id);
                MessageBox.Show("Книга успешно удалена.");
                DisplayBooks(bookManager.GetAllBooks());
            }
            else
            {
                MessageBox.Show("Пожалуйста выберите книгу для удаления.");
            }
        }

        private void btnSearchByAuthor_Click(object sender, EventArgs e)
        {
            string author = txtAuthor.Text;
            var results = bookManager.FindBookByAuthor(author);
            DisplayBooks(results);
        }

        private void btnShowAllBooks_Click(object sender, EventArgs e)
        {
            DisplayBooks(bookManager.GetAllBooks());
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DisplayBooks(System.Collections.Generic.List<Book> books)
        {
            lstBooks.Items.Clear();
            foreach (var book in books)
            {
                lstBooks.Items.Add(book);
            }
        }
        private void ClearInputs()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
