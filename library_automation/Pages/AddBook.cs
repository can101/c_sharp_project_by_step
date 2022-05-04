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

namespace library_automation
{
    public partial class AddBook : Form
    {
        private FormManager _formManager;
        private BookDal _bookDal;
        public AddBook()
        {
            InitializeComponent();
            _formManager = new FormManager(Form1._pnlMainContainer, Form1._frm);
            _bookDal = new BookDal();
        }
        private void pictureBtnBack_Click_1(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("");
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            var _book = new Book()
            {
                Name = tbxBookName.Text,
                Author = tbxBookAuthor.Text,
                Abstract = tbxBookAbstract.Text,
                Language = cbxBookLangugae.SelectedItem.ToString(),
                PageSheetCount = Convert.ToInt32(tbxBookSheetCount.Value),
                PrintHouse = tbxPrintHouse.Text,
                PrintYear = dtpbxPrintYear.Value.Year,
                CreatedAt = DateTime.Now
            };
            _bookDal.Add(_book);
            _formManager.FormAddToPanel("booklist");
            tbxBookName.Text = "";
            tbxBookAuthor.Text = "";
            tbxBookAbstract.Text = "";
            cbxBookLangugae.Text = "choose langugae";
            tbxBookSheetCount.Value = 0;
            tbxPrintHouse.Text = "";
            dtpbxPrintYear.Value = DateTime.Now;
        }
    }
}
