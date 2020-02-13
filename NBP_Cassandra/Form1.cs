using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBP_Cassandra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            MemberManagement newForm = new MemberManagement();
            //this.Hide();
            //newForm.ShowDialog();
            //this.Show();
            newForm.Show();
        }

        private void btnGyms_Click(object sender, EventArgs e)
        {
            GymManagement newForm = new GymManagement();
            //this.Hide();
            //newForm.ShowDialog();
            //this.Show();
            newForm.Show();
        }

        private void btnManageWorkout_Click(object sender, EventArgs e)
        {
            WorkoutManagement newForm = new WorkoutManagement();
            //this.Hide();
            //newForm.ShowDialog();
            //this.Show();
            newForm.Show();
        }
    }
}
