namespace VideoRent_system
{
    partial class Home
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
            this.Customer = new System.Windows.Forms.Button();
            this.Movie = new System.Windows.Forms.Button();
            this.Rental = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customer
            // 
            this.Customer.Location = new System.Drawing.Point(95, 52);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(249, 77);
            this.Customer.TabIndex = 0;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = true;
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // Movie
            // 
            this.Movie.Location = new System.Drawing.Point(95, 136);
            this.Movie.Name = "Movie";
            this.Movie.Size = new System.Drawing.Size(249, 78);
            this.Movie.TabIndex = 1;
            this.Movie.Text = "Movies";
            this.Movie.UseVisualStyleBackColor = true;
            this.Movie.Click += new System.EventHandler(this.Movie_Click);
            // 
            // Rental
            // 
            this.Rental.Location = new System.Drawing.Point(95, 221);
            this.Rental.Name = "Rental";
            this.Rental.Size = new System.Drawing.Size(249, 91);
            this.Rental.TabIndex = 2;
            this.Rental.Text = "Rental";
            this.Rental.UseVisualStyleBackColor = true;
            this.Rental.Click += new System.EventHandler(this.Rental_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(546, 373);
            this.Controls.Add(this.Rental);
            this.Controls.Add(this.Movie);
            this.Controls.Add(this.Customer);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Customer;
        private System.Windows.Forms.Button Movie;
        private System.Windows.Forms.Button Rental;
    }
}

