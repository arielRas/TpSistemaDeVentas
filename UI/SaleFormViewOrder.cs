using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class SaleFormViewOrder : Form
    {
        public Order order = null;

        public SaleFormViewOrder(Order order)
        {
            this.order = order;
            InitializeComponent();
        }

        private void btnGuardarCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
