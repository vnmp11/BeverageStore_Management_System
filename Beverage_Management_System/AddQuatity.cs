﻿using Beverage_Management_System.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beverage_Management_System
{
    public partial class AddQuatity : Form
    {
        string quantity;

        int id_IGF;
        string name_IGF;
        DataGridView dataGrid;

        public AddQuatity()
        {
            InitializeComponent();
            txbQuantity = txb_quantity.Text;


        }
        public AddQuatity(int id, string name, int temp, DataGridView a)
        {
            InitializeComponent();
            txbQuantity = txb_quantity.Text;
            id_IGF = id;
            name_IGF = name;
            dataGrid = a;

        }
       
        public string txbQuantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btt_plus_Click(object sender, EventArgs e)
        {
            txb_quantity.Text = (int.Parse(txb_quantity.Text) + 1).ToString();
        }

        private void btt_minus_Click(object sender, EventArgs e)
        {
            if (int.Parse(txb_quantity.Text) > 1)
            {
                txb_quantity.Text = (int.Parse(txb_quantity.Text) - 1).ToString();
            }
        }

        public void btt_ok_Click(object sender, EventArgs e)
        {
            ImportGoodsPresenter presenter = new ImportGoodsPresenter();
            presenter.addDataGV_ImportGoods(dataGrid, id_IGF, name_IGF, int.Parse(txb_quantity.Text));
            this.Close();
        }

        private void txb_quantity_TextChanged(object sender, EventArgs e)
        {
            txbQuantity = txb_quantity.Text;

        }

        private void txb_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
