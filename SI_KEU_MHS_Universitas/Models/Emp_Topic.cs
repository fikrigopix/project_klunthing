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
    
    public partial class Emp_Topic
    {
        public int Topic_Id { get; set; }
        public int Employee_Id { get; set; }
        public string Title { get; set; }
        public string Topic_Content { get; set; }
        public System.DateTime Date { get; set; }
        public bool Publish { get; set; }
        public Nullable<int> Topic_View { get; set; }
        public Nullable<System.DateTime> Last_Access { get; set; }
        public Nullable<int> Parent_Id { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
    
        public virtual Emp_Employee Emp_Employee { get; set; }
    }
}
