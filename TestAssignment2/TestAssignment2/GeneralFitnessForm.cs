// Author: Hailey Forcier
// Date: 03/10/2025
//Purpose: To calculate user's general fitness levels.


using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestAssignment2
{
    public partial class GeneralFitnessForm : Form
    {
        private BindingList<User> users = new BindingList<User>(); // Stores multiple users
        private string connectionString; // Database connection string

        public GeneralFitnessForm()
        {
            InitializeComponent();
            InitializeDatabase();
            InitializeForm();
        }

        // Initializes the database connection string
        private void InitializeDatabase()
        {
            string path = Application.StartupPath;
            int pathLength = path.Length;
            path = path.Substring(0, pathLength - 25);
            connectionString = @$"Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName={path}Fitness.mdf";
        }

        // Sets up the form's initial state
        private void InitializeForm()
        {
            PopulateActivityLevelComboBox();
            listBoxUsers.DataSource = users;
            listBoxUsers.DisplayMember = "Name";
            grpFemaleInputs.Visible = false; // Hide female-specific fields initially
            LoadUsers();
        }

        // Populates the activity level combo box
        private void PopulateActivityLevelComboBox()
        {
            cmbActivityLevel.DataSource = new string[]
            {
                "Sedentary (Little to no exercise)",
                "Lightly Active (1-3 days per week)",
                "Moderately Active (3-5 days per week)",
                "Very Active (6-7 days per week)",
                "Super Active (Athlete level)",
                "Extremely Active (Professional Athlete)"
            };
        }

        // Loads users from the database into the list
        private void LoadUsers()
        {
            users.Clear(); // Clear the BindingList before loading new data

            string query = "SELECT Name, Age, Height, Weight, Gender, Waist, Wrist, Hip, Forearm, ActivityLevel, RMR, AMR, BodyFatPercentage FROM User_tbl";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User(
                                reader["Name"].ToString(),
                                Convert.ToDecimal(reader["Weight"]),
                                Convert.ToDecimal(reader["Height"]),
                                Convert.ToInt32(reader["Age"]),
                                reader["Gender"].ToString(),
                                reader["Waist"] != DBNull.Value ? Convert.ToDecimal(reader["Waist"]) : (decimal?)null,
                                reader["Wrist"] != DBNull.Value ? Convert.ToDecimal(reader["Wrist"]) : (decimal?)null,
                                reader["Hip"] != DBNull.Value ? Convert.ToDecimal(reader["Hip"]) : (decimal?)null,
                                reader["Forearm"] != DBNull.Value ? Convert.ToDecimal(reader["Forearm"]) : (decimal?)null,
                                0 // Placeholder for ActivityLevel
                            );

                            users.Add(user);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading users: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Updates the user report display based on selection
        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem is User selectedUser)
            {
                UpdateUserReport(selectedUser);
            }
        }

        // Displays the selected user's details
        private void UpdateUserReport(User user)
        {
            lblOutputName.Text = user.Name;
            lblOutputWeight.Text = user.Weight.ToString("F2");
            lblOutputHeight.Text = user.Height.ToString("F2");
            lblOutputAge.Text = user.Age.ToString();
            lblOutputGender.Text = user.Gender;
            lblOutputBMR.Text = user.RMR.ToString("F2");
            lblOutputActivityBMR.Text = user.AMR.ToString("F2");
            lblOutputActivityLevel.Text = cmbActivityLevel.Items[user.ActivityLevel].ToString();
            lblOutputBodyFat.Text = user.BodyFatPercentage.HasValue ? $"{user.BodyFatPercentage:F2}%" : "N/A";
        }

        private void chkDeleteUser_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeleteUser.Checked)
            {
                btnCreateUser.Text = "Delete User";
                btnCreateUser.Click -= btnCreateUser_Click; // Remove Create User event
                btnCreateUser.Click += btnDeleteUser_Click; // Add Delete User event
            }
            else
            {
                btnCreateUser.Text = "Create User";
                btnCreateUser.Click -= btnDeleteUser_Click; // Remove Delete User event
                btnCreateUser.Click += btnCreateUser_Click; // Add Create User event
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem is User selectedUser)
            {
                DialogResult confirm = MessageBox.Show($"Are you sure you want to delete {selectedUser.Name}?",
                                                       "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM User_tbl WHERE Name = @Name";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", selectedUser.Name);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show($"{selectedUser.Name} has been deleted.", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers(); // Refresh user list
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        // Handles gender selection changes to show/hide female-specific inputs
        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGender.SelectedItem != null)
            {
                string selectedGender = cmbGender.SelectedItem.ToString();
                grpFemaleInputs.Visible = selectedGender == "Female";
            }
        }

        private bool ValidateUserInput(out string name, out decimal weight, out decimal height, out int age,
                               out string gender, out decimal? waist, out decimal? wrist,
                               out decimal? hip, out decimal? forearm)
        {
            // Assign default values to all out parameters
            name = txtName.Text.Trim();
            gender = cmbGender.SelectedItem?.ToString();
            weight = 0;
            height = 0;
            age = 0;
            waist = wrist = hip = forearm = null;

            // Ensure required fields are properly set
            bool valid =
                !string.IsNullOrWhiteSpace(name) &&
                decimal.TryParse(txtWeight.Text, out weight) &&
                decimal.TryParse(txtHeight.Text, out height) &&
                int.TryParse(txtAge.Text, out age) &&
                cmbGender.SelectedIndex != -1;

            // Validate female-specific inputs
            if (valid && gender == "Female")
            {
                wrist = TryParseNullable(txtWrist.Text);
                hip = TryParseNullable(txtHip.Text);
                forearm = TryParseNullable(txtForearm.Text);
            }

            waist = TryParseNullable(txtWaist.Text);

            return valid;
        }

        // Helper function for nullable decimal values
        private decimal? TryParseNullable(string input)
        {
            return decimal.TryParse(input, out decimal value) ? value : (decimal?)null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear text fields
            txtName.Clear();
            txtWeight.Clear();
            txtHeight.Clear();
            txtAge.Clear();
            txtWaist.Clear();
            txtWrist.Clear();
            txtHip.Clear();
            txtForearm.Clear();

            // Reset ComboBoxes
            cmbGender.SelectedIndex = -1;
            cmbActivityLevel.SelectedIndex = -1;

            // Hide female-specific fields
            grpFemaleInputs.Visible = false;

            // Clear output labels
            lblOutputName.Text = "";
            lblOutputWeight.Text = "";
            lblOutputHeight.Text = "";
            lblOutputAge.Text = "";
            lblOutputGender.Text = "";
            lblOutputBMR.Text = "";
            lblOutputActivityBMR.Text = "";
            lblOutputActivityLevel.Text = "";
            lblOutputBodyFat.Text = "";
        }


        // Creates a new user and adds them to the database
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            // Validate user input
            if (!ValidateUserInput(out string name, out decimal weight, out decimal height, out int age,
                                   out string gender, out decimal? waist, out decimal? wrist,
                                   out decimal? hip, out decimal? forearm))
            {
                MessageBox.Show("Please enter valid input for all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new User object (this calculates RMR, AMR, and BodyFatPercentage)
            User newUser = new User(name, weight, height, age, gender, waist, wrist, hip, forearm, cmbActivityLevel.SelectedIndex);

            string query = "INSERT INTO User_tbl (Name, Age, Height, Weight, Gender, Waist, Wrist, Hip, Forearm, ActivityLevel, RMR, AMR, BodyFatPercentage) " +
               "VALUES (@Name, @Age, @Height, @Weight, @Gender, @Waist, @Wrist, @Hip, @Forearm, @ActivityLevel, @RMR, @AMR, @BodyFat)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Height", height);
                    cmd.Parameters.AddWithValue("@Weight", weight);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Waist", (object)waist ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Wrist", (object)wrist ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Hip", (object)hip ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Forearm", (object)forearm ?? DBNull.Value);

                    // Assign Activity Level from ComboBox
                    cmd.Parameters.AddWithValue("@ActivityLevel", cmbActivityLevel.SelectedItem?.ToString() ?? "Unknown");

                    // Assign calculated values
                    cmd.Parameters.AddWithValue("@RMR", newUser.RMR);
                    cmd.Parameters.AddWithValue("@AMR", newUser.AMR);
                    cmd.Parameters.AddWithValue("@BodyFat", (object)newUser.BodyFatPercentage ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUsers();  // Refresh the list after adding a new user


        }
    }
}


