//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class destinacija
    {
        public destinacija()
        {
            this.putovanje = new HashSet<putovanje>();
        }
    
        public int destinacija_id { get; set; }
        public string lokacija { get; set; }
        public string opis { get; set; }
    
        public virtual ICollection<putovanje> putovanje { get; set; }
    }
}
