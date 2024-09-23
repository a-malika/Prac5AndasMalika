using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical5
{
    internal class InvoiceCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new Invoice();
        }
    }
}
