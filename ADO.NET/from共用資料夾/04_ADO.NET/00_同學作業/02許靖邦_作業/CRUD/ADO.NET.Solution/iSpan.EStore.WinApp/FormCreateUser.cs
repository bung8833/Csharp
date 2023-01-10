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
    public partial class FormCreateUser : Form
    {
        public FormCreateUser()
        {
            InitializeComponent();
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
                Account = textBoxAccount.Text,
                Password = textBoxPassword.Text,
                Name = textBoxName.Text,
                Email = textBoxEmail.Text,
                DateOfBirth = this.DateOfBirth,
                Height = this.UserHeight
            };


        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                new UserRepository().Create(GetModel());
            }
            catch (Exception ex)
            {
                MessageBox.Show("新增失敗\r\n" + ex.Message);
            }

            IGridContainer container = this.Owner as IGridContainer;
            if (container != null)
            {
                container.Display();
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
