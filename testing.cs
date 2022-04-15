using Pallas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class TestingClass {
    public static void main(string[] args)
    {
        Pallas.transaction.transaction transaction_new = new Pallas.transaction.transaction();
        Console.WriteLine(transaction_new);
    }
}