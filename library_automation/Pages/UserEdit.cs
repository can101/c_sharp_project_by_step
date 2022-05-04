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
    public partial class UserEdit : Form
    {
        private FormManager _formManager;
        private UserDal _userDal;
        private User _user;
        public UserEdit(User user)
        {
            InitializeComponent();
            _userDal = new UserDal();
            _user = user;
            _formManager = new FormManager(Form1._pnlMainContainer, Form1._frm);
        }

        private void userUpdateBtn_Click(object sender, EventArgs e)
        {
            var _Uuser = new User()
            {
                Id = _user.Id,
                Address = tbxUserAdress.Text,
                CreatedAt = Convert.ToDateTime(_user.CreatedAt),
                UpdatedAt = DateTime.Now,
                Email = tbxUserMail.Text,
                FirstName = tbxUserName.Text,
                LastName = tbxUserSurname.Text,
                PhoneNumber = tbxUserPhoneNo.Text
            };
            _userDal.Update(_Uuser);
            _formManager.FormAddToPanel("userlist");
            tbxUserAdress.Text = "";
            tbxUserMail.Text = "";
            tbxUserName.Text = "";
            tbxUserSurname.Text = "";
            tbxUserPhoneNo.Text = "";
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {
            tbxUserAdress.Text = _user.Address;
            tbxUserMail.Text = _user.Email;
            tbxUserName.Text = _user.FirstName;
            tbxUserPhoneNo.Text = _user.PhoneNumber;
            tbxUserSurname.Text = _user.LastName;
        }

        private void pictureBtnBack_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("");
        }
    }
}
