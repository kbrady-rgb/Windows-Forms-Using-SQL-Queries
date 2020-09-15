using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : REDO: Write SQL Statement
* Author      : Kabrina Brady
* Created     : 11/12/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : User can sort table in a variety of ways
*               Input:  Button clicks
*               Output: Sorted table
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace NewProductDatabase
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.ProductsTable' table. You can move, or remove it, as needed.
            this.productsTableTableAdapter.Fill(this.productDBDataSet.ProductsTable);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //closes form
        }

        //Sort by price 
        private void sortByPriceButton_Click(object sender, EventArgs e)
        {
            this.productsTableTableAdapter.FillByPrice(this.productDBDataSet.ProductsTable);
        }

        //Units greater than 100
        private void unitsGreater100Button_Click(object sender, EventArgs e)
        {
            this.productsTableTableAdapter.FillByUnits(this.productDBDataSet.ProductsTable);
        }

        //Price greater than 40
        private void btn40Dol_Click(object sender, EventArgs e)
        {
            this.productsTableTableAdapter.FillByPriceGreaterThan40(this.productDBDataSet.ProductsTable);
        }

        //Most expensive item
        private void btnExpensive_Click(object sender, EventArgs e)
        {
            this.productsTableTableAdapter.FillByMostExpensive(this.productDBDataSet.ProductsTable);
        }
    }
}
