using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ispan.Estore.SqlDataLayer.WinForm
{
    public partial class FormCreateUser : Form
    {
        public DateTime? UserDateOfBirth => DateTime.TryParse(textBoxDateOfBirth.Text, out DateTime dt) ? dt : (DateTime?)null;

        public int? UserHeight => int.TryParse(textBoxHeight.Text, out int Height) ? Height : (int?)null;

        public FormCreateUser()
        {
            InitializeComponent();
        }

        private UserEntity GetModel()
           => new UserEntity()
           {
               Account = textBoxAccount.Text,
               Password = textBoxPassword.Text,
               Name = textBoxName.Text,
               Email = textBoxEmail.Text,
               DateBirth = this.UserDateOfBirth,
               Height = this.UserHeight
           };
        
        

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try { 
                new UserRepository().Create(GetModel());
            }
            catch(Exception ex)
            {
                MessageBox.Show($"新增失敗" + ex.Message);
            }

            IGridContainer container = this.Owner as IGridContainer;
            if (container != null) container.Display();

            this.DialogResult = DialogResult.OK;
        }

        private void FormCreateUser_Load(object sender, EventArgs e)
        {

        }
    }
}
