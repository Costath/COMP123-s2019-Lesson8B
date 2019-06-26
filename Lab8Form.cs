using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_s2019_Lesson8B
{
    public partial class Lab8Form : Form
    {
        // Class Properties
        public string UserName { get; set; }
        public float UserAge { get; set; }

        /// <summary>
        /// This is the Constructor for Lab08Form
        /// </summary>
        public Lab8Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the Event Handler for the Lab08Form Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab8Form_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        /// <summary>
        /// Event handler for the submit button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;

            /*
            float floatResult;
            bool result;
            result = float.TryParse(AgeTextBox.Text, out floatResult);
            UserAge = floatResult;
            */
            UserAge = float.Parse(AgeTextBox.Text);

            OutputLabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;

            ClearForm();
            
        }

        private void ClearForm()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
            SubmitButton.Enabled = false;
        }

        /// <summary>
        /// This is the Event Handler fot the AgeTextBox TextChanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            // simple input validation
            try
            {
                float.Parse(AgeTextBox.Text);
                SubmitButton.Enabled = true;
            }
            catch
            {
                SubmitButton.Enabled = false;
            }
        }


        /// <summary>
        /// This is the Event Handler for the NameTextBox TextChanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length <= 2) ? false : true;
            
        }
    }
}
