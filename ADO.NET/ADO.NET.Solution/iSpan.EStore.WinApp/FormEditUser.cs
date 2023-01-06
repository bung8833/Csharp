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
    public partial class FormEditUser : Form
    {
        private int userId;

        public FormEditUser(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        private DateTime? DateOfBirth
            => DateTime.TryParse(textBoxDateOfBirth.Text, out DateTime dateOfBirth)
            ? dateOfBirth
            : (DateTime?)null;

        private int? UserHeight
            => int.TryParse(textBoxHeight.Text, out int height)
            ? height
            : (int?)null;

        private UserEntity GetModel()
            => new UserEntity
            {
                Id = this.userId,
                Account = textBoxAccount.Text,
                Password = textBoxPassword.Text,
                Name = textBoxName.Text,
                Email = textBoxEmail.Text,
                DateOfBirth = this.DateOfBirth,
                Height = this.UserHeight
            };

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            new UserRepository().Update(GetModel());

            IGridContainer container = this.Owner as IGridContainer;
            if (container != null)
            {
                container.Display();
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
