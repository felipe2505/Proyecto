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
    public partial class MostrarPersonas : System.Web.UI.Page
    {
        private IPErsonasDAL personasDAL = new PersonasDALDB();
        private void cargarGrilla(List<Persona> personas)
        {
            this.grillaAsistentes.DataSource = personas;
            this.grillaAsistentes.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargarGrilla(this.personasDAL.ObtenerPersonas());
            }
        }
    }
}