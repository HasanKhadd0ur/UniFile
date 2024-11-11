
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniFile.Core.Errors.Base
{

    public class ErrorBase
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public IEnumerable<ErrorBase> CausedBy { get; set; }
    }
}
