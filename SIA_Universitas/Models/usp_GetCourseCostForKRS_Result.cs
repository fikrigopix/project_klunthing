//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIA_Universitas.Models
{
    using System;
    
    public partial class usp_GetCourseCostForKRS_Result
    {
        public int course_id { get; set; }
        public string course_code { get; set; }
        public string course_name { get; set; }
        public string course_name_eng { get; set; }
        public Nullable<short> curriculum_id { get; set; }
        public string curriculum_name { get; set; }
        public Nullable<decimal> applied_sks { get; set; }
        public Nullable<bool> is_sks { get; set; }
        public Nullable<int> amount_per_sks { get; set; }
        public Nullable<int> amount_per_mk { get; set; }
        public Nullable<decimal> amount { get; set; }
    }
}
