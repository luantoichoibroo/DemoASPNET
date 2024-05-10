﻿using HL.Test.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL.Application.contact
{
    public interface ILeaveRequestReponsitory:IGenericResponsivetory<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails();
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails(string userId);
    }
}
