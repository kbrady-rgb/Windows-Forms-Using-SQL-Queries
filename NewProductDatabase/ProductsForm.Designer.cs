namespace NewProductDatabase
{
    partial class ProductsForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExpensive = new System.Windows.Forms.Button();
            this.btn40Dol = new System.Windows.Forms.Button();
            this.unitsGreater100Button = new System.Windows.Forms.Button();
            this.sortByPriceButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDBDataSet = new NewProductDatabase.ProductDBDataSet();
            this.productsTableTableAdapter = new NewProductDatabase.ProductDBDataSetTableAdapters.ProductsTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(290, 414);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExpensive
            // 
            this.btnExpensive.Location = new System.Drawing.Point(518, 338);
            this.btnExpensive.Name = "btnExpensive";
            this.btnExpensive.Size = new System.Drawing.Size(153, 48);
            this.btnExpensive.TabIndex = 10;
            this.btnExpensive.Text = "Most &Expensive";
            this.btnExpensive.UseVisualStyleBackColor = true;
            this.btnExpensive.Click += new System.EventHandler(this.btnExpensive_Click);
            // 
            // btn40Dol
            // 
            this.btn40Dol.Location = new System.Drawing.Point(359, 338);
            this.btn40Dol.Name = "btn40Dol";
            this.btn40Dol.Size = new System.Drawing.Size(153, 47);
            this.btn40Dol.TabIndex = 9;
            this.btn40Dol.Text = "&More than $40";
            this.btn40Dol.UseVisualStyleBackColor = true;
            this.btn40Dol.Click += new System.EventHandler(this.btn40Dol_Click);
            // 
            // unitsGreater100Button
            // 
            this.unitsGreater100Button.Location = new System.Drawing.Point(199, 337);
            this.unitsGreater100Button.Margin = new System.Windows.Forms.Padding(4);
            this.unitsGreater100Button.Name = "unitsGreater100Button";
            this.unitsGreater100Button.Size = new System.Drawing.Size(153, 48);
            this.unitsGreater100Button.TabIndex = 8;
            this.unitsGreater100Button.Text = "&Products With More Than 100 Units";
            this.unitsGreater100Button.UseVisualStyleBackColor = true;
            this.unitsGreater100Button.Click += new System.EventHandler(this.unitsGreater100Button_Click);
            // 
            // sortByPriceButton
            // 
            this.sortByPriceButton.Location = new System.Drawing.Point(38, 337);
            this.sortByPriceButton.Margin = new System.Windows.Forms.Padding(4);
            this.sortByPriceButton.Name = "sortByPriceButton";
            this.sortByPriceButton.Size = new System.Drawing.Size(153, 48);
            this.sortByPriceButton.TabIndex = 7;
            this.sortByPriceButton.Text = "&Sort By Price";
            this.sortByPriceButton.UseVisualStyleBackColor = true;
            this.sortByPriceButton.Click += new System.EventHandler(this.sortByPriceButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNumberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.unitsOnHandDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(635, 273);
            this.dataGridView1.TabIndex = 12;
            // 
            // productsTableBindingSource
            // 
            this.productsTableBindingSource.DataMember = "ProductsTable";
            this.productsTableBindingSource.DataSource = this.productDBDataSetBindingSource;
            // 
            // productNumberDataGridViewTextBoxColumn
            // 
            this.productNumberDataGridViewTextBoxColumn.DataPropertyName = "Product_Number";
            this.productNumberDataGridViewTextBoxColumn.HeaderText = "Product_Number";
            this.productNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNumberDataGridViewTextBoxColumn.Name = "productNumberDataGridViewTextBoxColumn";
            this.productNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitsOnHandDataGridViewTextBoxColumn
            // 
            this.unitsOnHandDataGridViewTextBoxColumn.DataPropertyName = "Units_On_Hand";
            this.unitsOnHandDataGridViewTextBoxColumn.HeaderText = "Units_On_Hand";
            this.unitsOnHandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitsOnHandDataGridViewTextBoxColumn.Name = "unitsOnHandDataGridViewTextBoxColumn";
            this.unitsOnHandDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // productDBDataSetBindingSource
            // 
            this.productDBDataSetBindingSource.DataSource = this.productDBDataSet;
            this.productDBDataSetBindingSource.Position = 0;
            // 
            // productDBDataSet
            // 
            this.productDBDataSet.DataSetName = "ProductDBDataSet";
            this.productDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableTableAdapter
            // 
            this.productsTableTableAdapter.ClearBeforeFill = true;
            // 
            // ProductsForm
            // 
            this.AcceptButton = this.sortByPriceButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExpensive);
            this.Controls.Add(this.btn40Dol);
            this.Controls.Add(this.unitsGreater100Button);
            this.Controls.Add(this.sortByPriceButton);
            this.Name = "ProductsForm";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExpensive;
        private System.Windows.Forms.Button btn40Dol;
        private System.Windows.Forms.Button unitsGreater100Button;
        private System.Windows.Forms.Button sortByPriceButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productDBDataSetBindingSource;
        private ProductDBDataSet productDBDataSet;
        private System.Windows.Forms.BindingSource productsTableBindingSource;
        private ProductDBDataSetTableAdapters.ProductsTableTableAdapter productsTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsOnHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}

