using Entity;
using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UI
{
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
        }

        //CLASES PRIVADAS
        private Order order = null;
        private ProductBusiness _product = new ProductBusiness();
        private ProductCategoryBusiness _category = new ProductCategoryBusiness();
        private ProductBrandBusiness _brand = new ProductBrandBusiness();


        //METODOS PRIVADOS
        private List<Product> BuscarProducto(string categoria, string marca, string nombre) //BUSCAR PRODUCTO
        {
            if (!string.IsNullOrEmpty(categoria) || !string.IsNullOrEmpty(marca) || !string.IsNullOrEmpty(nombre))
            {
                return _product.GetAllProducts(categoria, marca, nombre);
            }
            else
                return _product.GetAllProducts();
        }

        private void ConfigurarColumnas() //CONFIGURA COLUMNAS DEL DATAGRIDVIEW
        {
            gridProducts.Columns[0].Width = 60;
            gridProducts.Columns[1].Width = 90;
            gridProducts.Columns[2].Width = 90;
            gridProducts.Columns[3].Width = 320;
            gridProducts.Columns[4].Width = 70;
            gridProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }


        //BOTONES
        private void btnGenerarPedido_Click(object sender, EventArgs e) //BOTON GENERAR PEDIDO
        {
            try
            {
                order = new Order();
                GroupProducto.Enabled = true;
                GroupCliente.Enabled = true;
                CboxFiltroCategoria.DataSource = _category.GetCategoryNames();
                CboxFiltroCategoria.SelectedIndex = -1;
                CboxFiltroMarca.DataSource = _brand.GetBrandNames();
                CboxFiltroMarca.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e) //BOTON BUSCAR PRODUCTO
        {
            try
            {                
                string categoria = CboxFiltroCategoria.SelectedItem?.ToString();
                string marca = CboxFiltroMarca.SelectedItem?.ToString();
                string nombre = txtNombreProducto.Text; 
                gridProducts.DataSource = null;
                gridProducts.DataSource = BuscarProducto(categoria, marca, nombre);
                ConfigurarColumnas();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e) //BOTON LIMPIAR FILTRO
        {
            try
            {
                CboxFiltroCategoria.SelectedIndex = -1;
                CboxFiltroMarca.SelectedIndex = -1;
                txtNombreProducto.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }
    }
}
