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
    public partial class DepositAdd : Form
    {
        private FormManager _formManager;
        private DepositDal _depositDal;
        public DepositAdd()
        {
            InitializeComponent();
            _formManager = new FormManager(Form1._pnlMainContainer, Form1._frm);
            _depositDal = new DepositDal();
        }

        private void pictureBtnBack_Click(object sender, EventArgs e)
        {
            _formManager.FormAddToPanel("");
        }

        private void btnGiveDepositBookBtn_Click(object sender, EventArgs e)
        {
            var _deposit = new Deposit()
            {
                UserNo = Convert.ToInt32(tbxUserNo.Value),
                BookNo = Convert.ToInt32(tbxBookNo.Value),
                BackDate = dtpbxBackDate.Value,
                DepositNote = rchtbxDepositNote.Text,
                IsDepositDelivered = false.ToString(),
                CreatedAt = DateTime.Now,
            };
            _depositDal.Add(_deposit);
            _formManager.FormAddToPanel("depositlist");
            tbxUserNo.Value = 0;
            tbxBookNo.Value = 0;
            dtpbxBackDate.Value = DateTime.Now;
            rchtbxDepositNote.Text = "";
        }
    }
}
