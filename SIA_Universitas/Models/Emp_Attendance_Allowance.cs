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
    
    public partial class Emp_Attendance_Allowance
    {
        public int Attendance_Allowance_Id { get; set; }
        public byte Month_Id { get; set; }
        public short Year_Id { get; set; }
        public int Employee_Id { get; set; }
        public double Total { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
    
        public virtual Emp_Employee Emp_Employee { get; set; }
        public virtual Mstr_Entry_Year Mstr_Entry_Year { get; set; }
        public virtual Mstr_Month Mstr_Month { get; set; }
    }
}
