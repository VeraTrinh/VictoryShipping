
namespace VictoryShipping
{
    partial class SearchCusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCusForm));
            this.label1 = new System.Windows.Forms.Label();
            this.searchtextbox = new System.Windows.Forms.TextBox();
            this.pARCELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new VictoryShipping.DataSet1();
            this.pARCELTableAdapter = new VictoryShipping.DataSet1TableAdapters.PARCELTableAdapter();
            this.search_btn = new System.Windows.Forms.Button();
            this.sender_display = new System.Windows.Forms.RichTextBox();
            this.receiver_display = new System.Windows.Forms.RichTextBox();
            this.senderadd_display = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.receiveradd_display = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.status_display = new System.Windows.Forms.RichTextBox();
            this.price_display = new System.Windows.Forms.RichTextBox();
            this.parceltype_display = new System.Windows.Forms.RichTextBox();
            this.destination_display = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(82, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(672, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "PLEASE ENTER YOUR PARCEL NUMBER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchtextbox
            // 
            this.searchtextbox.Location = new System.Drawing.Point(75, 71);
            this.searchtextbox.Multiline = true;
            this.searchtextbox.Name = "searchtextbox";
            this.searchtextbox.Size = new System.Drawing.Size(522, 38);
            this.searchtextbox.TabIndex = 14;
            this.searchtextbox.TextChanged += new System.EventHandler(this.searchtextbox_TextChanged);
            // 
            // pARCELBindingSource
            // 
            this.pARCELBindingSource.DataMember = "PARCEL";
            this.pARCELBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
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
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Goldenrod;
            this.search_btn.ForeColor = System.Drawing.Color.Black;
            this.search_btn.Location = new System.Drawing.Point(626, 71);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(128, 38);
            this.search_btn.TabIndex = 15;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // sender_display
            // 
            this.sender_display.Location = new System.Drawing.Point(135, 158);
            this.sender_display.Name = "sender_display";
            this.sender_display.Size = new System.Drawing.Size(174, 29);
            this.sender_display.TabIndex = 16;
            this.sender_display.Text = "";
            // 
            // receiver_display
            // 
            this.receiver_display.Location = new System.Drawing.Point(135, 212);
            this.receiver_display.Name = "receiver_display";
            this.receiver_display.Size = new System.Drawing.Size(174, 30);
            this.receiver_display.TabIndex = 17;
            this.receiver_display.Text = "";
            // 
            // senderadd_display
            // 
            this.senderadd_display.Location = new System.Drawing.Point(17, 302);
            this.senderadd_display.Name = "senderadd_display";
            this.senderadd_display.Size = new System.Drawing.Size(292, 32);
            this.senderadd_display.TabIndex = 18;
            this.senderadd_display.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Receiver";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Sender\'s Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(12, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "Receiver\'s Address";
            // 
            // receiveradd_display
            // 
            this.receiveradd_display.Location = new System.Drawing.Point(17, 379);
            this.receiveradd_display.Name = "receiveradd_display";
            this.receiveradd_display.Size = new System.Drawing.Size(292, 32);
            this.receiveradd_display.TabIndex = 25;
            this.receiveradd_display.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(423, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 29);
            this.label11.TabIndex = 26;
            this.label11.Text = "Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(423, 332);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 29);
            this.label13.TabIndex = 35;
            this.label13.Text = "Status";
            // 
            // status_display
            // 
            this.status_display.Location = new System.Drawing.Point(596, 331);
            this.status_display.Name = "status_display";
            this.status_display.Size = new System.Drawing.Size(174, 30);
            this.status_display.TabIndex = 36;
            this.status_display.Text = "";
            // 
            // price_display
            // 
            this.price_display.Location = new System.Drawing.Point(596, 266);
            this.price_display.Name = "price_display";
            this.price_display.Size = new System.Drawing.Size(174, 30);
            this.price_display.TabIndex = 37;
            this.price_display.Text = "";
            // 
            // parceltype_display
            // 
            this.parceltype_display.Location = new System.Drawing.Point(596, 157);
            this.parceltype_display.Name = "parceltype_display";
            this.parceltype_display.Size = new System.Drawing.Size(174, 30);
            this.parceltype_display.TabIndex = 40;
            this.parceltype_display.Text = "";
            // 
            // destination_display
            // 
            this.destination_display.Location = new System.Drawing.Point(596, 213);
            this.destination_display.Name = "destination_display";
            this.destination_display.Size = new System.Drawing.Size(174, 30);
            this.destination_display.TabIndex = 41;
            this.destination_display.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(423, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 29);
            this.label3.TabIndex = 42;
            this.label3.Text = "Parcel Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(423, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 29);
            this.label7.TabIndex = 43;
            this.label7.Text = "Destination";
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.Black;
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clear_btn.Location = new System.Drawing.Point(536, 379);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(126, 49);
            this.clear_btn.TabIndex = 44;
            this.clear_btn.Text = "CLEAR";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // SearchCusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.destination_display);
            this.Controls.Add(this.parceltype_display);
            this.Controls.Add(this.price_display);
            this.Controls.Add(this.status_display);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.receiveradd_display);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.senderadd_display);
            this.Controls.Add(this.receiver_display);
            this.Controls.Add(this.sender_display);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.searchtextbox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchCusForm";
            this.Text = "Search For Customer";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pARCELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchtextbox;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pARCELBindingSource;
        private DataSet1TableAdapters.PARCELTableAdapter pARCELTableAdapter;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.RichTextBox sender_display;
        private System.Windows.Forms.RichTextBox receiver_display;
        private System.Windows.Forms.RichTextBox senderadd_display;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox receiveradd_display;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox status_display;
        private System.Windows.Forms.RichTextBox price_display;
        private System.Windows.Forms.RichTextBox parceltype_display;
        private System.Windows.Forms.RichTextBox destination_display;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button clear_btn;
    }
}