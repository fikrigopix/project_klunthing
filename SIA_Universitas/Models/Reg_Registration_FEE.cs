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
    
    public partial class Reg_Registration_FEE
    {
        public int Registration_Fee_Id { get; set; }
        public string Entry_Period_Id { get; set; }
        public short Year_Id { get; set; }
        public bool Is_Mengulang { get; set; }
        public Nullable<float> Fee_Rp { get; set; }
        public Nullable<int> Max_Return_Days { get; set; }
        public string Education_Group_Id { get; set; }
        public decimal Register_Stats_Id { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
    }
}
