namespace WF1
{
    partial class proposedplantcapacity
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_effective_area = new System.Windows.Forms.Label();
            this.lbl_max_capacity = new System.Windows.Forms.Label();
            this.lbl_proposed_capacity = new System.Windows.Forms.Label();
            this.lbl_1st_page = new System.Windows.Forms.Label();
            this.lbl_avail_rooftop = new System.Windows.Forms.Label();
            this.effective_area = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proposed Plant Capacity feasibility check in terms of available Area:-";
            // 
            // lbl_effective_area
            // 
            this.lbl_effective_area.AutoSize = true;
            this.lbl_effective_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_effective_area.Location = new System.Drawing.Point(30, 184);
            this.lbl_effective_area.Name = "lbl_effective_area";
            this.lbl_effective_area.Size = new System.Drawing.Size(459, 18);
            this.lbl_effective_area.TabIndex = 2;
            this.lbl_effective_area.Text = "Effictive area (@40%) for roof-top installation as assumed by MNRE:";
            // 
            // lbl_max_capacity
            // 
            this.lbl_max_capacity.AutoSize = true;
            this.lbl_max_capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_max_capacity.Location = new System.Drawing.Point(30, 232);
            this.lbl_max_capacity.Name = "lbl_max_capacity";
            this.lbl_max_capacity.Size = new System.Drawing.Size(709, 18);
            this.lbl_max_capacity.TabIndex = 3;
            this.lbl_max_capacity.Text = "Maximum capacity of solar roof-top plant that can be constructed approximately in" +
                " kiloWatts from the table:";
            // 
            // lbl_proposed_capacity
            // 
            this.lbl_proposed_capacity.AutoSize = true;
            this.lbl_proposed_capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proposed_capacity.Location = new System.Drawing.Point(30, 278);
            this.lbl_proposed_capacity.Name = "lbl_proposed_capacity";
            this.lbl_proposed_capacity.Size = new System.Drawing.Size(347, 18);
            this.lbl_proposed_capacity.TabIndex = 4;
            this.lbl_proposed_capacity.Text = "Proposed capacity from the borrower side in kWatt:";
            // 
            // lbl_1st_page
            // 
            this.lbl_1st_page.AutoSize = true;
            this.lbl_1st_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1st_page.Location = new System.Drawing.Point(806, 143);
            this.lbl_1st_page.Name = "lbl_1st_page";
            this.lbl_1st_page.Size = new System.Drawing.Size(92, 18);
            this.lbl_1st_page.TabIndex = 5;
            this.lbl_1st_page.Text = "From page 1";
            this.lbl_1st_page.Click += new System.EventHandler(this.lbl_1st_page_Click);
            // 
            // lbl_avail_rooftop
            // 
            this.lbl_avail_rooftop.AutoSize = true;
            this.lbl_avail_rooftop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avail_rooftop.Location = new System.Drawing.Point(30, 143);
            this.lbl_avail_rooftop.Name = "lbl_avail_rooftop";
            this.lbl_avail_rooftop.Size = new System.Drawing.Size(391, 18);
            this.lbl_avail_rooftop.TabIndex = 6;
            this.lbl_avail_rooftop.Text = "Available rooftop area in sq-ft as informed by the borrower:";
            // 
            // effective_area
            // 
            this.effective_area.Location = new System.Drawing.Point(809, 176);
            this.effective_area.Name = "effective_area";
            this.effective_area.Size = new System.Drawing.Size(122, 20);
            this.effective_area.TabIndex = 7;
            this.effective_area.TextChanged += new System.EventHandler(this.effective_area_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(809, 230);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(809, 279);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WF1.Properties.Resources._2nd_pg;
            this.pictureBox1.Location = new System.Drawing.Point(5, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(966, 134);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // proposedplantcapacity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 573);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.effective_area);
            this.Controls.Add(this.lbl_avail_rooftop);
            this.Controls.Add(this.lbl_1st_page);
            this.Controls.Add(this.lbl_proposed_capacity);
            this.Controls.Add(this.lbl_max_capacity);
            this.Controls.Add(this.lbl_effective_area);
            this.Controls.Add(this.label1);
            this.Name = "proposedplantcapacity";
            this.Text = "proposedplantcapacity";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_effective_area;
        private System.Windows.Forms.Label lbl_max_capacity;
        private System.Windows.Forms.Label lbl_proposed_capacity;
        private System.Windows.Forms.Label lbl_1st_page;
        private System.Windows.Forms.Label lbl_avail_rooftop;
        private System.Windows.Forms.TextBox effective_area;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}