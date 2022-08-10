
namespace _36451339_Searle_mmichael_Activity6
{
    partial class Theatres
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
            this.dgvTheatres = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.btnOpenSeats50 = new System.Windows.Forms.Button();
            this.btnTotalSeats120_260 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbTheatreNumber = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheatres)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTheatres
            // 
            this.dgvTheatres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheatres.Location = new System.Drawing.Point(13, 13);
            this.dgvTheatres.Name = "dgvTheatres";
            this.dgvTheatres.RowHeadersWidth = 51;
            this.dgvTheatres.RowTemplate.Height = 24;
            this.dgvTheatres.Size = new System.Drawing.Size(705, 432);
            this.dgvTheatres.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(896, 44);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(223, 55);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View All";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnOpenSeats50
            // 
            this.btnOpenSeats50.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSeats50.Location = new System.Drawing.Point(896, 127);
            this.btnOpenSeats50.Name = "btnOpenSeats50";
            this.btnOpenSeats50.Size = new System.Drawing.Size(223, 45);
            this.btnOpenSeats50.TabIndex = 2;
            this.btnOpenSeats50.Text = "Open Seats<50";
            this.btnOpenSeats50.UseVisualStyleBackColor = true;
            this.btnOpenSeats50.Click += new System.EventHandler(this.btnOpenSeats50_Click);
            // 
            // btnTotalSeats120_260
            // 
            this.btnTotalSeats120_260.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalSeats120_260.Location = new System.Drawing.Point(896, 207);
            this.btnTotalSeats120_260.Name = "btnTotalSeats120_260";
            this.btnTotalSeats120_260.Size = new System.Drawing.Size(223, 50);
            this.btnTotalSeats120_260.TabIndex = 3;
            this.btnTotalSeats120_260.Text = "Total seats 120-260";
            this.btnTotalSeats120_260.UseVisualStyleBackColor = true;
            this.btnTotalSeats120_260.Click += new System.EventHandler(this.btnTotalSeats120_260_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(896, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(223, 48);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbTheatreNumber
            // 
            this.cbTheatreNumber.FormattingEnabled = true;
            this.cbTheatreNumber.Location = new System.Drawing.Point(896, 359);
            this.cbTheatreNumber.Name = "cbTheatreNumber";
            this.cbTheatreNumber.Size = new System.Drawing.Size(223, 24);
            this.cbTheatreNumber.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(896, 417);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(223, 48);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Theatres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 573);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbTheatreNumber);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnTotalSeats120_260);
            this.Controls.Add(this.btnOpenSeats50);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dgvTheatres);
            this.Name = "Theatres";
            this.Text = "Theatres";
            this.Load += new System.EventHandler(this.Theatres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheatres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTheatres;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnOpenSeats50;
        private System.Windows.Forms.Button btnTotalSeats120_260;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbTheatreNumber;
        private System.Windows.Forms.Button btnDelete;
    }
}

