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
        private List<Product> products = new List<Product>();
        private Order order = null;
        private ProductBusiness _product = new ProductBusiness();
        private ProductCategoryBusiness _category = new ProductCategoryBusiness();
        private ProductBrandBusiness _brand = new ProductBrandBusiness();


        //METODOS PRIVADOS
        private List<Product> FindProduct(string category, string brand, string name) //BUSCAR PRODUCTO
        {
            if (!string.IsNullOrEmpty(category) || !string.IsNullOrEmpty(brand) || !string.IsNullOrEmpty(name))
            {
                return _product.GetAllProducts(category, brand, name);
            }
            else
                return _product.GetAllProducts();
        }

        private void SetGridColumnSize() //CONFIGURA COLUMNAS DEL DATAGRIDVIEW
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
                string category = CboxFiltroCategoria.SelectedItem?.ToString();
                string brand = CboxFiltroMarca.SelectedItem?.ToString();
                string name = txtNombreProducto.Text; 
                products = FindProduct(category, brand, name);
                gridProducts.DataSource = null;
                gridProducts.DataSource = products;
                SetGridColumnSize();
                
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

        private void btnAgregarProducto_Click(object sender, EventArgs e) //BOTON AGREGAR PRODUCTO
        {
            try
            {
                if (gridProducts.SelectedRows.Count == 0) throw new Exception("Debe seleccionar un producto para agregar al pedido");

                if(string.IsNullOrEmpty(txtCantidadProducto.Text)) throw new Exception("Debe ingresar la cantidad que desea agregar al pedido");

                int id = Convert.ToInt32(gridProducts.SelectedRows[0].Cells[0].Value);

                int cantidad = Convert.ToInt32(txtCantidadProducto.Text);

                var item = new Item
                {
                    _product = products.Where(P => P.IdProduct == id).SingleOrDefault(),
                    Quantity = cantidad
                };

                order.Items.Add(item);

                txtCantidadProducto.Text = string.Empty;
            }
            catch (FormatException)
            {
                txtCantidadProducto.Focus();
                string message = "El apartado cantidad solo acepta valores numericos";
                MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
