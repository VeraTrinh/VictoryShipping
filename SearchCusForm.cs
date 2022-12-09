using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VictoryShipping
{
    public partial class SearchCusForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=09207429-HONG; Initial Catalog=dbVictoryShipping; Integrated Security=True");
        public SearchCusForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.PARCEL' table. You can move, or remove it, as needed.
            this.pARCELTableAdapter.Fill(this.dataSet1.PARCEL);

        }

        private void searchtextbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (searchtextbox.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Sender, Receiver, SenderAddress, ReceiverAddress, ParcelType, Destination, Price, DriverName, Status FROM [dbo].[PARCEL] WHERE ParcelID=@ParcelID", con);
                cmd.Parameters.AddWithValue("@ParcelID", int.Parse(searchtextbox.Text));
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sender_display.Text = reader.GetValue(0).ToString();
                    receiver_display.Text = reader.GetValue(1).ToString();
                    senderadd_display.Text = reader.GetValue(2).ToString();
                    receiveradd_display.Text = reader.GetValue(3).ToString();
                    parceltype_display.Text = reader.GetValue(4).ToString();
                    destination_display.Text = reader.GetValue(5).ToString();
                    price_display.Text = reader.GetValue(6).ToString();
                    status_display.Text = reader.GetValue(8).ToString();
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter the Valid Tracking Number!!");
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            sender_display.Clear();
            receiver_display.Clear();
            senderadd_display.Clear();
            receiveradd_display.Clear();
            parceltype_display.Clear();
            destination_display.Clear();
            price_display.Clear();
            status_display.Clear();
        }
    }
}
