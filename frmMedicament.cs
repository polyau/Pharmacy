using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class frmMedicament : Form
    {
        public frmMedicament()
        {
            InitializeComponent();
        }

        private void btnMedicament_Click(object sender, EventArgs e)
        {
            sqlCommand_medicament.Parameters["@barcode"].Value = txtMedicament.Text;

            sqlConnection.Open();
            var temp = new DataTable();
            temp.Load(sqlCommand_medicament.ExecuteReader());
            tblMedicament.DataSource = temp;
            sqlConnection.Close();
        }
    }
}
