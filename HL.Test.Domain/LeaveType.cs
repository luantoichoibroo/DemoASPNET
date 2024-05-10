using HL.Test.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL.Test.Domain
{
    public class LeaveType:BaseEntity
    {
        public string Name { get; set; }   
        public int DefaultDays { get; set; }

    }
}
