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
    public partial class FormDbScript : Form
    {
        private SqlDBInformation repo;
        private List<DbColumnInfoEntity> _dbInfo;

        public FormDbScript()
        {
            InitializeComponent();
            this.Load += FormDbScript_Load;
            repo = new SqlDBInformation();
        }

        private void FormDbScript_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            _dbInfo = repo.GetColumnsInf().ToList();
            dataGridView1.DataSource = _dbInfo;

        }

        private void buttonCreateRepo_Click(object sender, EventArgs e)
        {
            Display();

        }

        private void buttonGetDistTable_Click(object sender, EventArgs e)
        {
            repo.InfoAnalysis();
        }
    }
}
