namespace Lactao_MidtermCaseStudy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Title = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.boxProductSelect = new System.Windows.Forms.ComboBox();
            this.lblCart = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.txt4Lbl = new System.Windows.Forms.Label();
            this.txt3Lbl = new System.Windows.Forms.Label();
            this.txt2lbl = new System.Windows.Forms.Label();
            this.txt1Lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvShopCart = new System.Windows.Forms.DataGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.inputQty = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.btnProductSelect = new System.Windows.Forms.Button();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblTotalCurrency = new System.Windows.Forms.Label();
            this.lblTotalNo = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblRemoveItem = new System.Windows.Forms.Label();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShopCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputQty)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(22, 19);
            this.Title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(310, 42);
            this.Title.TabIndex = 0;
            this.Title.Text = "Pharmacy Order";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelect.Location = new System.Drawing.Point(33, 92);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(186, 32);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "Select Product:";
            // 
            // boxProductSelect
            // 
            this.boxProductSelect.FormattingEnabled = true;
            this.boxProductSelect.Items.AddRange(new object[] {
            "Sodium ascorbate (Vit. C)",
            "Vitamin E",
            "Multivitamins",
            "Iron Supplement",
            "Calcium Supplement",
            "Magnesium Supplement"});
            this.boxProductSelect.Location = new System.Drawing.Point(231, 89);
            this.boxProductSelect.Margin = new System.Windows.Forms.Padding(6);
            this.boxProductSelect.Name = "boxProductSelect";
            this.boxProductSelect.Size = new System.Drawing.Size(331, 40);
            this.boxProductSelect.TabIndex = 2;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCart.Location = new System.Drawing.Point(771, 29);
            this.lblCart.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(178, 32);
            this.lblCart.TabIndex = 3;
            this.lblCart.Text = "Shopping Cart";
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.txt4Lbl);
            this.grpBox.Controls.Add(this.txt3Lbl);
            this.grpBox.Controls.Add(this.txt2lbl);
            this.grpBox.Controls.Add(this.txt1Lbl);
            this.grpBox.Controls.Add(this.label4);
            this.grpBox.Controls.Add(this.label3);
            this.grpBox.Controls.Add(this.label2);
            this.grpBox.Controls.Add(this.label1);
            this.grpBox.Location = new System.Drawing.Point(45, 169);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(630, 305);
            this.grpBox.TabIndex = 4;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Product Info";
            // 
            // txt4Lbl
            // 
            this.txt4Lbl.AutoSize = true;
            this.txt4Lbl.Location = new System.Drawing.Point(159, 222);
            this.txt4Lbl.Name = "txt4Lbl";
            this.txt4Lbl.Size = new System.Drawing.Size(254, 32);
            this.txt4Lbl.TabIndex = 12;
            this.txt4Lbl.Text = "------------------------";
            // 
            // txt3Lbl
            // 
            this.txt3Lbl.AutoSize = true;
            this.txt3Lbl.Location = new System.Drawing.Point(159, 168);
            this.txt3Lbl.Name = "txt3Lbl";
            this.txt3Lbl.Size = new System.Drawing.Size(254, 32);
            this.txt3Lbl.TabIndex = 11;
            this.txt3Lbl.Text = "------------------------";
            // 
            // txt2lbl
            // 
            this.txt2lbl.AutoSize = true;
            this.txt2lbl.Location = new System.Drawing.Point(159, 117);
            this.txt2lbl.Name = "txt2lbl";
            this.txt2lbl.Size = new System.Drawing.Size(254, 32);
            this.txt2lbl.TabIndex = 10;
            this.txt2lbl.Text = "------------------------";
            // 
            // txt1Lbl
            // 
            this.txt1Lbl.AutoSize = true;
            this.txt1Lbl.Location = new System.Drawing.Point(159, 64);
            this.txt1Lbl.Name = "txt1Lbl";
            this.txt1Lbl.Size = new System.Drawing.Size(254, 32);
            this.txt1Lbl.TabIndex = 9;
            this.txt1Lbl.Text = "------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unit: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name: ";
            // 
            // dgvShopCart
            // 
            this.dgvShopCart.AllowUserToAddRows = false;
            this.dgvShopCart.AllowUserToDeleteRows = false;
            this.dgvShopCart.AutoGenerateColumns = false;
            this.dgvShopCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShopCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShopCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dgvShopCart.DataSource = this.orderBindingSource;
            this.dgvShopCart.Location = new System.Drawing.Point(771, 169);
            this.dgvShopCart.Name = "dgvShopCart";
            this.dgvShopCart.ReadOnly = true;
            this.dgvShopCart.RowHeadersWidth = 82;
            this.dgvShopCart.RowTemplate.Height = 41;
            this.dgvShopCart.Size = new System.Drawing.Size(652, 725);
            this.dgvShopCart.TabIndex = 6;
            this.dgvShopCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShopCart_CellClick);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Lactao_MidtermCaseStudy.Classes.Order);
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.btnSubmit);
            this.grpOrder.Controls.Add(this.lblCurrency);
            this.grpOrder.Controls.Add(this.inputQty);
            this.grpOrder.Controls.Add(this.txtTotal);
            this.grpOrder.Controls.Add(this.lblTotal);
            this.grpOrder.Controls.Add(this.lblQty);
            this.grpOrder.Location = new System.Drawing.Point(45, 533);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(630, 256);
            this.grpOrder.TabIndex = 7;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order Info";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(410, 180);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 46);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Add Item";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(167, 132);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(57, 32);
            this.lblCurrency.TabIndex = 15;
            this.lblCurrency.Text = "PHP";
            // 
            // inputQty
            // 
            this.inputQty.Location = new System.Drawing.Point(259, 43);
            this.inputQty.Name = "inputQty";
            this.inputQty.Size = new System.Drawing.Size(65, 39);
            this.inputQty.TabIndex = 14;
            this.inputQty.ValueChanged += new System.EventHandler(this.inputQty_ValueChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(266, 132);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(58, 32);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.Text = "0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(77, 100);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(128, 32);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "AMOUNT: ";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(77, 45);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(118, 32);
            this.lblQty.TabIndex = 0;
            this.lblQty.Text = "Quantity: ";
            // 
            // btnProductSelect
            // 
            this.btnProductSelect.Location = new System.Drawing.Point(571, 89);
            this.btnProductSelect.Name = "btnProductSelect";
            this.btnProductSelect.Size = new System.Drawing.Size(102, 44);
            this.btnProductSelect.TabIndex = 8;
            this.btnProductSelect.Text = "Search";
            this.btnProductSelect.UseVisualStyleBackColor = true;
            this.btnProductSelect.Click += new System.EventHandler(this.btnProductSelect_Click);
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(1136, 29);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(201, 32);
            this.lblOrderTotal.TabIndex = 9;
            this.lblOrderTotal.Text = "TOTAL PAYMENT: ";
            // 
            // lblTotalCurrency
            // 
            this.lblTotalCurrency.AutoSize = true;
            this.lblTotalCurrency.Location = new System.Drawing.Point(1246, 71);
            this.lblTotalCurrency.Name = "lblTotalCurrency";
            this.lblTotalCurrency.Size = new System.Drawing.Size(57, 32);
            this.lblTotalCurrency.TabIndex = 16;
            this.lblTotalCurrency.Text = "PHP";
            // 
            // lblTotalNo
            // 
            this.lblTotalNo.AutoSize = true;
            this.lblTotalNo.Location = new System.Drawing.Point(1323, 71);
            this.lblTotalNo.Name = "lblTotalNo";
            this.lblTotalNo.Size = new System.Drawing.Size(58, 32);
            this.lblTotalNo.TabIndex = 17;
            this.lblTotalNo.Text = "0.00";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(771, 89);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 44);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblRemoveItem
            // 
            this.lblRemoveItem.AutoSize = true;
            this.lblRemoveItem.Location = new System.Drawing.Point(920, 95);
            this.lblRemoveItem.Name = "lblRemoveItem";
            this.lblRemoveItem.Size = new System.Drawing.Size(0, 32);
            this.lblRemoveItem.TabIndex = 19;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 960);
            this.Controls.Add(this.lblRemoveItem);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTotalNo);
            this.Controls.Add(this.lblTotalCurrency);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.btnProductSelect);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.dgvShopCart);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.boxProductSelect);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShopCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Label lblSelect;
        private ComboBox boxProductSelect;
        private Label lblCart;
        private GroupBox grpBox;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label txt1Lbl;
        private Label txt4Lbl;
        private Label txt3Lbl;
        private Label txt2lbl;
        private DataGridView dgvShopCart;
        private GroupBox grpOrder;
        private NumericUpDown inputQty;
        private Label txtTotal;
        private Label lblTotal;
        private Label lblQty;
        private Label lblCurrency;
        private Button btnSubmit;
        private Button btnProductSelect;
        private Label lblOrderTotal;
        private Label lblTotalCurrency;
        private Label lblTotalNo;
        private BindingSource orderBindingSource;
        private Button btnDelete;
        private Label lblRemoveItem;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}