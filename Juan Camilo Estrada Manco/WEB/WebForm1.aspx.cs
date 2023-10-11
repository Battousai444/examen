using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libExamenTour.ExamenTour;

namespace WebExamenTour.webExamen
{
    public partial class WebForm1 : System.Web.UI.Page
    {
   

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcularValor_Click(object sender, EventArgs e)
        {
            string tour;
            bool almuerzo;
            Int16 Npersonas;

            tour = ddlTour.Text;
            Npersonas = Convert.ToInt16(txtNpersonas.Text);
            almuerzo = CheckAlmuerzo.Checked;

            clsExamenTour oTour = new clsExamenTour();
            oTour.Tour = tour;
            oTour.Npersonas = Npersonas;
            oTour.Almuerzo = almuerzo;

            if (oTour.CalcularTotal())
            {
                txtValorSinDescuento.Text ="$ " + oTour.valorSinDes.ToString("#,###");
                txtDescuento.Text ="$ " + oTour.valorDescuento.ToString("#,###");
                txtValorPagar.Text = "$ " + oTour.valortotal.ToString("#,###");
                txtValorAntesIva.Text ="$ "+ oTour.Subtotal.ToString("#,###");
                txtValorIva.Text = "$ "+ oTour.valorIva.ToString("#,###");
                txtError.Text = " ";

            }
            else 
            {
                txtError.Text = oTour.Error;
                txtValorSinDescuento.Text = "-";
                txtDescuento.Text = "-";
                txtValorPagar.Text = "-";
                txtValorAntesIva.Text = "-";
                txtValorIva.Text = "-";
            }

        }
        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorSinDescuento.Text = "-";
            txtDescuento.Text = "-";
            txtValorPagar.Text = "-";
            txtValorAntesIva.Text = "-";
            txtValorIva.Text = "-";
            txtError.Text = " ";
        }
    }
    
}