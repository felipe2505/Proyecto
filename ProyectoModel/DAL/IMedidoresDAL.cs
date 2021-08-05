using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModel.DAL
{
    public interface IMedidoresDAL
    {
        List<Medidore> ObtenerMedidores();

        List<Medidore> ObtenerMedidores(int numeroMedidor);

        void AgregarMedidores(Medidore medidores);

        Medidore obtener(int id);

        void EliminarMedidor(int id);
    }
}
