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
    
    public partial class Org
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Org()
        {
            this.Org_Child = new HashSet<Org_Child>();
            this.Org1 = new HashSet<Org>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> SchoolId { get; set; }
        public Nullable<int> OldId { get; set; }
        public string CompanyName { get; set; }
        public Nullable<int> TypeId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<int> TerritoryId { get; set; }
        public Nullable<int> ContactId { get; set; }
        public Nullable<int> Decile { get; set; }
        public Nullable<int> Roll { get; set; }
        public Nullable<int> RollApproved { get; set; }
        public Nullable<System.DateTime> LeaseStart { get; set; }
        public Nullable<System.DateTime> LeaseEnd { get; set; }
        public string LeasorName { get; set; }
        public Nullable<decimal> LeaseCostFixed { get; set; }
        public string MeetingRoom { get; set; }
        public string BankAccNum { get; set; }
        public string MsdNum { get; set; }
        public string OscarNum { get; set; }
        public string Comments { get; set; }
        public string ExtraChargeType { get; set; }
        public Nullable<decimal> ExtraMinRate { get; set; }
        public Nullable<int> BeforeThreshold { get; set; }
        public Nullable<int> AfterThreshold { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdateOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool HasSaved { get; set; }
        public byte[] Version { get; set; }
        public Nullable<System.DateTime> LicenceStart { get; set; }
        public Nullable<System.DateTime> LicenceEnd { get; set; }
        public Nullable<decimal> WeeklyAdminCost { get; set; }
        public Nullable<decimal> WeeklyRentCost { get; set; }
        public Nullable<decimal> CurrentRevenue { get; set; }
        public Nullable<decimal> CurrentExpenses { get; set; }
        public Nullable<decimal> CurrentBalance { get; set; }
        public Nullable<decimal> CurrentOverdueAmt { get; set; }
        public string MasterPin { get; set; }
        public Nullable<bool> IsChildPhotoEnabled { get; set; }
        public Nullable<bool> IsAuthPhotoEnabled { get; set; }
        public Nullable<bool> IsStaffPhotoEnabled { get; set; }
        public Nullable<bool> IsMultiSitePickupEnabled { get; set; }
        public Nullable<bool> IsFreeTrial { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public string StaffClockMethod { get; set; }
        public Nullable<int> LeaseCostPercentage { get; set; }
        public Nullable<bool> IsPaymentGatewayEnabled { get; set; }
        public string SiteBankAccNum { get; set; }
        public Nullable<decimal> LicenceFee { get; set; }
        public Nullable<bool> IsDashboardMsgEnabled { get; set; }
        public Nullable<bool> IsEMailMsgEnabled { get; set; }
        public Nullable<bool> IsSMSMsgEnabled { get; set; }
        public string SiteContactPersone { get; set; }
        public string SiteContactPhoneFixed { get; set; }
        public string SiteContactEmail { get; set; }
        public bool InvoiceDateSetting { get; set; }
        public string HeadOfficeLogo { get; set; }
        public Nullable<bool> IsWizard { get; set; }
        public Nullable<int> LastStep { get; set; }
        public Nullable<bool> IsProgrammePriceVisible { get; set; }
        public Nullable<bool> IsBookingPromoMsgVisible { get; set; }
        public string BookingPromotionMsg { get; set; }
        public Nullable<bool> IsHolBookingPromoMsgVisible { get; set; }
        public string HolBookingPromoMsg { get; set; }
        public Nullable<bool> IsSpecialBookingPromoMsgVisible { get; set; }
        public string SpecialBookingPromoMsg { get; set; }
        public string LoginURL { get; set; }
        public bool ShowCustomisedBooking { get; set; }
        public Nullable<int> InvoiceDay { get; set; }
        public Nullable<int> InvoiceDueDays { get; set; }
        public int InvoiceGenDay { get; set; }
        public int InvoiceGenWeek { get; set; }
        public int InvoiceDueDay { get; set; }
        public int InvoiceDueWeek { get; set; }
        public Nullable<bool> IsInvArrearBasedOnStart { get; set; }
        public Nullable<int> CSSBillingPlanId { get; set; }
        public Nullable<System.DateTime> CSSRevireDate { get; set; }
        public string CSSComment { get; set; }
        public string BookingInfoRegular { get; set; }
        public string BookingInfoCasual { get; set; }
        public Nullable<bool> IsNew { get; set; }
        public Nullable<int> CurrentStatus { get; set; }
        public string Logo { get; set; }
        public Nullable<bool> AllowOverdueNotification { get; set; }
        public Nullable<bool> IsCreditCardPaymentDisabled { get; set; }
        public Nullable<int> NewChildFlagDays { get; set; }
        public Nullable<bool> ExclusionDayIsChargeable { get; set; }
        public Nullable<bool> IsAimyClient { get; set; }
        public Nullable<bool> CustomisedBookingCalendarReadOnly { get; set; }
        public Nullable<bool> ShowParentDOB { get; set; }
        public Nullable<bool> IsMergeReconcilInvoice { get; set; }
        public Nullable<bool> IsDeductByCCPayment { get; set; }
        public string SiteLandlineNumberFixed { get; set; }
        public string SiteStreetNum { get; set; }
        public string SiteAddress { get; set; }
        public string SiteSuburb { get; set; }
        public string SiteCity { get; set; }
        public string SitePostCode { get; set; }
        public string SiteCountry { get; set; }
        public string SiteLatitude { get; set; }
        public string SiteLongitude { get; set; }
        public string TimeZoneIdentifier { get; set; }
        public string Culture { get; set; }
        public string Language { get; set; }
        public string SiteContactPhone { get; set; }
        public string SiteLandlineNumber { get; set; }
        public string TradingName { get; set; }
        public string TaxNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Org_Child> Org_Child { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Org> Org1 { get; set; }
        public virtual Org Org2 { get; set; }
    }
}
