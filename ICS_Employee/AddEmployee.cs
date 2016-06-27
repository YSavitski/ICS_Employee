using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICS_Employee
{
    public partial class AddEmployee : Form
    {
        private DataTable tblSearchPeople = new DataTable("tblSearchPeople");
        private DataTable tblSearchPosition = new DataTable("tblSearchPosition");
        public AddEmployee()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            Connection.LoadDataInTable(string.Format("SELECT p.FirstName, p.LastName, p.Birthday FROM People AS p"), tblSearchPeople);
            Connection.LoadDataInTable(string.Format("SELECT DISTINCT p.PositionName FROM Position AS p"), tblSearchPosition);
            dgvSearchPeople.DataSource = tblSearchPeople;
            dgvSearchPosition.DataSource = tblSearchPosition;
        }

        private void btnSearchPeople_Click(object sender, EventArgs e)
        {
            tblSearchPeople.Clear();
            Connection.LoadDataInTable(string.Format("SELECT p.FirstName, p.LastName, p.Birthday FROM People AS p " +
                                                     "WHERE p.FirstName LIKE '%{0}%' OR p.LastName LIKE '%{0}%' OR p.Birthday LIKE '%{0}%'",
                                                     tbSearchPeople.Text), tblSearchPeople);
            dgvSearchPeople.DataSource = tblSearchPeople;
        }

        private void btnSearchPosition_Click(object sender, EventArgs e)
        {
            tblSearchPosition.Clear();
            Connection.LoadDataInTable(string.Format("SELECT DISTINCT p.PositionName FROM Position AS p " +
                                                     "WHERE p.PositionName LIKE '%{0}%'", tbSearchPosition.Text), tblSearchPosition);
            dgvSearchPosition.DataSource = tblSearchPosition;
        }

        private void btnAddPeople_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = new AddPeople().ShowDialog();
        }
    }
}
