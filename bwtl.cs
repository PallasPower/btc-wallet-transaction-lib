using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pallas;

namespace Pallas
{
    public class bwtl
    {
       public static void main(string[] args)
        {
            Pallas.transaction.transaction transaction_new = new Pallas.transaction.transaction();
            transaction_new.price = 20.0f;

            Console.WriteLine(transaction_new);
        }
    }
}
