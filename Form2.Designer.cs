
namespace VictoryShipping
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.customer_btn = new System.Windows.Forms.Button();
            this.staff_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_btn
            // 
            this.customer_btn.BackColor = System.Drawing.Color.Goldenrod;
            this.customer_btn.ForeColor = System.Drawing.Color.White;
            this.customer_btn.Location = new System.Drawing.Point(540, 110);
            this.customer_btn.Name = "customer_btn";
            this.customer_btn.Size = new System.Drawing.Size(138, 62);
            this.customer_btn.TabIndex = 1;
            this.customer_btn.Text = "Customer";
            this.customer_btn.UseVisualStyleBackColor = false;
            this.customer_btn.Click += new System.EventHandler(this.customer_Click);
            // 
            // staff_btn
            // 
            this.staff_btn.BackColor = System.Drawing.Color.Black;
            this.staff_btn.ForeColor = System.Drawing.Color.White;
            this.staff_btn.Location = new System.Drawing.Point(540, 215);
            this.staff_btn.Name = "staff_btn";
            this.staff_btn.Size = new System.Drawing.Size(138, 62);
            this.staff_btn.TabIndex = 2;
            this.staff_btn.Text = "Staff";
            this.staff_btn.UseVisualStyleBackColor = false;
            this.staff_btn.Click += new System.EventHandler(this.staff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 71);
            this.label1.TabIndex = 4;
            this.label1.Text = "You Are ...";
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Black;
            this.back_btn.BackgroundImage = global::VictoryShipping.Properties.Resources.back;
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_btn.Location = new System.Drawing.Point(540, 325);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(138, 62);
            this.back_btn.TabIndex = 3;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::VictoryShipping.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = global::VictoryShipping.Properties.Resources.victorybackground;
            this.pictureBox1.Location = new System.Drawing.Point(25, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 388);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.staff_btn);
            this.Controls.Add(this.customer_btn);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Victory Shipping LTD";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button customer_btn;
        private System.Windows.Forms.Button staff_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label1;
    }
}