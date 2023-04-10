using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Patrones.Command.Core;

namespace Patrones.Command.UI3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AltaStock_Click(object sender, EventArgs e)
        {
            var cantidad = Int32.Parse(txtAltayBaja.Text);

            // Instancia empresa
            var empresa = new EmpresaInvoker();

            // Instancia producto
            var producto = new ProductoReceiver
            {
                Cantidad = Int32.Parse(txtCantidadProducto.Text),
                Nombre = "Producto"
            };

            var ordenAlta = new AltaStockCommand(producto, cantidad);
            empresa.TomarOrden(ordenAlta);
            empresa.ProcesarOrdenes();

            lblAltaStock.Text = $"Agregando { cantidad } de Computadoras";
            lblAltaStock.Visible = true;
            // Imprime la cantidad disponible del producto
            lblResultado.Text = $"Total de computadoras es { producto.Cantidad }";
            lblResultado.Visible = true;

        }

        protected void BajaStock_Click(object sender, EventArgs e)
        {
            var cantidad = Int32.Parse(txtAltayBaja.Text);

            // Instancia empresa
            var empresa = new EmpresaInvoker();

            // Instancia producto
            var producto = new ProductoReceiver
            {
                Cantidad = Int32.Parse(txtCantidadProducto.Text),
                Nombre = "Producto"
            };

            var ordenBaja = new BajaStockCommand(producto, cantidad);
            empresa.TomarOrden(ordenBaja);
            empresa.ProcesarOrdenes();

            lblBajaStok.Text = $"Quitando { cantidad } de Computadoras";
            lblBajaStok.Visible = true;
            // Imprime la cantidad disponible del producto
            lblResultado.Text = $"Total de computadoras es { producto.Cantidad }";
            lblResultado.Visible = true;


        }
    }
}