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
    public partial class FrmEditUser : Form
    {
        private readonly int userId;

        public FrmEditUser(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.Load += FrmEditUser_Load;
        }

        private void FrmEditUser_Load(object sender, EventArgs e)
        {
            ShowContent();
        }

        public void ShowContent()
        {
            var entity = new UserRepository().GetUser(userId);

            txtName.Text = entity.Name;
            txtAccount.Text = entity.Account;
            txtPassword.Text = entity.Password;
            txtEmail.Text = entity.Email;
            txtDateOfBirth.Text = 
                entity.DateOfBirth.HasValue? 
                entity.DateOfBirth.Value.ToString("yyyy/mm/dd"):
                String.Empty;
            txtHeight.Text = entity.Height.HasValue?
                entity.Height.ToString():
                string.Empty;
        }

        private UserEntity GetModel()
            => new UserEntity
            {
                Id = userId,
                Name = txtName.Text,
                Account = txtAccount.Text,
                Password = txtPassword.Text,
                Email = txtEmail.Text,
                DateOfBirth = this.DateOfBirth,
                Height = this.UserHeight
            };

        private DateTime? DateOfBirth
            => DateTime.TryParse(txtDateOfBirth.Text, out DateTime dt) ?
            dt
            : (DateTime?)null;

        private int? UserHeight
            => int.TryParse(txtHeight.Text, out int h) ?
            h
            : (int?)null;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new UserRepository().Update(GetModel());
            CallDisplay();
        }

        private void CallDisplay()
        {   
            IGridContainer container = this.Owner as IGridContainer;
            if (container != null) container.Display();
            this.DialogResult = DialogResult.OK;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new UserRepository().Delete(this.userId);
            CallDisplay();
        }
    }
}
