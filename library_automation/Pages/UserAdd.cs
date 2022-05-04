using library_automation.Entities.Concrete;
using library_automation.EntityFramework;
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
    public partial class UserAdd : Form
    {
        private UserDal _userDal;
        private FormManager _formManager;
        public UserAdd()
        {
            InitializeComponent();
            _userDal = new UserDal();
            _formManager = new FormManager(Form1._pnlMainContainer, Form1._frm);
        }
        private void userAddBtn_Click(object sender, EventArgs e)
        {
            var _user = new User()
            {
                Address = tbxUserAdress.Text,
                CreatedAt = DateTime.Now,
                Email = tbxUserMail.Text,
                FirstName = tbxUserName.Text,
                LastName = tbxUserSurname.Text,
                PhoneNumber = tbxUserPhoneNo.Text
            };
            _userDal.Add(_user);
            _formManager.FormAddToPanel("userlist");
            tbxUserAdress.Text = "";
            tbxUserMail.Text = "";
            tbxUserName.Text = "";
            tbxUserSurname.Text = "";
            tbxUserPhoneNo.Text = "";
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {

        }

        private void pictureBtnBack_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("");
        }
    }
}
