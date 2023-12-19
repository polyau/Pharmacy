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
    public partial class frmManager : Form
    {
        private string word; // Переменная, в которой будет храниться переданное слово

        public frmManager(string word)
        {
            InitializeComponent();
            this.word = word; // Сохранение переданного слова в переменную word
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Form frm = new frmProduct(word);
            frm.Show();
            this.Hide();
        }

        private void btnSotr_Click(object sender, EventArgs e)
        {
            Form frm = new frmSotr(word);
            frm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frm = new frmAuth();
            frm.Show();
            this.Hide();
        }
    }
}
