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
    
    public partial class Mstr_Subdistrict
    {
        public int Subdistrict_Id { get; set; }
        public Nullable<int> District_Id { get; set; }
        public string Subdistrict_Code { get; set; }
        public string Subdistrict_Name { get; set; }
        public Nullable<int> Order_Id { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
    
        public virtual Mstr_District Mstr_District { get; set; }
    }
}
