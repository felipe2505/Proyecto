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
    public partial class MostrarMedidor : System.Web.UI.Page
    {
        private IMedidoresDAL medidorDAL = new MedidoresDALDB();
        private void cargarGrilla(List<Medidore> medidores)
        {
            this.grillaMedidor.DataSource = medidores;
            this.grillaMedidor.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargarGrilla(this.medidorDAL.ObtenerMedidores());
            }
        }
    }
}