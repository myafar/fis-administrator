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
    
    public partial class transactions_returns
    {
        public int id { get; set; }
        public int transaction_id { get; set; }
        public int description { get; set; }
        public decimal mount { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime updated_at { get; set; }
    
        public virtual transaccions transaccions { get; set; }
    }
}
