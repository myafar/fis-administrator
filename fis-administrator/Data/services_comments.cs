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
    
    public partial class services_comments
    {
        public int id { get; set; }
        public int service_id { get; set; }
        public int user_id { get; set; }
        public string description { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime updated_at { get; set; }
    
        public virtual services services { get; set; }
        public virtual users users { get; set; }
    }
}
