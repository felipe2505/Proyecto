//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medidore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medidore()
        {
            this.Personas = new HashSet<Persona>();
        }
    
        public int id { get; set; }
        public Nullable<int> numeroMedidor { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string valorMedidor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Persona> Personas { get; set; }
    }
}