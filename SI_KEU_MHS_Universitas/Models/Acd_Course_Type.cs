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
    
    public partial class Acd_Course_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Acd_Course_Type()
        {
            this.Acd_Course = new HashSet<Acd_Course>();
            this.Fnc_Cost_Krs_Personal = new HashSet<Fnc_Cost_Krs_Personal>();
            this.Mstr_SKS_DURASI = new HashSet<Mstr_SKS_DURASI>();
        }
    
        public short Course_Type_Id { get; set; }
        public Nullable<short> Course_Type_Code { get; set; }
        public string Course_Type_Name { get; set; }
        public string Id_Character { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Course> Acd_Course { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fnc_Cost_Krs_Personal> Fnc_Cost_Krs_Personal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mstr_SKS_DURASI> Mstr_SKS_DURASI { get; set; }
    }
}
