using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical5
{
    internal class ReportCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new Report();
        }
    }
}
