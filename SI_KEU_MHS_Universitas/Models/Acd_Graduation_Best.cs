//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SI_KEU_MHS_Universitas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Acd_Graduation_Best
    {
        public short Graduation_Best_Id { get; set; }
        public short Graduate_Period_Id { get; set; }
        public short Department_Id { get; set; }
        public long Student_Id { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
    
        public virtual Acd_Graduation_Period Acd_Graduation_Period { get; set; }
        public virtual Acd_Student Acd_Student { get; set; }
        public virtual Mstr_Department Mstr_Department { get; set; }
    }
}
