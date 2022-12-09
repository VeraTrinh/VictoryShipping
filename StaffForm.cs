using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VictoryShipping
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void NewParcel_btn_Click(object sender, EventArgs e)
        {
            ParcelForm form = new ParcelForm();
            form.ShowDialog();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            SearchStaffForm form = new SearchStaffForm();
            form.ShowDialog();
        }
    }
}
