//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoldMasterDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class MaintenancePlan
    {
        public int ID { get; set; }
        public int MoldID { get; set; }
        public System.DateTime PlanStartDate { get; set; }
        public System.DateTime PlanEndDate { get; set; }
        public string Notes { get; set; }
    
        public virtual Mold Mold { get; set; }
    }
}