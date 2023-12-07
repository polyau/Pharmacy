using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class frmAuth : Form
    {
        public frmAuth()
        {
            InitializeComponent();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "менеджер" && txtPasswd.Text == "менеджер")
            {
                Form frm = new frmManager();
                frm.Show();
            }

            else if (txtLogin.Text == "первостольник" && txtPasswd.Text == "первостольник")
            {
                Form frm = new frmCashier();
                frm.Show();
            }

            else
            {
                MessageBox.Show("Данные введены неверно. Повторите попытку", 
                    "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
