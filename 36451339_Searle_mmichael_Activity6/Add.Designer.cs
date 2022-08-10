
namespace _36451339_Searle_mmichael_Activity6
{
    partial class Add
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
            this.lblTheatreNumber = new System.Windows.Forms.Label();
            this.lblTotalSeats = new System.Windows.Forms.Label();
            this.lblOpenSeats = new System.Windows.Forms.Label();
            this.lblTheatreSize = new System.Windows.Forms.Label();
            this.txtTheatreNumber = new System.Windows.Forms.TextBox();
            this.txtTotalSeats = new System.Windows.Forms.TextBox();
            this.txtOpenSeats = new System.Windows.Forms.TextBox();
            this.txtTheatreSize = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTheatreNumber
            // 
            this.lblTheatreNumber.AutoSize = true;
            this.lblTheatreNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheatreNumber.Location = new System.Drawing.Point(82, 80);
            this.lblTheatreNumber.Name = "lblTheatreNumber";
            this.lblTheatreNumber.Size = new System.Drawing.Size(135, 20);
            this.lblTheatreNumber.TabIndex = 0;
            this.lblTheatreNumber.Text = "Theatre Number:";
            // 
            // lblTotalSeats
            // 
            this.lblTotalSeats.AutoSize = true;
            this.lblTotalSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSeats.Location = new System.Drawing.Point(82, 153);
            this.lblTotalSeats.Name = "lblTotalSeats";
            this.lblTotalSeats.Size = new System.Drawing.Size(99, 20);
            this.lblTotalSeats.TabIndex = 1;
            this.lblTotalSeats.Text = "Total Seats:";
            // 
            // lblOpenSeats
            // 
            this.lblOpenSeats.AutoSize = true;
            this.lblOpenSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenSeats.Location = new System.Drawing.Point(82, 220);
            this.lblOpenSeats.Name = "lblOpenSeats";
            this.lblOpenSeats.Size = new System.Drawing.Size(102, 20);
            this.lblOpenSeats.TabIndex = 2;
            this.lblOpenSeats.Text = "Open Seats:";
            // 
            // lblTheatreSize
            // 
            this.lblTheatreSize.AutoSize = true;
            this.lblTheatreSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheatreSize.Location = new System.Drawing.Point(82, 302);
            this.lblTheatreSize.Name = "lblTheatreSize";
            this.lblTheatreSize.Size = new System.Drawing.Size(109, 20);
            this.lblTheatreSize.TabIndex = 3;
            this.lblTheatreSize.Text = "Theatre Size:";
            // 
            // txtTheatreNumber
            // 
            this.txtTheatreNumber.Location = new System.Drawing.Point(300, 80);
            this.txtTheatreNumber.Name = "txtTheatreNumber";
            this.txtTheatreNumber.Size = new System.Drawing.Size(100, 22);
            this.txtTheatreNumber.TabIndex = 4;
            // 
            // txtTotalSeats
            // 
            this.txtTotalSeats.Location = new System.Drawing.Point(300, 151);
            this.txtTotalSeats.Name = "txtTotalSeats";
            this.txtTotalSeats.Size = new System.Drawing.Size(100, 22);
            this.txtTotalSeats.TabIndex = 5;
            // 
            // txtOpenSeats
            // 
            this.txtOpenSeats.Location = new System.Drawing.Point(300, 218);
            this.txtOpenSeats.Name = "txtOpenSeats";
            this.txtOpenSeats.Size = new System.Drawing.Size(100, 22);
            this.txtOpenSeats.TabIndex = 6;
            // 
            // txtTheatreSize
            // 
            this.txtTheatreSize.Location = new System.Drawing.Point(300, 302);
            this.txtTheatreSize.Name = "txtTheatreSize";
            this.txtTheatreSize.Size = new System.Drawing.Size(100, 22);
            this.txtTheatreSize.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(269, 373);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(131, 41);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 444);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTheatreSize);
            this.Controls.Add(this.txtOpenSeats);
            this.Controls.Add(this.txtTotalSeats);
            this.Controls.Add(this.txtTheatreNumber);
            this.Controls.Add(this.lblTheatreSize);
            this.Controls.Add(this.lblOpenSeats);
            this.Controls.Add(this.lblTotalSeats);
            this.Controls.Add(this.lblTheatreNumber);
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTheatreNumber;
        private System.Windows.Forms.Label lblTotalSeats;
        private System.Windows.Forms.Label lblOpenSeats;
        private System.Windows.Forms.Label lblTheatreSize;
        private System.Windows.Forms.TextBox txtTheatreNumber;
        private System.Windows.Forms.TextBox txtTotalSeats;
        private System.Windows.Forms.TextBox txtOpenSeats;
        private System.Windows.Forms.TextBox txtTheatreSize;
        private System.Windows.Forms.Button btnSubmit;
    }
}