using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pasco_Inventory_Management_Systems
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            LoadData();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            cbstatus.SelectedIndex = 0;
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SVMAIN\\EMSDATABASE;Initial Catalog=Stock;Integrated Security=True");
            //Insert Logic
            con.Open();

            bool status = false;
            if (cbstatus.SelectedIndex == 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            var sqlQuery = "";
            if (IfProductExists(con, txtproductcode.Text))
            {
                sqlQuery = @"UPDATE [Products] SET [ProductName] = '" + txtproductname.Text + "' ,[ProductStatus] = '" + status + "' WHERE [ProductCode] = '" + txtproductcode.Text + "'";
            }
            else
            {
                sqlQuery = "@INSERT INTO [dbo].[Products]([ProductCode],[ProductName],[ProductStatus]) VALUES    ('" + txtproductcode.Text + "','" + txtproductname.Text + "','" + status + "')";
            }
         
            
            SqlCommand cmd = new SqlCommand(sqlQuery ,con);
                cmd.ExecuteNonQuery();
            con.Close();

            //Reading Data
            LoadData();


        }

        private bool IfProductExists(SqlConnection con, string productCode)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT 1 FROM [Products] WHERE [ProductCode]='" +productCode + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows.Count > 0)
                return true;
            else 
                return false;
        }

        public void LoadData()
        {
            SqlConnection con = new SqlConnection("Data Source=SVMAIN\\EMSDATABASE;Initial Catalog=Stock;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Stock].[dbo].[Products]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();

                if ((bool)item["ProductStatus"])
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Deactive";
                }

            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtproductcode.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtproductname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Active")
            {
                cbstatus.SelectedIndex = 0;
            }
            else
            {
                cbstatus.SelectedIndex = 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SVMAIN\\EMSDATABASE;Initial Catalog=Stock;Integrated Security=True");
            var sqlQuery = "";

            if (IfProductExists(con, txtproductcode.Text))
            {
                con.Open();
                sqlQuery = @"DELETE FROM [Products] WHERE [ProductCode] = '" + txtproductcode.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Record Not Exist...!");
            }

            LoadData();
        }
    }
}
