using ProyectoModel;
using ProyectoModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto
{
    public partial class AgregarMedidor : System.Web.UI.Page
    {
        private IMedidoresDAL medidorDAL = new MedidoresDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            Medidore medidor = new Medidore();
            medidor.numeroMedidor = Convert.ToInt32(this.nMedidorTxt.Text.Trim());
            medidor.fecha = Convert.ToDateTime(this.fechaTxt.Text.Trim());
            medidor.valorMedidor = this.valorTxt.Text.Trim();
            this.medidorDAL.AgregarMedidores(medidor);


            Response.Redirect("MostrarMedidor.aspx");
        }
    }
}