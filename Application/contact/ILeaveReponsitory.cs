using HL.Test.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL.Application.contact
{
    public interface ILeaveReponsitory : IGenericResponsivetory<LeaveType>
    {
        Task<bool> ILeaveTypeUineque(string name);
    }
}
