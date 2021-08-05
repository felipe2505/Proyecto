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
    public partial class AgregarPersonas : System.Web.UI.Page
    {
        private IMedidoresDAL medidorDAL = new MedidoresDALDB();
        private IPErsonasDAL personasDAL = new PersonasDALDB();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.medidorDDL.DataSource = this.medidorDAL.ObtenerMedidores();
                this.medidorDDL.DataTextField = "numeroMedidor";
                this.medidorDDL.DataValueField = "id";
                this.medidorDDL.DataBind();
            }
        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            persona.rut = this.rutTxt.Text.Trim();
            persona.nombre = this.nombreTxt.Text.Trim();
            persona.correo = this.correoTxt.Text.Trim();
            persona.contrasena = this.contrasenaTxt.Text.Trim();
            persona.idMedidor = Convert.ToInt32(this.medidorDDL.SelectedItem.Value);

            this.personasDAL.AgregarPersona(persona);


            Response.Redirect("MostrarPersonas.aspx");
        }
    }
}