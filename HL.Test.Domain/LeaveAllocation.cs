using HL.Test.Domain.common;

namespace HL.Test.Domain
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }

        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public string Employeeid { get; set; } = string.Empty;
    }
}
