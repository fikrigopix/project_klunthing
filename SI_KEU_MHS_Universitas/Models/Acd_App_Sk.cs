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
    
    public partial class Acd_App_Sk
    {
        public long App_Sk_Id { get; set; }
        public short Term_Year_Id { get; set; }
        public string Payer { get; set; }
        public short Sk_Type_Id { get; set; }
        public long Student_Id { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
        public string Description { get; set; }
        public Nullable<short> Retur_Id { get; set; }
        public Nullable<short> Faculty_Id { get; set; }
        public Nullable<short> Department_Id { get; set; }
        public Nullable<short> Class_Prog_Id { get; set; }
        public string Full_Name { get; set; }
        public string Admited_Univ { get; set; }
        public string Admited_Department { get; set; }
        public string Admited_Class_Prog { get; set; }
        public Nullable<short> Register_Status_Id { get; set; }
        public Nullable<short> Order_Id { get; set; }
    
        public virtual Acd_Student Acd_Student { get; set; }
        public virtual Mstr_Class_Program Mstr_Class_Program { get; set; }
        public virtual Mstr_Department Mstr_Department { get; set; }
        public virtual Mstr_Faculty Mstr_Faculty { get; set; }
        public virtual Mstr_Term_Year Mstr_Term_Year { get; set; }
        public virtual SK_TYPE SK_TYPE { get; set; }
    }
}
