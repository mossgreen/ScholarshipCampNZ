//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pivotDemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Child
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Child()
        {
            this.Org_Child = new HashSet<Org_Child>();
        }
    
        public int Id { get; set; }
        public Nullable<int> ContactId { get; set; }
        public string Name { get; set; }
        public string KnownName { get; set; }
        public Nullable<int> EmergencyContact1Id { get; set; }
        public Nullable<int> EmergencyContact2Id { get; set; }
        public Nullable<int> YearEnrolled { get; set; }
        public string Ethnicity { get; set; }
        public string LanguageSpoken { get; set; }
        public Nullable<bool> CustodyDispute { get; set; }
        public string CustodyDisputeDescription { get; set; }
        public Nullable<bool> WearsGlasses { get; set; }
        public Nullable<bool> HearingAid { get; set; }
        public string Instructions { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public byte[] Version { get; set; }
        public Nullable<int> SchoolId { get; set; }
        public Nullable<bool> AllowPhotoTag { get; set; }
        public string ClassRoom { get; set; }
        public string TeacherName { get; set; }
        public Nullable<bool> CYF { get; set; }
        public string CYFDescription { get; set; }
        public Nullable<bool> IsVegererian { get; set; }
        public Nullable<bool> GlutenFree { get; set; }
        public string Notes { get; set; }
        public string ChildDoctorName { get; set; }
        public string ChildDoctorContactFixed { get; set; }
        public Nullable<bool> IsTetanusImmunised { get; set; }
        public string SwimmingCompetency { get; set; }
        public string Subject { get; set; }
        public string Year { get; set; }
        public string ChildDoctorContact { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Org_Child> Org_Child { get; set; }
    }
}
