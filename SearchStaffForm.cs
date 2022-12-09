using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VictoryShipping
{
    public partial class SearchStaffForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=09207429-HONG; Initial Catalog=dbVictoryShipping; Integrated Security=True");
        public SearchStaffForm()
        {
            InitializeComponent();
        }

        private void SearchStaffForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.PARCEL' table. You can move, or remove it, as needed.
            this.pARCELTableAdapter.Fill(this.dataSet1.PARCEL);

        }

        private void searchtextbox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchtextbox.Text;
            try
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [dbo].[PARCEL]", con);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                con.Close();
                var num = from row in dt.AsEnumerable() where row[0].ToString().Contains(searchValue) select row;
                if (num.Count() == 0)
                {
                    MessageBox.Show("Please input valid parcel number");
                }
                else
                {
                    Parcel_DataView.DataSource = num.CopyToDataTable();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Bitmap bmp;

        private void print_btn_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void pdf_btn_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Admin\Downloads\PatientDetail.pdf", FileMode.Create));
            doc.Open();

            PdfPTable pdfTable = new PdfPTable(Parcel_DataView.ColumnCount);
            foreach (DataGridViewColumn column in Parcel_DataView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in Parcel_DataView.Rows)
            {
                foreach (DataGridViewCell celli in row.Cells)
                {
                    if (celli.Value != null)
                        pdfTable.AddCell(celli.Value.ToString());
                }
            }
            doc.Add(pdfTable);
            doc.Close();
            MessageBox.Show("Pdf file created successfully");
        }

        private void excel_btn_Click(object sender, EventArgs e)
        {
            Parcel_DataView.SelectAll();
            DataObject copydata = Parcel_DataView.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlwbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlwbook = xlapp.Workbooks.Add(miseddata);
            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlwbook.Worksheets.get_Item(1);

            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
