
namespace VictoryShipping
{
    partial class ParcelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParcelForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.parcelIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Parcel_DataView = new System.Windows.Forms.DataGridView();
            this.parcelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARCELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new VictoryShipping.DataSet1();
            this.label8 = new System.Windows.Forms.Label();
            this.parceltypeBox = new System.Windows.Forms.ComboBox();
            this.sendertextBox = new System.Windows.Forms.TextBox();
            this.receivertextBox = new System.Windows.Forms.TextBox();
            this.senderaddtextBox = new System.Windows.Forms.TextBox();
            this.receiveraddtextBox = new System.Windows.Forms.TextBox();
            this.destinationcomboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.drivertextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.warehousetextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.insert_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.exit_button = new System.Windows.Forms.Button();
            this.pARCELTableAdapter = new VictoryShipping.DataSet1TableAdapters.PARCELTableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.view_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Parcel_DataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // parcelIDTextBox
            // 
            resources.ApplyResources(this.parcelIDTextBox, "parcelIDTextBox");
            this.parcelIDTextBox.Name = "parcelIDTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // Parcel_DataView
            // 
            this.Parcel_DataView.AutoGenerateColumns = false;
            this.Parcel_DataView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Parcel_DataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Parcel_DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Parcel_DataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parcelIDDataGridViewTextBoxColumn,
            this.parcelTypeDataGridViewTextBoxColumn,
            this.senderDataGridViewTextBoxColumn,
            this.receiverDataGridViewTextBoxColumn,
            this.senderAddressDataGridViewTextBoxColumn,
            this.receiverAddressDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.warehouseDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.DriverName,
            this.Status});
            this.Parcel_DataView.DataSource = this.pARCELBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Parcel_DataView.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.Parcel_DataView, "Parcel_DataView");
            this.Parcel_DataView.Name = "Parcel_DataView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Parcel_DataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Parcel_DataView.RowTemplate.Height = 28;
            // 
            // parcelIDDataGridViewTextBoxColumn
            // 
            this.parcelIDDataGridViewTextBoxColumn.DataPropertyName = "ParcelID";
            resources.ApplyResources(this.parcelIDDataGridViewTextBoxColumn, "parcelIDDataGridViewTextBoxColumn");
            this.parcelIDDataGridViewTextBoxColumn.Name = "parcelIDDataGridViewTextBoxColumn";
            // 
            // parcelTypeDataGridViewTextBoxColumn
            // 
            this.parcelTypeDataGridViewTextBoxColumn.DataPropertyName = "ParcelType";
            resources.ApplyResources(this.parcelTypeDataGridViewTextBoxColumn, "parcelTypeDataGridViewTextBoxColumn");
            this.parcelTypeDataGridViewTextBoxColumn.Name = "parcelTypeDataGridViewTextBoxColumn";
            // 
            // senderDataGridViewTextBoxColumn
            // 
            this.senderDataGridViewTextBoxColumn.DataPropertyName = "Sender";
            resources.ApplyResources(this.senderDataGridViewTextBoxColumn, "senderDataGridViewTextBoxColumn");
            this.senderDataGridViewTextBoxColumn.Name = "senderDataGridViewTextBoxColumn";
            // 
            // receiverDataGridViewTextBoxColumn
            // 
            this.receiverDataGridViewTextBoxColumn.DataPropertyName = "Receiver";
            resources.ApplyResources(this.receiverDataGridViewTextBoxColumn, "receiverDataGridViewTextBoxColumn");
            this.receiverDataGridViewTextBoxColumn.Name = "receiverDataGridViewTextBoxColumn";
            // 
            // senderAddressDataGridViewTextBoxColumn
            // 
            this.senderAddressDataGridViewTextBoxColumn.DataPropertyName = "SenderAddress";
            resources.ApplyResources(this.senderAddressDataGridViewTextBoxColumn, "senderAddressDataGridViewTextBoxColumn");
            this.senderAddressDataGridViewTextBoxColumn.Name = "senderAddressDataGridViewTextBoxColumn";
            // 
            // receiverAddressDataGridViewTextBoxColumn
            // 
            this.receiverAddressDataGridViewTextBoxColumn.DataPropertyName = "ReceiverAddress";
            resources.ApplyResources(this.receiverAddressDataGridViewTextBoxColumn, "receiverAddressDataGridViewTextBoxColumn");
            this.receiverAddressDataGridViewTextBoxColumn.Name = "receiverAddressDataGridViewTextBoxColumn";
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            resources.ApplyResources(this.destinationDataGridViewTextBoxColumn, "destinationDataGridViewTextBoxColumn");
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // warehouseDataGridViewTextBoxColumn
            // 
            this.warehouseDataGridViewTextBoxColumn.DataPropertyName = "Warehouse";
            resources.ApplyResources(this.warehouseDataGridViewTextBoxColumn, "warehouseDataGridViewTextBoxColumn");
            this.warehouseDataGridViewTextBoxColumn.Name = "warehouseDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            resources.ApplyResources(this.priceDataGridViewTextBoxColumn, "priceDataGridViewTextBoxColumn");
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            resources.ApplyResources(this.dateDataGridViewTextBoxColumn, "dateDataGridViewTextBoxColumn");
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // DriverName
            // 
            this.DriverName.DataPropertyName = "DriverName";
            resources.ApplyResources(this.DriverName, "DriverName");
            this.DriverName.Name = "DriverName";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            resources.ApplyResources(this.Status, "Status");
            this.Status.Name = "Status";
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
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // parceltypeBox
            // 
            this.parceltypeBox.FormattingEnabled = true;
            this.parceltypeBox.Items.AddRange(new object[] {
            resources.GetString("parceltypeBox.Items"),
            resources.GetString("parceltypeBox.Items1"),
            resources.GetString("parceltypeBox.Items2"),
            resources.GetString("parceltypeBox.Items3")});
            resources.ApplyResources(this.parceltypeBox, "parceltypeBox");
            this.parceltypeBox.Name = "parceltypeBox";
            this.parceltypeBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sendertextBox
            // 
            resources.ApplyResources(this.sendertextBox, "sendertextBox");
            this.sendertextBox.Name = "sendertextBox";
            // 
            // receivertextBox
            // 
            resources.ApplyResources(this.receivertextBox, "receivertextBox");
            this.receivertextBox.Name = "receivertextBox";
            // 
            // senderaddtextBox
            // 
            resources.ApplyResources(this.senderaddtextBox, "senderaddtextBox");
            this.senderaddtextBox.Name = "senderaddtextBox";
            // 
            // receiveraddtextBox
            // 
            resources.ApplyResources(this.receiveraddtextBox, "receiveraddtextBox");
            this.receiveraddtextBox.Name = "receiveraddtextBox";
            // 
            // destinationcomboBox
            // 
            this.destinationcomboBox.FormattingEnabled = true;
            this.destinationcomboBox.Items.AddRange(new object[] {
            resources.GetString("destinationcomboBox.Items"),
            resources.GetString("destinationcomboBox.Items1"),
            resources.GetString("destinationcomboBox.Items2")});
            resources.ApplyResources(this.destinationcomboBox, "destinationcomboBox");
            this.destinationcomboBox.Name = "destinationcomboBox";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // drivertextBox
            // 
            resources.ApplyResources(this.drivertextBox, "drivertextBox");
            this.drivertextBox.Name = "drivertextBox";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // warehousetextBox
            // 
            resources.ApplyResources(this.warehousetextBox, "warehousetextBox");
            this.warehousetextBox.Name = "warehousetextBox";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // pricetextBox
            // 
            resources.ApplyResources(this.pricetextBox, "pricetextBox");
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.Click += new System.EventHandler(this.pricetextBox_Click);
            this.pricetextBox.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // insert_button
            // 
            this.insert_button.BackColor = System.Drawing.Color.Goldenrod;
            this.insert_button.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.insert_button, "insert_button");
            this.insert_button.Name = "insert_button";
            this.insert_button.UseVisualStyleBackColor = false;
            this.insert_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.Goldenrod;
            this.update_button.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.update_button, "update_button");
            this.update_button.Name = "update_button";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // del_button
            // 
            this.del_button.BackColor = System.Drawing.Color.Black;
            this.del_button.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.del_button, "del_button");
            this.del_button.Name = "del_button";
            this.del_button.UseVisualStyleBackColor = false;
            this.del_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Value = new System.DateTime(2022, 3, 21, 0, 0, 0, 0);
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Red;
            this.exit_button.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.exit_button, "exit_button");
            this.exit_button.Name = "exit_button";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.button6_Click);
            // 
            // pARCELTableAdapter
            // 
            this.pARCELTableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            resources.GetString("StatusComboBox.Items"),
            resources.GetString("StatusComboBox.Items1"),
            resources.GetString("StatusComboBox.Items2"),
            resources.GetString("StatusComboBox.Items3"),
            resources.GetString("StatusComboBox.Items4"),
            resources.GetString("StatusComboBox.Items5")});
            resources.ApplyResources(this.StatusComboBox, "StatusComboBox");
            this.StatusComboBox.Name = "StatusComboBox";
            // 
            // view_button
            // 
            this.view_button.BackColor = System.Drawing.Color.Goldenrod;
            this.view_button.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.view_button, "view_button");
            this.view_button.Name = "view_button";
            this.view_button.UseVisualStyleBackColor = false;
            this.view_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.DarkCyan;
            this.clear_button.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.clear_button, "clear_button");
            this.clear_button.Name = "clear_button";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ParcelForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.view_button);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.pricetextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.warehousetextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.drivertextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.destinationcomboBox);
            this.Controls.Add(this.receiveraddtextBox);
            this.Controls.Add(this.senderaddtextBox);
            this.Controls.Add(this.receivertextBox);
            this.Controls.Add(this.sendertextBox);
            this.Controls.Add(this.parceltypeBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Parcel_DataView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parcelIDTextBox);
            this.Name = "ParcelForm";
            this.Load += new System.EventHandler(this.NewParcelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Parcel_DataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox parcelIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView Parcel_DataView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox parceltypeBox;
        private System.Windows.Forms.TextBox sendertextBox;
        private System.Windows.Forms.TextBox receivertextBox;
        private System.Windows.Forms.TextBox senderaddtextBox;
        private System.Windows.Forms.TextBox receiveraddtextBox;
        private System.Windows.Forms.ComboBox destinationcomboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox drivertextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox warehousetextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pARCELBindingSource;
        private DataSet1TableAdapters.PARCELTableAdapter pARCELTableAdapter;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Button view_button;
        private System.Windows.Forms.Button clear_button;
    }
}