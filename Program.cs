using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Какой тип документа желаете создать?");
            Console.WriteLine("1 - отчет, 2 - резюме, 3 - письмо, 4 - счет.");
            int UserAnswer = Convert.ToInt32(Console.ReadLine());

            Document document;
            DocumentCreator creator;
            switch(UserAnswer)
            {
                case 1:
                    creator = new ReportCreator();
                    document = creator.CreateDocument();
                    break;
                case 2:
                    creator = new ResumeCreator();
                    document = creator.CreateDocument();
                    break;
                case 3:
                    creator = new LetterCreator();
                    document = creator.CreateDocument();
                    break;
                case 4:
                    creator = new InvoiceCreator();
                    document = creator.CreateDocument();
                    break;
                default:
                    throw new Exception("Такого типа документа не предусмотрено.");
            }
            document.Open();
        }
    }
}
