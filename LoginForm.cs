using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static VictoryShipping.BLL;

namespace VictoryShipping
{
    public partial class LoginForm : Form
    {
       
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                User user = new User();
                if (user.VerifyLogin(username_textbox.Text, password_textbox.Text))
                {
                    StaffForm form = new StaffForm();
                    form.Show();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("Please put valid username and password!");

                }
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}
    
