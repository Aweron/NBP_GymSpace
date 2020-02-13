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
    public partial class WorkoutManagement : Form
    {
        public WorkoutManagement()
        {
            InitializeComponent();
        }

        private void radAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radAdd.Checked)
            {
                txtWorkoutID.Enabled = true;
                txtMemberID.Enabled = true;
                txtGym.Enabled = true;
                dtpDate.Enabled = true;
                dtpStart.Enabled = true;
                dtpEnd.Enabled = true;
                cmbExercise.Enabled = true;
                grpBy.Visible = false;
            }
        }

        private void radDel_CheckedChanged(object sender, EventArgs e)
        {
            if(radDel.Checked)
            {
                txtWorkoutID.Enabled = true;
                txtMemberID.Enabled = false;
                txtGym.Enabled = false;
                dtpDate.Enabled = false;
                dtpStart.Enabled = false;
                dtpEnd.Enabled = false;
                cmbExercise.Enabled = false;
                grpBy.Visible = false;
            }
        }

        private void radGet_CheckedChanged(object sender, EventArgs e)
        {
            if (radGet.Checked)
            {
                radWorkoutID.Checked = false;
                radMemberID.Checked = false;
                radDate.Checked = false;

                txtWorkoutID.Enabled = true;
                txtMemberID.Enabled = true;
                txtGym.Enabled = false;
                dtpDate.Enabled = true;
                dtpStart.Enabled = false;
                dtpEnd.Enabled = false;
                cmbExercise.Enabled = false;
                grpBy.Visible = true;
                
            }
        }

        private void radWorkoutID_CheckedChanged(object sender, EventArgs e)
        {
            if (radGet.Checked)
            {
                txtWorkoutID.Enabled = true;
                txtMemberID.Enabled = false;
                dtpDate.Enabled = false;
            }
        }

        private void radMemberID_CheckedChanged(object sender, EventArgs e)
        {
            if (radGet.Checked)
            {
                txtWorkoutID.Enabled = false;
                txtMemberID.Enabled = true;
                dtpDate.Enabled = false;
            }
        }

        private void radDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radGet.Checked)
            {
                txtWorkoutID.Enabled = false;
                txtMemberID.Enabled = false;
                dtpDate.Enabled = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string workoutID = txtWorkoutID.Text;
            string memberID = txtMemberID.Text;
            string gym = txtGym.Text;
            string date = dtpDate.Text;
            string start = dtpStart.Text;
            string end = dtpEnd.Text;

            if (radAdd.Checked)
            {
                if (workoutID != "" && memberID != "" && gym != "")
                {
                    Workout w = DataProvider.GetWorkout(workoutID);
                    if (w.WorkoutID == null)
                    {
                        if (DataProvider.AddWorkout(workoutID, memberID, gym, date, start, end, cmbExercise.SelectedItem.ToString()))
                        {
                            MessageBox.Show("Workout successfully added.", "Success");
                            UpdateGridView();
                        }
                        else MessageBox.Show("That Member ID does not exist.", "Failure");
                    }
                    else MessageBox.Show("That Workout ID is already taken. Generate a new one.");
                }
                else MessageBox.Show("Please fill in all required fields.", "Invalid input");
            }
            else if (radGet.Checked)
            {
                if (radWorkoutID.Checked)
                {
                    if (workoutID != "")
                    {
                        dataWorkouts.Rows.Clear();
                        Workout workout = DataProvider.GetWorkout(workoutID);
                        dataWorkouts.Rows.Add(workout.WorkoutID, workout.MemberID, workout.GymName, workout.Date, workout.StartTime, workout.EndTime, workout.Exercise);
                    }
                    else MessageBox.Show("Enter an ID.", "Invalid input");
                }
                else if (radMemberID.Checked)
                {
                    if (memberID != "")
                    {
                        dataWorkouts.Rows.Clear();
                        List<Workout> workouts = DataProvider.GetWorkoutByMemberID(memberID);
                        foreach (Workout workout in workouts)
                            dataWorkouts.Rows.Add(workout.WorkoutID, workout.MemberID, workout.GymName, workout.Date, workout.StartTime, workout.EndTime, workout.Exercise);
                    }
                    else MessageBox.Show("Enter an ID.", "Invalid input");
                }
                else if (radDate.Checked)
                {
                    dataWorkouts.Rows.Clear();
                    List<Workout> workouts = DataProvider.GetWorkoutByDate(date);
                    foreach (Workout workout in workouts)
                        dataWorkouts.Rows.Add(workout.WorkoutID, workout.MemberID, workout.GymName, workout.Date, workout.StartTime, workout.EndTime, workout.Exercise);
                }
                else
                {
                    MessageBox.Show("Choose an option from the 'Get by' list.", "Invalid input");
                }
            }
            else if (radDel.Checked)
            {
                if (workoutID != "")
                {
                    DataProvider.DeleteWorkout(workoutID);
                    MessageBox.Show("Workout deleted.", workoutID);
                    UpdateGridView();
                }
                else MessageBox.Show("Enter an ID.", "Invalid input");
            }
        }

        private void btnGenerateID_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int i = rand.Next(1000, 9999);
            txtWorkoutID.Text = i.ToString();
        }

        private void btnAllWorkouts_Click(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        private void UpdateGridView()
        {
            dataWorkouts.Rows.Clear();
            List<Workout> workouts = DataProvider.AllWorkouts();
            foreach (Workout workout in workouts)
                dataWorkouts.Rows.Add(workout.WorkoutID, workout.MemberID, workout.GymName, workout.Date, workout.StartTime, workout.EndTime, workout.Exercise);
        }
    }
}
