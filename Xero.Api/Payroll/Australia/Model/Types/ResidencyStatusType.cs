using System.Runtime.Serialization;

namespace Xero.Api.Payroll.Australia.Model.Types
{
    [DataContract(Namespace = "", Name = "ResidencyStatus")]
    public enum ResidencyStatusType
    {
        [EnumMember(Value = "AUSTRALIANRESIDENT")]
        AustralianResident,
        [EnumMember(Value = "FOREIGNRESIDENT")]
        ForeignResident,
        [EnumMember(Value = "WORKINGHOLIDAYMAKER")]
        WorkingHoliday,
    }
}