//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fis_administrator.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class services
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public services()
        {
            this.services_comments = new HashSet<services_comments>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public int type_id { get; set; }
        public string description { get; set; }
        public int user_id { get; set; }
        public decimal price { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime updated_at { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<services_comments> services_comments { get; set; }
        public virtual services_confirm services_confirm { get; set; }
        public virtual services_types services_types { get; set; }
        public virtual users users { get; set; }
    }
}
