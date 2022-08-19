using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulationExercise
{
    public class BankAccount

    {
        private double balance = 0;

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void WithDraw(double amount)
        {
            balance -= amount;
        }

     

      

    
        
        

    }
}
