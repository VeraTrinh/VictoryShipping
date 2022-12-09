
namespace VictoryShipping
{
    partial class SearchStaffForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchStaffForm));
            this.label1 = new System.Windows.Forms.Label();
            this.searchtextbox = new System.Windows.Forms.TextBox();
            this.Parcel_DataView = new System.Windows.Forms.DataGridView();
            this.parcelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParcelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARCELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new VictoryShipping.DataSet1();
            this.pARCELTableAdapter = new VictoryShipping.DataSet1TableAdapters.PARCELTableAdapter();
            this.print_btn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pdf_btn = new System.Windows.Forms.Button();
            this.excel_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Parcel_DataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(121, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "SEARCH PARCEL NUMBER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchtextbox
            // 
            this.searchtextbox.Location = new System.Drawing.Point(149, 74);
            this.searchtextbox.Multiline = true;
            this.searchtextbox.Name = "searchtextbox";
            this.searchtextbox.Size = new System.Drawing.Size(522, 38);
            this.searchtextbox.TabIndex = 15;
            this.searchtextbox.TextChanged += new System.EventHandler(this.searchtextbox_TextChanged);
            // 
            // Parcel_DataView
            // 
            this.Parcel_DataView.AllowUserToAddRows = false;
            this.Parcel_DataView.AllowUserToDeleteRows = false;
            this.Parcel_DataView.AutoGenerateColumns = false;
            this.Parcel_DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Parcel_DataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parcelIDDataGridViewTextBoxColumn,
            this.ParcelType,
            this.senderDataGridViewTextBoxColumn,
            this.senderAddressDataGridViewTextBoxColumn,
            this.receiverDataGridViewTextBoxColumn,
            this.receiverAddressDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.warehouseDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.driverNameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.Parcel_DataView.DataSource = this.pARCELBindingSource;
            this.Parcel_DataView.Location = new System.Drawing.Point(12, 118);
            this.Parcel_DataView.Name = "Parcel_DataView";
            this.Parcel_DataView.RowHeadersWidth = 62;
            this.Parcel_DataView.RowTemplate.Height = 28;
            this.Parcel_DataView.Size = new System.Drawing.Size(776, 270);
            this.Parcel_DataView.TabIndex = 17;
            // 
            // parcelIDDataGridViewTextBoxColumn
            // 
            this.parcelIDDataGridViewTextBoxColumn.DataPropertyName = "ParcelID";
            this.parcelIDDataGridViewTextBoxColumn.HeaderText = "ParcelID";
            this.parcelIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.parcelIDDataGridViewTextBoxColumn.Name = "parcelIDDataGridViewTextBoxColumn";
            this.parcelIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // ParcelType
            // 
            this.ParcelType.DataPropertyName = "ParcelType";
            this.ParcelType.HeaderText = "ParcelType";
            this.ParcelType.MinimumWidth = 8;
            this.ParcelType.Name = "ParcelType";
            this.ParcelType.Width = 150;
            // 
            // senderDataGridViewTextBoxColumn
            // 
            this.senderDataGridViewTextBoxColumn.DataPropertyName = "Sender";
            this.senderDataGridViewTextBoxColumn.HeaderText = "Sender";
            this.senderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.senderDataGridViewTextBoxColumn.Name = "senderDataGridViewTextBoxColumn";
            this.senderDataGridViewTextBoxColumn.Width = 150;
            // 
            // senderAddressDataGridViewTextBoxColumn
            // 
            this.senderAddressDataGridViewTextBoxColumn.DataPropertyName = "SenderAddress";
            this.senderAddressDataGridViewTextBoxColumn.HeaderText = "SenderAddress";
            this.senderAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.senderAddressDataGridViewTextBoxColumn.Name = "senderAddressDataGridViewTextBoxColumn";
            this.senderAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // receiverDataGridViewTextBoxColumn
            // 
            this.receiverDataGridViewTextBoxColumn.DataPropertyName = "Receiver";
            this.receiverDataGridViewTextBoxColumn.HeaderText = "Receiver";
            this.receiverDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.receiverDataGridViewTextBoxColumn.Name = "receiverDataGridViewTextBoxColumn";
            this.receiverDataGridViewTextBoxColumn.Width = 150;
            // 
            // receiverAddressDataGridViewTextBoxColumn
            // 
            this.receiverAddressDataGridViewTextBoxColumn.DataPropertyName = "ReceiverAddress";
            this.receiverAddressDataGridViewTextBoxColumn.HeaderText = "ReceiverAddress";
            this.receiverAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.receiverAddressDataGridViewTextBoxColumn.Name = "receiverAddressDataGridViewTextBoxColumn";
            this.receiverAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.Width = 150;
            // 
            // warehouseDataGridViewTextBoxColumn
            // 
            this.warehouseDataGridViewTextBoxColumn.DataPropertyName = "Warehouse";
            this.warehouseDataGridViewTextBoxColumn.HeaderText = "Warehouse";
            this.warehouseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.warehouseDataGridViewTextBoxColumn.Name = "warehouseDataGridViewTextBoxColumn";
            this.warehouseDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // driverNameDataGridViewTextBoxColumn
            // 
            this.driverNameDataGridViewTextBoxColumn.DataPropertyName = "DriverName";
            this.driverNameDataGridViewTextBoxColumn.HeaderText = "DriverName";
            this.driverNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.driverNameDataGridViewTextBoxColumn.Name = "driverNameDataGridViewTextBoxColumn";
            this.driverNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // pARCELBindingSource
            // 
            this.pARCELBindingSource.DataMember = "PARCEL";
            this.pARCELBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pARCELTableAdapter
            // 
            this.pARCELTableAdapter.ClearBeforeFill = true;
            // 
            // print_btn
            // 
            this.print_btn.BackColor = System.Drawing.Color.Goldenrod;
            this.print_btn.Location = new System.Drawing.Point(36, 395);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(131, 43);
            this.print_btn.TabIndex = 18;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pdf_btn
            // 
            this.pdf_btn.BackColor = System.Drawing.Color.Goldenrod;
            this.pdf_btn.Location = new System.Drawing.Point(321, 395);
            this.pdf_btn.Name = "pdf_btn";
            this.pdf_btn.Size = new System.Drawing.Size(131, 43);
            this.pdf_btn.TabIndex = 19;
            this.pdf_btn.Text = "PDF";
            this.pdf_btn.UseVisualStyleBackColor = false;
            this.pdf_btn.Click += new System.EventHandler(this.pdf_btn_Click);
            // 
            // excel_btn
            // 
            this.excel_btn.BackColor = System.Drawing.Color.Goldenrod;
            this.excel_btn.Location = new System.Drawing.Point(634, 395);
            this.excel_btn.Name = "excel_btn";
            this.excel_btn.Size = new System.Drawing.Size(131, 43);
            this.excel_btn.TabIndex = 20;
            this.excel_btn.Text = "EXCEL";
            this.excel_btn.UseVisualStyleBackColor = false;
            this.excel_btn.Click += new System.EventHandler(this.excel_btn_Click);
            // 
            // SearchStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.excel_btn);
            this.Controls.Add(this.pdf_btn);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.Parcel_DataView);
            this.Controls.Add(this.searchtextbox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchStaffForm";
            this.Text = "Search - Victory Shipping";
            this.Load += new System.EventHandler(this.SearchStaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Parcel_DataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchtextbox;
        private System.Windows.Forms.DataGridView Parcel_DataView;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pARCELBindingSource;
        private DataSet1TableAdapters.PARCELTableAdapter pARCELTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button print_btn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button pdf_btn;
        private System.Windows.Forms.Button excel_btn;
    }
}