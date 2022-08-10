using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _36451339_Searle_mmichael_Activity6
{
    public partial class Theatres : Form
    {
        public Theatres()
        {
            InitializeComponent();
        }
        public string constr= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\36451339_Searle_mmichael_Activity6\36451339_Searle_mmichael_Activity6\theatre.mdf;Integrated Security=True";
        public SqlConnection conn;
        public SqlCommand com;
        public SqlDataAdapter adapt;
        public DataSet ds;
        public SqlDataReader read;
        private void Theatres_Load(object sender, EventArgs e)
        {
            try 
            { 
                conn = new SqlConnection(constr);
                conn.Open();

                adapt = new SqlDataAdapter();

                com = new SqlCommand("SELECT TheatreNumber  FROM  Theatre",conn);

                read = com.ExecuteReader();

                while(read.Read())
                {
                    cbTheatreNumber.Items.Add(read.GetValue(0));
                }

                conn.Close();
                MessageBox.Show("Connection to server succesfull");
            }
            catch
            {
                MessageBox.Show("Couldn't connect with server");
            }
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            conn.Open();
            adapt = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM Theatre ";

            com = new SqlCommand(sql, conn);

            adapt.SelectCommand = com;
            adapt.Fill(ds, "Theatre");

            dgvTheatres.DataSource = ds;
            dgvTheatres.DataMember = "Theatre";

            conn.Close();

        }
        
        private void btnOpenSeats50_Click(object sender, EventArgs e)
        {
            conn.Open();

            adapt = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM THEATRE WHERE OpenSeats <50";

            com = new SqlCommand(sql, conn);

            adapt.SelectCommand = com;
            adapt.Fill(ds, "Theatre");

            dgvTheatres.DataSource = ds;
            dgvTheatres.DataMember = "Theatre";
            conn.Close();
            
        }

        private void btnTotalSeats120_260_Click(object sender, EventArgs e)
        {
            conn.Open();

            adapt = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM Theatre WHERE  TotalSeats >= 120 AND TotalSeats <=260";

            com = new SqlCommand(sql, conn);

            adapt.SelectCommand = com;
            adapt.Fill(ds, "Theatre");

            dgvTheatres.DataSource = ds;
            dgvTheatres.DataMember = "Theatre";

            conn.Close();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();

            try
            {
                conn.Open();
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                string sql = $"INSERT INTO Theatre(TheatreNumber , TotalSeats , OpenSeats , TheatreSize )VALUES('{add.TheatreaNumber}','{add.TotalSeats}','{add.OpenSeats}','{add.Size}')";

                com = new SqlCommand(sql, conn);

                adapt.InsertCommand = com;
                adapt.InsertCommand.ExecuteNonQuery();

                conn.Close();
                cbTheatreNumber.Items.Add(add.TheatreaNumber);
                conn.Open();
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                string sql2 = "SELECT * FROM Theatre ";

                com = new SqlCommand(sql2, conn);

                adapt.SelectCommand = com;
                adapt.Fill(ds, "Theatre");

                dgvTheatres.DataSource = ds;
                dgvTheatres.DataMember = "Theatre";

                conn.Close();

            }
            catch
            {
                MessageBox.Show("Error...");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sql = $"DELETE FROM Theatre WHERE TheatreNumber='{cbTheatreNumber.SelectedItem}'";
                com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();
                conn.Close();
                cbTheatreNumber.Items.Remove(cbTheatreNumber.SelectedItem);
                MessageBox.Show("Record was deleted");
                conn.Open();
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                string sql2 = "SELECT * FROM Theatre ";

                com = new SqlCommand(sql2, conn);

                adapt.SelectCommand = com;
                adapt.Fill(ds, "Theatre");

                dgvTheatres.DataSource = ds;
                dgvTheatres.DataMember = "Theatre";

                conn.Close();


            }
            catch
            {
                MessageBox.Show("Error...");
            }
            
        }
    }
}
