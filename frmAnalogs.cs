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
    public partial class frmAnalogs : Form
    {
        public frmAnalogs()
        {
            InitializeComponent();
        }

        private void btnAnalogs_Click(object sender, EventArgs e)
        {
            sqlCommand_findAnalogs.Parameters["@Barcode"].Value = txtBarcode.Text;

            sqlConnection.Open();
            var temp = new DataTable();
            temp.Load(sqlCommand_findAnalogs.ExecuteReader());
            tblAnalogs.DataSource = temp;
            sqlConnection.Close();
        }
    }
}
