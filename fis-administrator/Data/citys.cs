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
    
    public partial class citys
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public citys()
        {
            this.users_profile = new HashSet<users_profile>();
        }
    
        public int id { get; set; }
        public int country_id { get; set; }
        public string name { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime updated_at { get; set; }
    
        public virtual countrys countrys { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<users_profile> users_profile { get; set; }
    }
}