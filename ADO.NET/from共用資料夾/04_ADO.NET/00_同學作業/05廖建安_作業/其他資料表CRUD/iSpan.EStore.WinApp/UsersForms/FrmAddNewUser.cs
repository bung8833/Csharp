using iSpan.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSpan.EStore.WinApp
{
    public partial class FrmAddNewUser : Form
    {
        public FrmAddNewUser()
        {
            InitializeComponent();
        }

        private UserEntity GetModel()
            =>new UserEntity{
                Name=txtName.Text,
                Account=txtAccount.Text,
                Password=txtPassword.Text,
                Email=txtEmail.Text,
                DateOfBirth=this.DateOfBirth,
                Height=this.UserHeight
            };

        private DateTime? DateOfBirth
            => DateTime.TryParse(txtDateOfBirth.Text, out DateTime dt) ? 
            dt 
            : (DateTime?) null;

        private int? UserHeight
            => int.TryParse(txtHeight.Text, out int h) ? 
            h 
            : (int?)null;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                new UserRepository().Create(GetModel());
            }
            catch(Exception ex) { MessageBox.Show("新增失敗\n" + ex.Message); }
            this.DialogResult = DialogResult.OK;
            //txtName.Text
            //    =txtAccount.Text
            //    =txtPassword.Text
            //    =txtDateOfBirth.Text
            //    =txtDateOfBirth.Text
            //    =txtHeight.Text
            //    =string.Empty;

            IGridContainer container = this.Owner as IGridContainer;
            if (container != null) container.Display();
        }
    }
}
