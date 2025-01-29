using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankServices
{
    internal class Program
    {
        List<Accounts> accounts;
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                //argument sent
                switch (args[0])
                {
                    case "test":

                        break;
                    case "apply-interest":
                        InterestService interestService = new InterestService();

                        interestService.ApplyInterestToAccounts(accounts);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("No arguments sent");
            }
        }
    }
}
