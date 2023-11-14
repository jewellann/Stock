namespace Pasco_Inventory_Management_Systems
{
    partial class Stock
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
            this.components = new System.ComponentModel.Container();
            this.lblStockDate = new System.Windows.Forms.Label();
            this.lblStockProductCode = new System.Windows.Forms.Label();
            this.lblStockProductName = new System.Windows.Forms.Label();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.lblStockStatus = new System.Windows.Forms.Label();
            this.txtDateStock = new System.Windows.Forms.DateTimePicker();
            this.txtStockPCode = new System.Windows.Forms.TextBox();
            this.txtStockPName = new System.Windows.Forms.TextBox();
            this.txtStockPQuantity = new System.Windows.Forms.TextBox();
            this.cbStockStatus = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStockAdd = new System.Windows.Forms.Button();
            this.btnStockDelete = new System.Windows.Forms.Button();
            this.btnStockReset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStockDate
            // 
            this.lblStockDate.AutoSize = true;
            this.lblStockDate.Location = new System.Drawing.Point(58, 35);
            this.lblStockDate.Name = "lblStockDate";
            this.lblStockDate.Size = new System.Drawing.Size(30, 13);
            this.lblStockDate.TabIndex = 0;
            this.lblStockDate.Text = "Date";
            this.lblStockDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStockProductCode
            // 
            this.lblStockProductCode.AutoSize = true;
            this.lblStockProductCode.Location = new System.Drawing.Point(161, 35);
            this.lblStockProductCode.Name = "lblStockProductCode";
            this.lblStockProductCode.Size = new System.Drawing.Size(72, 13);
            this.lblStockProductCode.TabIndex = 1;
            this.lblStockProductCode.Text = "Product Code";
            // 
            // lblStockProductName
            // 
            this.lblStockProductName.AutoSize = true;
            this.lblStockProductName.Location = new System.Drawing.Point(305, 35);
            this.lblStockProductName.Name = "lblStockProductName";
            this.lblStockProductName.Size = new System.Drawing.Size(75, 13);
            this.lblStockProductName.TabIndex = 2;
            this.lblStockProductName.Text = "Product Name";
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Location = new System.Drawing.Point(451, 35);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblStockQuantity.TabIndex = 3;
            this.lblStockQuantity.Text = "Quantity";
            // 
            // lblStockStatus
            // 
            this.lblStockStatus.AutoSize = true;
            this.lblStockStatus.Location = new System.Drawing.Point(602, 35);
            this.lblStockStatus.Name = "lblStockStatus";
            this.lblStockStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStockStatus.TabIndex = 4;
            this.lblStockStatus.Text = "Status";
            // 
            // txtDateStock
            // 
            this.txtDateStock.CustomFormat = "dd/MM/yyyy";
            this.txtDateStock.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateStock.Location = new System.Drawing.Point(61, 62);
            this.txtDateStock.Name = "txtDateStock";
            this.txtDateStock.Size = new System.Drawing.Size(85, 20);
            this.txtDateStock.TabIndex = 5;
            this.txtDateStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDateStock_KeyDown);
            // 
            // txtStockPCode
            // 
            this.txtStockPCode.Location = new System.Drawing.Point(164, 62);
            this.txtStockPCode.Name = "txtStockPCode";
            this.txtStockPCode.Size = new System.Drawing.Size(131, 20);
            this.txtStockPCode.TabIndex = 6;
            this.txtStockPCode.TextChanged += new System.EventHandler(this.txtStockPCode_TextChanged);
            this.txtStockPCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStockPCode_KeyDown);
            this.txtStockPCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockPCode_KeyPress);
            // 
            // txtStockPName
            // 
            this.txtStockPName.Location = new System.Drawing.Point(308, 62);
            this.txtStockPName.Name = "txtStockPName";
            this.txtStockPName.Size = new System.Drawing.Size(131, 20);
            this.txtStockPName.TabIndex = 7;
            this.txtStockPName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStockPName_KeyDown);
            // 
            // txtStockPQuantity
            // 
            this.txtStockPQuantity.Location = new System.Drawing.Point(454, 62);
            this.txtStockPQuantity.Name = "txtStockPQuantity";
            this.txtStockPQuantity.Size = new System.Drawing.Size(131, 20);
            this.txtStockPQuantity.TabIndex = 8;
            this.txtStockPQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStockPQuantity_KeyDown);
            this.txtStockPQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockPQuantity_KeyPress);
            // 
            // cbStockStatus
            // 
            this.cbStockStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStockStatus.FormattingEnabled = true;
            this.cbStockStatus.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.cbStockStatus.Location = new System.Drawing.Point(605, 60);
            this.cbStockStatus.Name = "cbStockStatus";
            this.cbStockStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStockStatus.TabIndex = 9;
            this.cbStockStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbStockStatus_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgSno,
            this.dgProCode,
            this.dgProName,
            this.dgQuantity,
            this.dgDate,
            this.dgStatus});
            this.dataGridView1.Location = new System.Drawing.Point(39, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 236);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // dgSno
            // 
            this.dgSno.HeaderText = "S.No.";
            this.dgSno.Name = "dgSno";
            // 
            // dgProCode
            // 
            this.dgProCode.HeaderText = "Product Code";
            this.dgProCode.Name = "dgProCode";
            // 
            // dgProName
            // 
            this.dgProName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgProName.HeaderText = "Product Name";
            this.dgProName.Name = "dgProName";
            // 
            // dgQuantity
            // 
            this.dgQuantity.HeaderText = "Quantity";
            this.dgQuantity.Name = "dgQuantity";
            // 
            // dgDate
            // 
            this.dgDate.HeaderText = "Date";
            this.dgDate.Name = "dgDate";
            // 
            // dgStatus
            // 
            this.dgStatus.HeaderText = "Status";
            this.dgStatus.Name = "dgStatus";
            // 
            // btnStockAdd
            // 
            this.btnStockAdd.Location = new System.Drawing.Point(271, 97);
            this.btnStockAdd.Name = "btnStockAdd";
            this.btnStockAdd.Size = new System.Drawing.Size(73, 32);
            this.btnStockAdd.TabIndex = 11;
            this.btnStockAdd.Text = "Add";
            this.btnStockAdd.UseVisualStyleBackColor = true;
            this.btnStockAdd.Click += new System.EventHandler(this.btnStockAdd_Click);
            // 
            // btnStockDelete
            // 
            this.btnStockDelete.Location = new System.Drawing.Point(350, 97);
            this.btnStockDelete.Name = "btnStockDelete";
            this.btnStockDelete.Size = new System.Drawing.Size(73, 32);
            this.btnStockDelete.TabIndex = 12;
            this.btnStockDelete.Text = "Delete";
            this.btnStockDelete.UseVisualStyleBackColor = true;
            this.btnStockDelete.Click += new System.EventHandler(this.btnStockDelete_Click);
            // 
            // btnStockReset
            // 
            this.btnStockReset.Location = new System.Drawing.Point(429, 97);
            this.btnStockReset.Name = "btnStockReset";
            this.btnStockReset.Size = new System.Drawing.Size(73, 32);
            this.btnStockReset.TabIndex = 13;
            this.btnStockReset.Text = "Reset";
            this.btnStockReset.UseVisualStyleBackColor = true;
            this.btnStockReset.Click += new System.EventHandler(this.btnStockReset_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Total Products : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total Quantity : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "--";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 432);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStockReset);
            this.Controls.Add(this.btnStockDelete);
            this.Controls.Add(this.btnStockAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbStockStatus);
            this.Controls.Add(this.txtStockPQuantity);
            this.Controls.Add(this.txtStockPName);
            this.Controls.Add(this.txtStockPCode);
            this.Controls.Add(this.txtDateStock);
            this.Controls.Add(this.lblStockStatus);
            this.Controls.Add(this.lblStockQuantity);
            this.Controls.Add(this.lblStockProductName);
            this.Controls.Add(this.lblStockProductCode);
            this.Controls.Add(this.lblStockDate);
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStockDate;
        private System.Windows.Forms.Label lblStockProductCode;
        private System.Windows.Forms.Label lblStockProductName;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.DateTimePicker txtDateStock;
        private System.Windows.Forms.TextBox txtStockPCode;
        private System.Windows.Forms.TextBox txtStockPName;
        private System.Windows.Forms.TextBox txtStockPQuantity;
        private System.Windows.Forms.ComboBox cbStockStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnStockAdd;
        private System.Windows.Forms.Button btnStockDelete;
        private System.Windows.Forms.Button btnStockReset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}