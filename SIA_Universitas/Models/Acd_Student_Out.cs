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
    using System.Collections.Generic;
    
    public partial class Acd_Student_Out
    {
        public long Student_Out_Id { get; set; }
        public Nullable<long> Student_Id { get; set; }
        public Nullable<short> Term_Year_Id { get; set; }
        public Nullable<short> Department_From_Id { get; set; }
        public Nullable<short> Class_Prog_From_Id { get; set; }
        public Nullable<long> New_Camaru_Id { get; set; }
        public Nullable<short> Department_Destination { get; set; }
        public Nullable<short> Class_Prog_Destination { get; set; }
        public Nullable<System.DateTime> Out_Date { get; set; }
        public Nullable<short> Out_Reason_ID { get; set; }
        public string Reff_Resign { get; set; }
        public string Officer { get; set; }
        public string Description { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
    
        public virtual Acd_Student Acd_Student { get; set; }
        public virtual Mstr_Class_Program Mstr_Class_Program { get; set; }
        public virtual Mstr_Class_Program Mstr_Class_Program1 { get; set; }
        public virtual Mstr_Department Mstr_Department { get; set; }
        public virtual Mstr_Department Mstr_Department1 { get; set; }
        public virtual Mstr_Term_Year Mstr_Term_Year { get; set; }
        public virtual Reg_Camaru Reg_Camaru { get; set; }
    }
}
