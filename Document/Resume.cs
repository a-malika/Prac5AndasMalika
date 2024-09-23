using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical5
{
    internal class Resume : Document
    {
        public override void Open()
        {
            Console.WriteLine("Резюме открыто.");
        }
    }
}
