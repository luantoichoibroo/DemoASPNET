using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL.Test.Domain.common
{
    public class BaseEntity
    {
        public DateTime DateCreate { get; set; }
        public string? CreateBy { get; set; }

        public DateTime DateModified { get; set; }

        public string Modify { get; set; }

    }
}
