//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPIAppsistencia
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContratosXAsistente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContratosXAsistente()
        {
            this.DetallesXContrato = new HashSet<DetallesXContrato>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ID_Asistente { get; set; }
        public Nullable<System.DateTime> Fecha_Inicio { get; set; }
        public Nullable<System.DateTime> Fecha_Final { get; set; }
        public Nullable<int> Estado { get; set; }
    
        public virtual Asistente Asistente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallesXContrato> DetallesXContrato { get; set; }
    }
}
