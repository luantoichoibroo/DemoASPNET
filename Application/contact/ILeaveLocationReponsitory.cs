using HL.Test.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL.Application.contact
{
    public interface ILeaveLocationReponsitory
    {
        Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id);
        Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails();
        Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails(string userId);
        Task<bool> AllocationExists(string userId, int leaveTypeId, int period);

        Task AddAllocation(List<LeaveAllocation> allocations);
        Task<LeaveAllocation> GetUserAllocation(string userId, int leaveTypeId);
    }
}
