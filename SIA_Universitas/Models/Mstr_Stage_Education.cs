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
    
    public partial class Mstr_Stage_Education
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mstr_Stage_Education()
        {
            this.Emp_Employee_Education = new HashSet<Emp_Employee_Education>();
            this.Emp_Employee_Family = new HashSet<Emp_Employee_Family>();
            this.Emp_Postgraduate = new HashSet<Emp_Postgraduate>();
        }
    
        public short Stage_Education_Id { get; set; }
        public Nullable<short> Stage_Education_Code { get; set; }
        public string Stage_Education_Name { get; set; }
        public Nullable<decimal> Allowance { get; set; }
        public Nullable<int> Order_Id { get; set; }
        public Nullable<int> Stage_Education_Emp_Code { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emp_Employee_Education> Emp_Employee_Education { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emp_Employee_Family> Emp_Employee_Family { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emp_Postgraduate> Emp_Postgraduate { get; set; }
    }
}
