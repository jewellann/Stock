using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasco_Inventory_Management_Systems
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDateStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtStockPCode.Focus();
            }
           
        }

        private void txtStockPCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(dgview.Rows.Count > 0)
                {
                    txtStockPCode.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                    txtStockPName.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                    this.dgview.Visible = false;
                    txtStockPQuantity.Focus();
                }
                else
                {
                    this.dgview.Visible = false;
                }
            }
        }

        private void txtStockPName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtStockPName.Text.Length > 0)
                {
                    txtStockPQuantity.Focus();
                }
                else
                {
                    txtStockPName.Focus();
                }
            }
        }

        bool change = true;
        private void proCode_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (change)
            {
                change = false;
                txtStockPCode.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                txtStockPName.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                this.dgview.Visible = false;
                txtStockPQuantity.Focus();
                change = true;
            }
        }

        private void txtStockPQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtStockPQuantity.Text.Length > 0)
                {
                    cbStockStatus.Focus();
                }
                else
                {
                    txtStockPQuantity.Focus();
                }
            }
        }

        private void cbStockStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cbStockStatus.SelectedIndex != -1)
                {
                    btnStockDelete.Focus();
                }
                else
                {
                    cbStockStatus.Focus();
                }
            }
        }

        private void txtStockPCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '_') 
            {
                e.Handled = true;
            }
        }

        private void txtStockPQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '_')
            {
                e.Handled = true;
            }
        }
        private void ResetRecords()
        {
            txtDateStock.Value = DateTime.Now;
            txtStockPCode.Clear();
            txtStockPName.Clear();
            txtStockPQuantity.Clear();
            cbStockStatus.SelectedIndex = -1;
            btnStockAdd.Text = "Add";
            txtDateStock.Focus();
        }

        private void Stock_Load_1(object sender, EventArgs e)
        {
            this.ActiveControl = txtDateStock;
            cbStockStatus.SelectedIndex = 0;
            LoadData();
            Search();
        }

        private void btnStockReset_Click(object sender, EventArgs e)
        {
            ResetRecords();
        }

        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtStockPCode.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtStockPCode, "Product Code Required");
            }
            else if (string.IsNullOrEmpty(txtStockPName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtStockPName, "Product Name Required");

            }
            else if (string.IsNullOrEmpty(txtStockPQuantity.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtStockPQuantity, "Quantity Required");

            }
            else if (cbStockStatus.SelectedIndex == -1) 
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cbStockStatus, "Select Status");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        private bool IfProductExists(SqlConnection con, string productCode)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 From [Stock] WHERE [ProductCode]='" + productCode + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                return true;
            }
            else 
            { 
                return false;  
            }
        }

        private void btnStockAdd_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                SqlConnection con = Connection.GetConnection();
                con.Open();
                bool status = false;

                if (cbStockStatus.SelectedIndex == 0)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }

                var sqlQuery = "";
                if (IfProductExists(con, txtStockPCode.Text))
                {
                    sqlQuery = @"UPDATE [Stock] SET [ProductName] = '" + txtStockPName.Text + "', [Quantity] = '" + txtStockPQuantity.Text + "', [ProductStatus] = '" + status + "' WHERE [ProductCode] = '" + txtStockPCode.Text + "'";
                }
                else
                {
                    sqlQuery = @"INSERT INTO Stock (ProductCode, ProductName, TransDate, Quantity, ProductStatus) 
                        VALUES ('" + txtStockPCode.Text + "', '" +txtStockPName.Text + "', '" + txtDateStock.Value.ToString("MM/dd/yyyy") + "', '" + txtStockPQuantity.Text + "','" + status + "')";
                }

                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Saved Successfully.");
                LoadData();
                ResetRecords();
            }
        }

        public void LoadData()
        {
            SqlConnection con = Connection.GetConnection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Stock].[dbo].[Stock]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgSno"].Value = n + 1;
                dataGridView1.Rows[n].Cells["dgProCode"].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells["dgProName"].Value = item["ProductName"].ToString();
                dataGridView1.Rows[n].Cells["dgQuantity"].Value = float.Parse(item["Quantity"].ToString());
                dataGridView1.Rows[n].Cells["dgDate"].Value = Convert.ToDateTime(item["TransDate"].ToString()).ToString("dd/MM/yyyy");
                if ((bool)item["ProductStatus"])
                {
                    dataGridView1.Rows[n].Cells["dgStatus"].Value = "Active";
                }
                else
                {
                    dataGridView1.Rows[n].Cells["dgStatus"].Value = "Deactive";
                }
            }

            if (dataGridView1.Rows.Count > 0)
            {
                label3.Text = dataGridView1.Rows.Count.ToString();
                float totQty = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    totQty += float.Parse(dataGridView1.Rows[i].Cells["dgQuantity"].Value.ToString());
                    label4.Text = totQty.ToString();
                }
            }
            else
            {
                label3.Text = "0";
                label4.Text = "0";
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnStockAdd.Text = "Update";
            txtStockPCode.Text = dataGridView1.SelectedRows[0].Cells["dgProCode"].Value.ToString();
            txtStockPName.Text = dataGridView1.SelectedRows[0].Cells["dgProName"].Value.ToString();
            txtStockPQuantity.Text = dataGridView1.SelectedRows[0].Cells["dgQuantity"].Value.ToString();
            txtDateStock.Text = DateTime.Parse(dataGridView1.SelectedRows[0].Cells["dgDate"].Value.ToString()).ToString("dd/MM/yyyy");
            if (dataGridView1.SelectedRows[0].Cells["dgStatus"].Value.ToString() == "Active")
            {
                cbStockStatus.SelectedIndex = 0;
            }
            else
            {
                 cbStockStatus.SelectedIndex = 1;
            }
        }

        private void btnStockDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete", "Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (Validation()) 
                {
                    SqlConnection con = Connection.GetConnection();
                    var sqlQuery = "";
                    if (IfProductExists(con, txtStockPCode.Text))
                    {
                        con.Open();
                        sqlQuery = @"DELETE FROM [Stock] WHERE [ProductCode] = '" + txtStockPCode.Text + "'";
                        SqlCommand cmd = new SqlCommand(sqlQuery, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Deleted Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Record doesn't exists!");
                    }
                    LoadData();
                    ResetRecords();
                }
            }
        }

        private void txtStockPCode_TextChanged(object sender, EventArgs e)
        {
            if (txtStockPCode.Text.Length > 0)
            {
                this.dgview.Visible = true;
                dgview.BringToFront();
                Search(150, 105, 430, 200, "Pro Code, Pro Name", "100,0");
                this.dgview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.proCode_MouseDoubleClick);
                SqlConnection con = Connection.GetConnection();
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Top(10) ProductCode,ProductName From [Products] WHERE [ProductCode] Like '" + txtStockPCode.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgview.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int n = dgview.Rows.Add();
                    dgview.Rows[n].Cells[0].Value = row["ProductCode"].ToString();
                    dgview.Rows[n].Cells[1].Value = row["ProductName"].ToString();
                }
            }
            else
            {
                dgview.Visible = false;
            }
            
        }

        private DataGridView dgview;
        private DataGridViewTextBoxColumn dgviewcol1;
        private DataGridViewTextBoxColumn dgviewcol2;

        void Search()
        {
            dgview = new DataGridView();
            dgviewcol1 = new DataGridViewTextBoxColumn();
            dgviewcol2 = new DataGridViewTextBoxColumn();
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgviewcol1, this.dgviewcol2 });
            this.dgview.Name = "dgview";
            dgview.Visible = false;
            this.dgviewcol1.Visible = false;
            this.dgviewcol2.Visible = false;
            this.dgview.AllowUserToAddRows = false;
            this.dgview.RowHeadersVisible = false;
            this.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            //this.dgview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgview_KeyDown);

            this.Controls.Add(dgview);
            this.dgview.ReadOnly = true;
            dgview.BringToFront();
        }

        //Two Column
        void Search(int LX, int LY, int DW, int DH, string ColName, String ColSize)
        {
            this.dgview.Location = new System.Drawing.Point(LX, LY);
            this.dgview.Size = new System.Drawing.Size(DW, DH);

            string[] ClSize = ColSize.Split(',');
            //Size
            for(int i = 0; i < ClSize.Length; i++)
            {
                if (int.Parse(ClSize[i]) != 0)
                {
                    dgview.Columns[i].Width = int.Parse(ClSize[i]);
                }
                else
                {
                    dgview.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            //Name
            string[] ClName = ColName.Split(',');

            for (int i = 0; i < ClName.Length; i++)
            {
                this.dgview.Columns[i].HeaderText = ClName[i];
                this.dgview.Columns[i].Visible = true;
            }
        }
    }
}
