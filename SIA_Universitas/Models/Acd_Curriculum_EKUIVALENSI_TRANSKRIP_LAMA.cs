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
    
    public partial class Acd_Curriculum_EKUIVALENSI_TRANSKRIP_LAMA
    {
        public string PERUBAHAN_ID { get; set; }
        public Nullable<short> Faculty_Id { get; set; }
        public short Department_Id { get; set; }
        public short Available_Edu_Id { get; set; }
        public long Student_Id { get; set; }
        public short Course_Id { get; set; }
        public string Grade_Letter { get; set; }
        public Nullable<float> Grade_Number { get; set; }
        public Nullable<short> Year_Id { get; set; }
        public Nullable<byte> Term_Id { get; set; }
        public Nullable<short> HASIL_UJIAN_KE { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
        public Nullable<decimal> Sks { get; set; }
        public Nullable<bool> Is_Transfer { get; set; }
        public Nullable<decimal> Weight_Value { get; set; }
        public Nullable<bool> Is_Pakai { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Is_Required { get; set; }
        public Nullable<bool> Prasyarat_BT { get; set; }
        public Nullable<System.DateTime> Inserted_Time { get; set; }
        public Nullable<short> Term_Year_Id { get; set; }
        public Nullable<short> Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
    }
}
