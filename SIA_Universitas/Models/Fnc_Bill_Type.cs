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
    
    public partial class Fnc_Bill_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fnc_Bill_Type()
        {
            this.Fnc_Cost_Regular_Personal = new HashSet<Fnc_Cost_Regular_Personal>();
            this.Fnc_Student_Payment = new HashSet<Fnc_Student_Payment>();
        }
    
        public short Bill_Type_Id { get; set; }
        public Nullable<short> Bill_Type_Code { get; set; }
        public string Bill_Type_Name { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fnc_Cost_Regular_Personal> Fnc_Cost_Regular_Personal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fnc_Student_Payment> Fnc_Student_Payment { get; set; }
    }
}
