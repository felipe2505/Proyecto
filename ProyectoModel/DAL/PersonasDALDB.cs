using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModel.DAL
{
    public class PersonasDALDB : IPErsonasDAL
    {
        private ProyectoEntities eventosDB = new ProyectoEntities();

        public void AgregarPersona(Persona persona)
        {
            this.eventosDB.Personas.Add(persona);
            this.eventosDB.SaveChanges();
        }

        public void EliminarPersona(int id)
        {
            Persona persona = this.eventosDB.Personas.Find(id);
            this.eventosDB.Personas.Remove(persona);
            this.eventosDB.SaveChanges();
        }

        public Persona obtener(int id)
        {
            return this.eventosDB.Personas.Find(id);
        }

        public void Actualizar(Persona a)
        {
            Persona aOriginal = this.eventosDB.Personas.Find(a.id);
            aOriginal.nombre = a.nombre;
            aOriginal.correo = a.correo;
            this.eventosDB.SaveChanges();
        }


        public List<Persona> ObtenerPersonas()
        {
            return this.eventosDB.Personas.ToList();
        }

        public List<Persona> ObtenerPersonas(string nombre)
        {
            var query = from a in this.eventosDB.Personas
                        where a.nombre == nombre
                        select a;
            return query.ToList();
        }
    }
}
