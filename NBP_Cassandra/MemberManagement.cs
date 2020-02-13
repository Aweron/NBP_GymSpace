using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NBP_Cassandra.Data;

namespace NBP_Cassandra
{
    public partial class MemberManagement : Form
    {
        public MemberManagement()
        {
            InitializeComponent();
        }

        #region Member
        private void btnGenerateID_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int i = rand.Next(1000, 9999);
            txtMemberID.Text = i.ToString();
        }

        private void radAddMember_CheckedChanged(object sender, EventArgs e)
        {
            if (radAddMember.Checked)
            {
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                btnGenerateID.Enabled = true;
            }
        }

        private void radGetMember_CheckedChanged(object sender, EventArgs e)
        {
            if (radGetMember.Checked)
            {
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                btnGenerateID.Enabled = false;
            }
        }

        private void radDelMember_CheckedChanged(object sender, EventArgs e)
        {
            if (radDelMember.Checked)
            {
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                btnGenerateID.Enabled = false;
            }
        }

        private void btnOKMember_Click(object sender, EventArgs e)
        {
            string id = txtMemberID.Text;
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;

            if (radAddMember.Checked)
            {
                if (id != "" && firstname != "" && lastname != "")
                {
                    Member m = DataProvider.GetMember(id);
                    if (m.MemberID == null)
                    {
                        DataProvider.AddMember(id, firstname, lastname);
                        MessageBox.Show("Member successfully added.", "Success");
                        UpdateMemberGridView();
                    }
                    else MessageBox.Show("That ID is already taken. Generate a new one.");
                }
                else MessageBox.Show("Please fill in all required fields.", "Invalid input");
            }
            else if (radGetMember.Checked)
            {
                if (id != "")
                {
                    dataMembers.Rows.Clear();
                    Member member = DataProvider.GetMember(id);

                    dataMembers.Rows.Add(member.MemberID, member.FirstName, member.LastName);
                }
                else MessageBox.Show("Enter an ID.", "Invalid input");
            }
            else if (radDelMember.Checked)
            {
                if (id != "")
                {
                    DataProvider.DeleteMember(id);
                    MessageBox.Show("Member deleted.", "Member ID: " + id);
                    UpdateMemberGridView();
                }
                else MessageBox.Show("Enter an ID.", "Invalid input");
            }
        }

        private void btnAllMembers_Click(object sender, EventArgs e)
        {
            UpdateMemberGridView();
        }

        private void UpdateMemberGridView()
        {
            dataMembers.Rows.Clear();
            List<Member> members = DataProvider.AllMembers();
            foreach (Member member in members)
                dataMembers.Rows.Add(member.MemberID, member.FirstName, member.LastName);
        }
        #endregion

        #region Membership
        private void radAddMemship_CheckedChanged(object sender, EventArgs e)
        {
            if (radAddMemship.Checked)
            {
                datLastsFrom.Enabled = true;
                datLastsUntil.Enabled = true;
                txtGym.Enabled = true;
            }
        }

        private void radGetMemship_CheckedChanged(object sender, EventArgs e)
        {
            if (radGetMemship.Checked)
            {
                datLastsFrom.Enabled = false;
                datLastsUntil.Enabled = false;
                txtGym.Enabled = false;
            }
        }

        private void radDelMemship_CheckedChanged(object sender, EventArgs e)
        {
            if (radDelMemship.Checked)
            {
                datLastsFrom.Enabled = false;
                datLastsUntil.Enabled = false;
                txtGym.Enabled = false;
            }
        }

        private void btnOKMembership_Click(object sender, EventArgs e)
        {
            string id = txtMembershipID.Text;
            string from = datLastsFrom.Text;
            string until = datLastsUntil.Text;
            string gym = txtGym.Text;

            if (radAddMemship.Checked)
            {
                if (id != "")
                {
                    if (DataProvider.AddMembership(id, from, until, gym))
                    {
                        MessageBox.Show("Membership successfully added.", "Success");
                        UpdateMembershipGridView();
                    }
                    else MessageBox.Show("That Member ID does not exist.", "Failure");
                }
                else MessageBox.Show("Please fill in all required fields.", "Invalid input");
            }
            else if (radGetMemship.Checked)
            {
                if (id != "")
                {
                    dataMemships.Rows.Clear();
                    Membership membership = DataProvider.GetMembership(id);
                    dataMemships.Rows.Add(membership.MemberID, membership.LastsFrom, membership.LastsUntil, membership.Gym);
                }
                else MessageBox.Show("Enter an ID.", "Invalid input");
            }
            else if (radDelMemship.Checked)
            {
                if (id != "")
                {
                    DataProvider.DeleteMembership(id);
                    MessageBox.Show("Membership deleted.", "Member ID: " + id);
                    UpdateMembershipGridView();
                }
                else MessageBox.Show("Enter an ID.", "Invalid input");
            }
        }

        private void btnAllMemberships_Click(object sender, EventArgs e)
        {
            UpdateMembershipGridView();
        }

        private void UpdateMembershipGridView()
        {
            dataMemships.Rows.Clear();
            List<Membership> memberships = DataProvider.AllMemberships();
            foreach (Membership membership in memberships)
                dataMemships.Rows.Add(membership.MemberID, membership.LastsFrom, membership.LastsUntil, membership.Gym);
        }
        #endregion
    }
}