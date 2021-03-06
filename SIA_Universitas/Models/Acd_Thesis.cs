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
    
    public partial class Acd_Thesis
    {
        public long Thesis_Id { get; set; }
        public long Student_Id { get; set; }
        public Nullable<short> Term_Year_Id_Start { get; set; }
        public Nullable<short> Term_Year_Id_Complete { get; set; }
        public Nullable<int> Course_Id { get; set; }
        public Nullable<System.DateTime> Application_Date { get; set; }
        public Nullable<decimal> Sks_Trough { get; set; }
        public Nullable<decimal> Bnk { get; set; }
        public Nullable<bool> Is_Proposal { get; set; }
        public string Proposal_Title { get; set; }
        public Nullable<System.DateTime> Proposal_Date_Msk { get; set; }
        public Nullable<System.DateTime> Proposal_Date_Acc { get; set; }
        public string Sk_Proposal_Acc { get; set; }
        public string Functionary_Sk_Prop_Acc { get; set; }
        public string Position_Sk_Prop_Acc { get; set; }
        public string Thesis_Title { get; set; }
        public string Thesis_Title_Eng { get; set; }
        public Nullable<int> Supervisor_1 { get; set; }
        public Nullable<int> Supervisor_2 { get; set; }
        public Nullable<int> Examiner_1 { get; set; }
        public Nullable<int> Examiner_2 { get; set; }
        public Nullable<int> Examiner_3 { get; set; }
        public Nullable<System.DateTime> Thesis_Start_Date { get; set; }
        public Nullable<System.DateTime> Thesis_Exam_App_Date { get; set; }
        public Nullable<System.DateTime> Thesis_Exam_Date { get; set; }
        public string Thesis_Exam_Room { get; set; }
        public Nullable<System.DateTime> Invitation_Thesis_Exam_Date { get; set; }
        public Nullable<System.DateTime> Thesis_Complete_Date { get; set; }
        public Nullable<short> Total_Thesis_Exam { get; set; }
        public string Thesis_Exam_Score { get; set; }
        public Nullable<decimal> Sks_Trough_Exam { get; set; }
        public Nullable<decimal> Bnk_Exam { get; set; }
        public string Functionary_Department_Exam { get; set; }
        public string Functionary_Name_Department_Exam { get; set; }
        public string Grade { get; set; }
        public string Department_Functionary { get; set; }
        public string Department_Functionary_Name { get; set; }
        public string Permission_Thesis_Num { get; set; }
        public string Permission_Thesis_Page { get; set; }
        public Nullable<System.DateTime> Permission_Thesis_Date { get; set; }
        public string Company_Name { get; set; }
        public string Company_Address { get; set; }
        public string Functionary_Company { get; set; }
        public string Cq_Functionary_Company { get; set; }
        public Nullable<System.DateTime> Seminar_App_Date { get; set; }
        public Nullable<System.DateTime> Seminar_Date { get; set; }
        public string Seminar_Room { get; set; }
        public string Department_Seminar_Functionary { get; set; }
        public string Department_Seminar_Functionary_Name { get; set; }
        public string Permission_Thesis_Long_Text { get; set; }
        public Nullable<System.DateTime> Permission_Thesis_Start_Date { get; set; }
        public Nullable<System.DateTime> Permission_Thesis_Complete_Date { get; set; }
        public string Permission_Thesis_Project_Name { get; set; }
    
        public virtual Acd_Course Acd_Course { get; set; }
        public virtual Acd_Student Acd_Student { get; set; }
        public virtual Emp_Employee Emp_Employee { get; set; }
        public virtual Emp_Employee Emp_Employee1 { get; set; }
        public virtual Emp_Employee Emp_Employee2 { get; set; }
        public virtual Emp_Employee Emp_Employee3 { get; set; }
        public virtual Emp_Employee Emp_Employee4 { get; set; }
        public virtual Mstr_Term_Year Mstr_Term_Year { get; set; }
        public virtual Mstr_Term_Year Mstr_Term_Year1 { get; set; }
    }
}
