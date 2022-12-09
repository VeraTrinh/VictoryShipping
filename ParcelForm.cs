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
using static VictoryShipping.BLL;

namespace VictoryShipping
{
    public partial class ParcelForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=09207429-HONG; Initial Catalog=dbVictoryShipping; Integrated Security=True");
        public ParcelForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewParcelForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.PARCEL' table. You can move, or remove it, as needed.
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchStaffForm form = new SearchStaffForm();
            form.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parcel parcel = new Parcel();
            try { 
            if (parcel.InsertParcel(int.Parse(parcelIDTextBox.Text), parceltypeBox.SelectedItem.ToString(), sendertextBox.Text, receivertextBox.Text, senderaddtextBox.Text, receiveraddtextBox.Text, destinationcomboBox.SelectedItem.ToString(), warehousetextBox.Text, int.Parse(pricetextBox.Text), DateTime.Parse(dateTimePicker1.Text), drivertextBox.Text, StatusComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("Insert new parcel is successful");
            }
            else
                MessageBox.Show("Insert new parcel is NOT successful");

            }
            catch
            {
                MessageBox.Show("Please input the values in correct form.");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            drivertextBox.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            drivertextBox.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffForm form = new StaffForm();
            form.ShowDialog();
        }

        private void pricetextBox_Click(object sender, EventArgs e)
        {
            int drum = 50;
            int box = 100;
            int pallet = 150;
            int container = 200;
            int tonga = 100;
            int fiji = 110;
            int samoa = 120;
            int pickup = 20;

            if (radioButton1.Checked == true)
            {
                if (parceltypeBox.SelectedItem.ToString() == "DRUM(50$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-TONGA(100$)")
                {
                    pricetextBox.Text = (drum + tonga + pickup).ToString();
                }

                else if (parceltypeBox.SelectedItem.ToString() == "DRUM(50$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-FIJI(110$)")
                {
                    pricetextBox.Text = (drum + fiji + pickup).ToString();
                }

                else if (parceltypeBox.SelectedItem.ToString() == "DRUM(50$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-SAMOA(120$)")
                {
                    pricetextBox.Text = (drum + samoa + pickup).ToString();
                }
                else if (parceltypeBox.SelectedItem.ToString() == "BOX(100$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-TONGA(100$)")
                {
                    pricetextBox.Text = (box + tonga + pickup).ToString();
                }

                else if (parceltypeBox.SelectedItem.ToString() == "BOX(100$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-FIJI(110$)")
                {
                    pricetextBox.Text = (box + fiji + pickup).ToString();
                }

                else if (parceltypeBox.SelectedItem.ToString() == "BOX(100$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-SAMOA(120$)")
                {
                    pricetextBox.Text = (box + samoa + pickup).ToString();
                }

                else if (parceltypeBox.SelectedItem.ToString() == "PALETTE(150$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-TONGA(100$)")
                {
                    pricetextBox.Text = (pallet + tonga + pickup).ToString();
                }

                else if (parceltypeBox.SelectedItem.ToString() == "PALETTE(150$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-FIJI(110$)")
                {
                    pricetextBox.Text = (pallet + fiji + pickup).ToString();
                }

                else if (parceltypeBox.SelectedItem.ToString() == "PALETTE(150$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-SAMOA(120$)")
                {
                    pricetextBox.Text = (pallet + samoa + pickup).ToString();
                }

                else if (parceltypeBox.SelectedItem.ToString() == "CONTAINER(200$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-TONGA(100$)")
                {
                    pricetextBox.Text = (container + tonga + pickup).ToString();
                }

                else if (parceltypeBox.SelectedItem.ToString() == "CONTAINER(200$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-FIJI(110$)")
                {
                    pricetextBox.Text = (container + fiji + pickup).ToString();
                }

                else if (parceltypeBox.SelectedItem.ToString() == "CONTAINER(200$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-SAMOA(120$)")
                {
                    pricetextBox.Text = (container + samoa + pickup).ToString();
                }
            }
            else
                if (parceltypeBox.SelectedItem.ToString() == "DRUM(50$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-TONGA(100$)")
            {
                pricetextBox.Text = (drum + tonga).ToString();
            }

            else if (parceltypeBox.SelectedItem.ToString() == "DRUM(50$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-FIJI(110$)")
            {
                pricetextBox.Text = (drum + fiji).ToString();
            }

            else if (parceltypeBox.SelectedItem.ToString() == "DRUM(50$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-SAMOA(120$)")
            {
                pricetextBox.Text = (drum + samoa).ToString();
            }

            else if (parceltypeBox.SelectedItem.ToString() == "BOX(100$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-TONGA(100$)")
            {
                pricetextBox.Text = (box + tonga).ToString();
            }

            else if (parceltypeBox.SelectedItem.ToString() == "BOX(100$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-FIJI(110$)")
            {
                pricetextBox.Text = (box + fiji).ToString();
            }

            else if (parceltypeBox.SelectedItem.ToString() == "BOX(100$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-SAMOA(120$)")
            {
                pricetextBox.Text = (box + samoa).ToString();
            }


            else if (parceltypeBox.SelectedItem.ToString() == "PALETTE(150$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-TONGA(100$)")
            {
                pricetextBox.Text = (pallet + tonga).ToString();
            }

            else if (parceltypeBox.SelectedItem.ToString() == "PALETTE(150$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-FIJI(110$)")
            {
                pricetextBox.Text = (pallet + fiji).ToString();
            }

            else if (parceltypeBox.SelectedItem.ToString() == "PALETTE(150$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-SAMOA(120$)")
            {
                pricetextBox.Text = (pallet + samoa).ToString();
            }

            else if (parceltypeBox.SelectedItem.ToString() == "CONTAINER(200$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-TONGA(100$)")
            {
                pricetextBox.Text = (container + tonga).ToString();
            }

            else if (parceltypeBox.SelectedItem.ToString() == "CONTAINER(200$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-FIJI(110$)")
            {
                pricetextBox.Text = (container + fiji).ToString();
            }

            else if (parceltypeBox.SelectedItem.ToString() == "CONTAINER(200$)" && destinationcomboBox.SelectedItem.ToString() == "AUCKLAND-SAMOA(120$)")
            {
                pricetextBox.Text = (container + samoa).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [dbo].[PARCEL]", con);
            DataTable num = new DataTable();
            sqlDa.Fill(num);

            Parcel_DataView.DataSource = num;
            con.Close();
            Parcel_DataView.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Parcel parcel = new Parcel();
            try { 
                    if (parcel.UpdateParcel(int.Parse(parcelIDTextBox.Text), parceltypeBox.SelectedItem.ToString(), sendertextBox.Text, receivertextBox.Text, senderaddtextBox.Text, receiveraddtextBox.Text, destinationcomboBox.SelectedItem.ToString(), warehousetextBox.Text, int.Parse(pricetextBox.Text), DateTime.Parse(dateTimePicker1.Text), drivertextBox.Text, StatusComboBox.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Parcel is updated successful");
                    }
                    else
                        MessageBox.Show("Parcel is NOT updated successful");
                }
            catch
            {
                MessageBox.Show("You might input wrong parcel ID or input the wrong form of parcel details.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Parcel parcel = new Parcel();
            try
            {
                if (parcel.DeleteParcel(int.Parse(parcelIDTextBox.Text)))
                {
                    MessageBox.Show("Delete is successful");
                }
                else
                    MessageBox.Show("Delete is NOT successful");
            }
            catch
            {
                MessageBox.Show("Please input the correct parcel ID to delete.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            parcelIDTextBox.Clear();
            sendertextBox.Clear();
            receivertextBox.Clear();
            senderaddtextBox.Clear();
            receiveraddtextBox.Clear();
            warehousetextBox.Clear();
            pricetextBox.Clear();
            drivertextBox.Clear();
        }
    }
}
