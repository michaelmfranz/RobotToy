using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotToy
{
    public partial class frmControl : Form
    {
        RobotToy toy = new RobotToy();

        private class OrientationData
        {
            public string Name { get; set; }
            public int Value { get; set; }
        }

        public frmControl()
        {
            InitializeComponent();


            List<OrientationData> cbo = new List<OrientationData>()
            {
                new OrientationData() { Name = "North" , Value = 0 },
                new OrientationData() { Name = "East" , Value = 90 },
                new OrientationData() { Name = "South" , Value = 180 },
                new OrientationData() { Name = "West" , Value = 270 }
            };

            cboOrientation.DataSource = cbo;

            cboOrientation.DisplayMember = "Name";
            cboOrientation.ValueMember = "Value";
        }

        private void bntRestart_Click(object sender, EventArgs e)
        {
            toy = new RobotToy();
            dgvReport.DataSource = null;
            dgvReport.Rows.Clear();
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
           toy.Place(xLocation.Text, yLocation.Text, int.Parse(cboOrientation.SelectedValue.ToString()));
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            toy.Move();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            toy.Left();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            toy.Right();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
 
            dgvReport.DataSource = toy.Report.Select(x => new { Value = x }).ToList();
            dgvReport.Show();

        }
    }
}
