using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36451339_Searle_mmichael_Activity6
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        public int TheatreaNumber;
        public int TotalSeats;
        public int OpenSeats;
        public string Size;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TheatreaNumber = Convert.ToInt32(txtTheatreNumber.Text);
            TotalSeats = Convert.ToInt32(txtTotalSeats.Text);
            OpenSeats = Convert.ToInt32(txtOpenSeats.Text);
            Size = txtTheatreSize.Text;
            this.Close();
        }
    }
}
