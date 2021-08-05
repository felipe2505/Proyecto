using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModel.DAL
{
    public interface IPErsonasDAL
    {
        List<Persona> ObtenerPersonas();

        List<Persona> ObtenerPersonas(string nombre);

        Persona obtener(int id);

        void AgregarPersona(Persona persona);

        void EliminarPersona(int id);

        void Actualizar(Persona a);
    }
}
