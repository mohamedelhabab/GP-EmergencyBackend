//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GP_EmergencyBackend.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class city
    {
        public city()
        {
            this.real_accident = new HashSet<real_accident>();
        }
    
        public int city_id { get; set; }
        public string city_name { get; set; }
        public int country_id { get; set; }
    
        public virtual country country { get; set; }
        public virtual ICollection<real_accident> real_accident { get; set; }
    }
}
