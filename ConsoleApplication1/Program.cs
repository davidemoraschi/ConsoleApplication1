using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrmDemoContext;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            CrmDemoDataContext context = new CrmDemoDataContext();
            var query = from it in context.Companies
                        orderby it.Companyid
                        select it;

            foreach (Company comp in query)
            {
                if (comp.Personcontacts.Count > 0)
                {
                    Console.WriteLine("{0} | {1} | {2}",
                      comp.Companyname, comp.Personcontacts[0].Firstname,
                      comp.Personcontacts[0].Lastname);
                }
            }

            Console.ReadLine();
        }
    }
}
