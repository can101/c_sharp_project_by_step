using library_automation.Entities.Concrete;
using library_automation.EntityFramework.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_automation.Pages
{
    public partial class EditBook : Form
    {
        private Book _book;
        private FormManager _formManager;
        private BookDal _bookDal;
        public EditBook(Book book)
        {
            InitializeComponent();
            _book = book;
            _formManager = new FormManager(Form1._pnlMainContainer, Form1._frm);
            _bookDal = new BookDal();
        }

        private void EditBook_Load(object sender, EventArgs e)
        {
            tbxBookName.Text = _book.Name;
            tbxBookAuthor.Text = _book.Author;
            tbxBookAbstract.Text = _book.Abstract;
            tbxBookSheetCount.Value = Convert.ToInt32(_book.PageSheetCount);
            tbxPrintYear.Value = Convert.ToInt32(_book.PrintYear);
            tbxPrintHouse.Text = _book.PrintHouse;
            cbxBookLangugae.Text = _book.Language;
        }

        private void pictureBtnBack_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("");
        }

        private void btnBookUpdate_Click(object sender, EventArgs e)
        {
            var _Ubook = new Book()
            {
                Id = (int)_book.Id,
                Name = tbxBookName.Text,
                Author = tbxBookAuthor.Text,
                Abstract = tbxBookAbstract.Text,
                Language = cbxBookLangugae.Text.ToString(),
                PageSheetCount = Convert.ToInt32(tbxBookSheetCount.Value),
                PrintHouse = tbxPrintHouse.Text,
                PrintYear = (int)tbxPrintYear.Value,
                CreatedAt = _book.CreatedAt,
                UpdatedAt = DateTime.Now
            };
            _bookDal.Update(_Ubook);
            _formManager.FormAddToPanel("booklist");
            tbxBookName.Text = "";
            tbxBookAuthor.Text = "";
            tbxBookAbstract.Text = "";
            cbxBookLangugae.Text = "";
            tbxBookSheetCount.Value = 0;
            tbxPrintHouse.Text = "";
            tbxPrintYear.Value = DateTime.Now.Year;
        }
    }
}
