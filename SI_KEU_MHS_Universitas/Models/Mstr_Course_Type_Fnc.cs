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
    
    public partial class Mstr_Course_Type_Fnc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mstr_Course_Type_Fnc()
        {
            this.Fnc_Course_Type = new HashSet<Fnc_Course_Type>();
        }
    
        public short Course_Type_Fnc_Id { get; set; }
        public string Course_Type_Fnc_Code { get; set; }
        public string Course_Type_Fnc_Name { get; set; }
        public Nullable<short> Cost_Item_Id { get; set; }
    
        public virtual Fnc_Cost_Item Fnc_Cost_Item { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fnc_Course_Type> Fnc_Course_Type { get; set; }
    }
}
