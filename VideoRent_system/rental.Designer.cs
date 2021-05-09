namespace VideoRent_system
{
    partial class rental
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
            this.rentalGrid = new System.Windows.Forms.DataGridView();
            this.datereturned_date = new System.Windows.Forms.Label();
            this.rentedate_label = new System.Windows.Forms.Label();
            this.custid_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rmid_label = new System.Windows.Forms.Label();
            this.returndate_text = new System.Windows.Forms.TextBox();
            this.rentdate_text = new System.Windows.Forms.TextBox();
            this.Custid_text = new System.Windows.Forms.TextBox();
            this.movieid_text = new System.Windows.Forms.TextBox();
            this.RMID_text = new System.Windows.Forms.TextBox();
            this.rentedout_ = new System.Windows.Forms.RadioButton();
            this.allrent_radio = new System.Windows.Forms.RadioButton();
            this.return_button = new System.Windows.Forms.Button();
            this.issue_button = new System.Windows.Forms.Button();
            this.Best_buy = new System.Windows.Forms.Button();
            this.Top_buy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rentalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // rentalGrid
            // 
            this.rentalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalGrid.Location = new System.Drawing.Point(-1, 0);
            this.rentalGrid.Name = "rentalGrid";
            this.rentalGrid.RowHeadersWidth = 51;
            this.rentalGrid.RowTemplate.Height = 24;
            this.rentalGrid.Size = new System.Drawing.Size(805, 519);
            this.rentalGrid.TabIndex = 75;
            this.rentalGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rentalGrid_CellContentClick);
            this.rentalGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rentalGrid_CellContentClick);
            // 
            // datereturned_date
            // 
            this.datereturned_date.AutoSize = true;
            this.datereturned_date.Location = new System.Drawing.Point(839, 315);
            this.datereturned_date.Name = "datereturned_date";
            this.datereturned_date.Size = new System.Drawing.Size(101, 17);
            this.datereturned_date.TabIndex = 89;
            this.datereturned_date.Text = "Date Returned";
            // 
            // rentedate_label
            // 
            this.rentedate_label.AutoSize = true;
            this.rentedate_label.Location = new System.Drawing.Point(839, 275);
            this.rentedate_label.Name = "rentedate_label";
            this.rentedate_label.Size = new System.Drawing.Size(88, 17);
            this.rentedate_label.TabIndex = 88;
            this.rentedate_label.Text = "Rented Date";
            // 
            // custid_label
            // 
            this.custid_label.AutoSize = true;
            this.custid_label.Location = new System.Drawing.Point(839, 227);
            this.custid_label.Name = "custid_label";
            this.custid_label.Size = new System.Drawing.Size(49, 17);
            this.custid_label.TabIndex = 87;
            this.custid_label.Text = "CustID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(839, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 86;
            this.label1.Text = "MovieID";
            // 
            // rmid_label
            // 
            this.rmid_label.AutoSize = true;
            this.rmid_label.Location = new System.Drawing.Point(846, 142);
            this.rmid_label.Name = "rmid_label";
            this.rmid_label.Size = new System.Drawing.Size(42, 17);
            this.rmid_label.TabIndex = 85;
            this.rmid_label.Text = "RMID";
            // 
            // returndate_text
            // 
            this.returndate_text.Location = new System.Drawing.Point(996, 315);
            this.returndate_text.Name = "returndate_text";
            this.returndate_text.Size = new System.Drawing.Size(100, 22);
            this.returndate_text.TabIndex = 84;
            // 
            // rentdate_text
            // 
            this.rentdate_text.Location = new System.Drawing.Point(996, 272);
            this.rentdate_text.Name = "rentdate_text";
            this.rentdate_text.Size = new System.Drawing.Size(100, 22);
            this.rentdate_text.TabIndex = 83;
            // 
            // Custid_text
            // 
            this.Custid_text.Location = new System.Drawing.Point(996, 227);
            this.Custid_text.Name = "Custid_text";
            this.Custid_text.Size = new System.Drawing.Size(100, 22);
            this.Custid_text.TabIndex = 82;
            // 
            // movieid_text
            // 
            this.movieid_text.Location = new System.Drawing.Point(996, 183);
            this.movieid_text.Name = "movieid_text";
            this.movieid_text.Size = new System.Drawing.Size(100, 22);
            this.movieid_text.TabIndex = 81;
            // 
            // RMID_text
            // 
            this.RMID_text.Location = new System.Drawing.Point(996, 137);
            this.RMID_text.Name = "RMID_text";
            this.RMID_text.Size = new System.Drawing.Size(100, 22);
            this.RMID_text.TabIndex = 80;
            // 
            // rentedout_
            // 
            this.rentedout_.AutoSize = true;
            this.rentedout_.Location = new System.Drawing.Point(994, 378);
            this.rentedout_.Name = "rentedout_";
            this.rentedout_.Size = new System.Drawing.Size(102, 21);
            this.rentedout_.TabIndex = 79;
            this.rentedout_.TabStop = true;
            this.rentedout_.Text = "Out Rented";
            this.rentedout_.UseVisualStyleBackColor = true;
            this.rentedout_.CheckedChanged += new System.EventHandler(this.rentedout__CheckedChanged);
            // 
            // allrent_radio
            // 
            this.allrent_radio.AutoSize = true;
            this.allrent_radio.Location = new System.Drawing.Point(846, 378);
            this.allrent_radio.Name = "allrent_radio";
            this.allrent_radio.Size = new System.Drawing.Size(94, 21);
            this.allrent_radio.TabIndex = 78;
            this.allrent_radio.TabStop = true;
            this.allrent_radio.Text = "All Rented";
            this.allrent_radio.UseVisualStyleBackColor = true;
            this.allrent_radio.CheckedChanged += new System.EventHandler(this.allrent_radio_CheckedChanged);
            // 
            // return_button
            // 
            this.return_button.Location = new System.Drawing.Point(846, 476);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(121, 43);
            this.return_button.TabIndex = 77;
            this.return_button.Text = "Return Movie";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // issue_button
            // 
            this.issue_button.Location = new System.Drawing.Point(846, 416);
            this.issue_button.Name = "issue_button";
            this.issue_button.Size = new System.Drawing.Size(121, 43);
            this.issue_button.TabIndex = 76;
            this.issue_button.Text = "Issue Movie";
            this.issue_button.UseVisualStyleBackColor = true;
            this.issue_button.Click += new System.EventHandler(this.issue_button_Click);
            // 
            // Best_buy
            // 
            this.Best_buy.Location = new System.Drawing.Point(993, 476);
            this.Best_buy.Name = "Best_buy";
            this.Best_buy.Size = new System.Drawing.Size(122, 43);
            this.Best_buy.TabIndex = 94;
            this.Best_buy.Text = "Best Buy";
            this.Best_buy.UseVisualStyleBackColor = true;
            this.Best_buy.Click += new System.EventHandler(this.Best_buy_Click);
            // 
            // Top_buy
            // 
            this.Top_buy.Location = new System.Drawing.Point(994, 416);
            this.Top_buy.Name = "Top_buy";
            this.Top_buy.Size = new System.Drawing.Size(121, 43);
            this.Top_buy.TabIndex = 93;
            this.Top_buy.Text = "Top Movie";
            this.Top_buy.UseVisualStyleBackColor = true;
            this.Top_buy.Click += new System.EventHandler(this.Top_buy_Click);
            // 
            // rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1127, 531);
            this.Controls.Add(this.Best_buy);
            this.Controls.Add(this.Top_buy);
            this.Controls.Add(this.datereturned_date);
            this.Controls.Add(this.rentedate_label);
            this.Controls.Add(this.custid_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rmid_label);
            this.Controls.Add(this.returndate_text);
            this.Controls.Add(this.rentdate_text);
            this.Controls.Add(this.Custid_text);
            this.Controls.Add(this.movieid_text);
            this.Controls.Add(this.RMID_text);
            this.Controls.Add(this.rentedout_);
            this.Controls.Add(this.allrent_radio);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.issue_button);
            this.Controls.Add(this.rentalGrid);
            this.Name = "rental";
            this.Text = "rental";
            this.Load += new System.EventHandler(this.rental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentalGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rentalGrid;
        private System.Windows.Forms.Label datereturned_date;
        private System.Windows.Forms.Label rentedate_label;
        private System.Windows.Forms.Label custid_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rmid_label;
        private System.Windows.Forms.TextBox returndate_text;
        private System.Windows.Forms.TextBox rentdate_text;
        private System.Windows.Forms.TextBox Custid_text;
        private System.Windows.Forms.TextBox movieid_text;
        private System.Windows.Forms.TextBox RMID_text;
        private System.Windows.Forms.RadioButton rentedout_;
        private System.Windows.Forms.RadioButton allrent_radio;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button issue_button;
        private System.Windows.Forms.Button Best_buy;
        private System.Windows.Forms.Button Top_buy;
    }
}