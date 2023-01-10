using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ispan.Estore.SqlDataLayer.WinForm
{
    public partial class FormEditUser : Form
    {
        private readonly int UserId;
        public DateTime? UserDateOfBirth => DateTime.TryParse(textBoxDateOfBirth.Text, out DateTime dt) ? dt : (DateTime?)null;

        public int? UserHeight => int.TryParse(textBoxHeight.Text, out int Height) ? Height : (int?)null;

        public FormEditUser(int userId)
        {
            InitializeComponent();
            this.Load += FormEditUser_Load;
            this.UserId = userId;
        }
        private UserEntity UpdateModel()
           => new UserEntity()
           {
               Id = UserId,
               Account = textBoxAccount.Text,
               Password = textBoxPassword.Text,
               Name = textBoxName.Text,
               Email = textBoxEmail.Text,
               DateBirth = this.UserDateOfBirth,
               Height = this.UserHeight
           };



        private void FormEditUser_Load(object sender, EventArgs e)
        {
            var userEntity = new UserRepository().GetUser(UserId);
            textBoxAccount.Text = userEntity.Account;
            textBoxPassword.Text = userEntity.Password;
            textBoxName.Text = userEntity.Name;
            textBoxEmail.Text = userEntity.Email;
            textBoxDateOfBirth.Text = userEntity.DateBirth.HasValue
                ? userEntity.DateBirth.Value.ToString("yyyy/MM/dd")
                : string.Empty;
            textBoxHeight.Text = userEntity.Height.HasValue
                ? userEntity.Height.Value.ToString()
                : string.Empty;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var a = UpdateModel();
                new UserRepository().Update(a);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"新增失敗" + ex.Message);
            }
            NotiryUser();
        }

        private void NotiryUser()
        {
            IGridContainer container = this.Owner as IGridContainer;
            if (container != null) container.Display();

            this.DialogResult = DialogResult.OK;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            new UserRepository().Delete(UserId);

            NotiryUser();
        }
    }
}
