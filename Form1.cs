using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter_assignment_basic_input
{
    public partial class BasicInput : Form
    {
        string name;
        int age;
        double height;
        public BasicInput()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            age = Convert.ToInt32(numAge.Value);
            lblNameMsg.Text = $"Hello {name}!";
            lblAgeMsg.Text = $"You are {82 - age} years younger than the average life expectancy... Good Luck!";
            bool check = double.TryParse(txtHeight.Text, out height);
            if (check)
            {
                lblHeightMsg.Text = $"You're {Math.Round(2.72 - height, 2)}m shorter than the tallest person. Jealous?";
            }
            else
            {
                lblHeightMsg.Text = "Please put an actual number in the height box. Thanks";
            }
        }
    }
}
