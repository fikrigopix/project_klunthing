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
    
    public partial class Acd_Transcript_Final
    {
        public long Transcript_Final_Id { get; set; }
        public long Student_Id { get; set; }
        public string Course_Code { get; set; }
        public string Course_Name { get; set; }
        public string Course_Name_Eng { get; set; }
        public string Grade_Letter { get; set; }
        public Nullable<decimal> Sks { get; set; }
        public Nullable<decimal> Weight_Value { get; set; }
        public Nullable<short> Order_Id { get; set; }
        public Nullable<decimal> Bnk_Value { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
    
        public virtual Acd_Student Acd_Student { get; set; }
    }
}
