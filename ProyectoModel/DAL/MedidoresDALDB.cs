using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModel.DAL
{
     public class MedidoresDALDB : IMedidoresDAL
    {
        private ProyectoEntities eventosDB = new ProyectoEntities();

        public void AgregarMedidores(Medidore medidores)
        {
            this.eventosDB.Medidores.Add(medidores);
            this.eventosDB.SaveChanges();
        }

        public void EliminarMedidor(int id)
        {
            Medidore medidores = this.eventosDB.Medidores.Find(id);
            this.eventosDB.Medidores.Remove(medidores);
            this.eventosDB.SaveChanges();
        }

        public Medidore obtener(int id)
        {
            return this.eventosDB.Medidores.Find(id);
        }

        public List<Medidore> ObtenerMedidores()
        {
            return this.eventosDB.Medidores.ToList();
        }

        public List<Medidore> ObtenerMedidores(int numeroMedidor)
        {
            var query = from a in this.eventosDB.Medidores
                        where a.numeroMedidor == numeroMedidor
                        select a;
            return query.ToList();
        }
    }
}
