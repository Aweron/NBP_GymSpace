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
    public partial class GymManagement : Form
    {
        public GymManagement()
        {
            InitializeComponent();
        }

        private void radAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radAdd.Checked)
            {
                txtPhone.Enabled = true;
                txtAddress.Enabled = true;
                txtCity.Enabled = true;
                txtCountry.Enabled = true;
            }
        }

        private void radDel_CheckedChanged(object sender, EventArgs e)
        {
            if (radDel.Checked)
            {
                txtPhone.Enabled = false;
                txtAddress.Enabled = false;
                txtCity.Enabled = false;
                txtCountry.Enabled = false;
            }
        }

        private void radGet_CheckedChanged(object sender, EventArgs e)
        {
            if (radGet.Checked)
            {
                txtPhone.Enabled = false;
                txtAddress.Enabled = false;
                txtCity.Enabled = false;
                txtCountry.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string country = txtCountry.Text;

            if (radAdd.Checked)
            {
                if (name != "" && phone != "" && address != "" && city != "" && country != "")
                {
                    Gym g = DataProvider.GetGym(name);
                    if (g.Name == null)
                    {
                        DataProvider.AddGym(name, phone, address, city, country);
                        MessageBox.Show("Gym successfully added.", "Success");
                        UpdateGridView();
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("That Gym is already registered. Would you like to update it?", "Warning", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            DataProvider.AddGym(name, phone, address, city, country);
                            MessageBox.Show("Gym successfully added.", "Success");
                            UpdateGridView();
                        }
                    }
                }
                else MessageBox.Show("Please fill in all required fields.", "Invalid input");
            }
            else if (radGet.Checked)
            {
                if (name != "")
                {
                    dataGym.Rows.Clear();
                    Gym gym = DataProvider.GetGym(name);
                    if (gym.Name != null)
                        dataGym.Rows.Add(gym.Name, gym.Phone, gym.Address, gym.City, gym.Country);
                    else
                        MessageBox.Show("Gym not found in database.", "Error");
                }
                else MessageBox.Show("Enter a name.", "Invalid input");
            }
            else if (radDel.Checked)
            {
                if (name != "")
                {
                    DataProvider.DeleteGym(name);
                    MessageBox.Show("Gym deleted.", name);
                    UpdateGridView();
                }
                else MessageBox.Show("Enter a name.", "Invalid input");
            }
        }

        private void btnAllGyms_Click(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        private void UpdateGridView()
        {
            dataGym.Rows.Clear();
            List<Gym> gyms = DataProvider.AllGyms();
            foreach (Gym gym in gyms)
                dataGym.Rows.Add(gym.Name, gym.Phone, gym.Address, gym.City, gym.Country);
        }
    }
}
