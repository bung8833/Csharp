using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.ReadBooks.Win
{
    public partial class Form1 : Form
    {
        private Library _library = new Library();

        public int PageIndex
        {
            get
            {
                int pageIndex = int.TryParse(pageIndexTextBox.Text, out int number)
                    ? number : 0;

                pageIndexTextBox.Text = pageIndex.ToString();
                return pageIndex;
            }
        }

        public int PageLength
        {
            get
            {
                int pageLength = int.TryParse(pageLengthTextBox.Text, out int number)
                    ? number : 1;

                pageLengthTextBox.Text = pageLength.ToString();
                return pageLength;
            }
        }

        public Form1()
        {
            InitializeComponent();

            titleLabel.Text = string.Empty;
        }

        /// <summary>
        /// 挑選一個純文字檔,當作Book,加入Library
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkinButton_Click(object sender, EventArgs e)
        {
            Book book = ChoiceBook();
            if (book == null) return;

            _library.CheckIn(book);

            DisplayLibraryContext();
        }

        private void libraryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayBook();
        }
        private void displayButton_Click(object sender, EventArgs e)
        {
            DisplayBook();
        }

        private void DisplayLibraryContext()
        {
            // libraryListBox.Items.Clear();

            libraryListBox.DisplayMember = "Title";
            libraryListBox.ValueMember = "Title";
            libraryListBox.DataSource = _library.Books.ToList();
            libraryListBox.SelectedIndex = 0;
        }

        private string ChoiceTextFile()
        {
            var dialog = new OpenFileDialog();

            dialog.Filter = "Text Files (.txt)|*.txt";
            dialog.FilterIndex = 1;

            DialogResult result = dialog.ShowDialog();

            if (result != DialogResult.OK) return null;

            return dialog.FileName;
        }

        private Book ChoiceBook()
        {
            string fileName = ChoiceTextFile();
            if (string.IsNullOrEmpty(fileName)) return null;

            string ext = Path.GetExtension(fileName);
            if (ext == null || ext.ToLower() != ".txt") return null;

            string bookTitle = Path.GetFileNameWithoutExtension(fileName);
            string bookContent = File.ReadAllText(fileName);

            return new Book(bookTitle, bookContent);
        }

        private void DisplayBook()
        {
            contentTextBox.Text = string.Empty;

            string bookTitle = libraryListBox.Text;
            Book book = _library[bookTitle];

            if (book == null) return;

            titleLabel.Text = book.Title;
            contentTextBox.Text = book.GetPagedContent(this.PageIndex, this.PageLength);
        }




    }
}
