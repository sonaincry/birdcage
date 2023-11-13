using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace BirdCageManagement;
public partial class RevenueForm : Form
{
    private IOrderService orderService;
    public RevenueForm()
    {
        InitializeComponent();
        orderService = new OrderService();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Hide();
        var af = new AdminForm();
        af.ShowDialog();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void RevenueForm_Load(object sender, EventArgs e)
    {
        dataGridView1.DataSource = orderService.GetOrders();
    }
}
