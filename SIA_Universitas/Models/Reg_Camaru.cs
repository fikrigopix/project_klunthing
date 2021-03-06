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
    
    public partial class Reg_Camaru
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reg_Camaru()
        {
            this.Acd_Student = new HashSet<Acd_Student>();
            this.Acd_Student_Out = new HashSet<Acd_Student_Out>();
            this.Fnc_Cost_Regular_Personal = new HashSet<Fnc_Cost_Regular_Personal>();
            this.Fnc_Cost_Regular_Personal_Up = new HashSet<Fnc_Cost_Regular_Personal_Up>();
            this.Reg_Camaru_RAPORT = new HashSet<Reg_Camaru_RAPORT>();
        }
    
        public long Camaru_Id { get; set; }
        public string Camaru_Code { get; set; }
        public string Camaru_Test_Number { get; set; }
        public Nullable<short> Entry_Year_Id { get; set; }
        public Nullable<short> Entry_Period_Id { get; set; }
        public Nullable<byte> Entry_Term_Id { get; set; }
        public string Full_Name { get; set; }
        public string Nick_Name { get; set; }
        public Nullable<byte> Gender_Id { get; set; }
        public byte Religion_Id { get; set; }
        public string Current_Address { get; set; }
        public Nullable<byte> Residence_Type_Id { get; set; }
        public Nullable<short> City_Id { get; set; }
        public string Blood_Id { get; set; }
        public string Photo { get; set; }
        public string Photo_Status { get; set; }
        public Nullable<byte> High_School_Major_Id { get; set; }
        public string Zip_Code { get; set; }
        public Nullable<byte> Marital_Status_Id { get; set; }
        public string Origin_Address { get; set; }
        public string Origin_Zip { get; set; }
        public string Phone_Home { get; set; }
        public string Phone_Mobile { get; set; }
        public string Email_Address { get; set; }
        public string Prev_Camaru_Id { get; set; }
        public string Education_Group_Id { get; set; }
        public Nullable<short> Register_Status_Id { get; set; }
        public Nullable<short> Department_Choice { get; set; }
        public Nullable<float> Registration_Payment { get; set; }
        public string Registration_Paid { get; set; }
        public Nullable<System.DateTime> Registration_Date { get; set; }
        public Nullable<System.DateTime> Registration_Time { get; set; }
        public string Nip_Registration { get; set; }
        public string Exam_Enterance_Address { get; set; }
        public Nullable<bool> Is_Retake { get; set; }
        public string Recipe_Id { get; set; }
        public string Birth_Place { get; set; }
        public Nullable<System.DateTime> Birth_Date { get; set; }
        public string LOKASI_ID { get; set; }
        public string SUB_LOKASI_ID { get; set; }
        public string JNS_DAFTAR { get; set; }
        public Nullable<short> TAHAP_KE { get; set; }
        public string Description { get; set; }
        public Nullable<short> Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<short> Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Student> Acd_Student { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Student_Out> Acd_Student_Out { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fnc_Cost_Regular_Personal> Fnc_Cost_Regular_Personal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fnc_Cost_Regular_Personal_Up> Fnc_Cost_Regular_Personal_Up { get; set; }
        public virtual Mstr_Entry_Year Mstr_Entry_Year { get; set; }
        public virtual Mstr_Gender Mstr_Gender { get; set; }
        public virtual Mstr_High_School_Major Mstr_High_School_Major { get; set; }
        public virtual Mstr_Marital_Status Mstr_Marital_Status { get; set; }
        public virtual Mstr_Religion Mstr_Religion { get; set; }
        public virtual Mstr_Residence_Type Mstr_Residence_Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reg_Camaru_RAPORT> Reg_Camaru_RAPORT { get; set; }
    }
}
