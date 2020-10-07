using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_de_excepciones
{
    class User
    {
        private string name;
        private int balance;

        public User(string name, int balance)
        {
            this.name = name;
            this.balance = balance;
        }
        public void ChangeBalance(int money)
        {
            balance += money;
        }
       
        public void BalanceException(int money)
        {
            if ((balance + money) < 0) { throw new BalanceException("No tiene suficiente dinero"); }
            else if ((balance + money) > 65000) { throw new BalanceException("Su cuenta no puede tener tanto dinero"); }
            else ChangeBalance(money);
        }
        
        public string Name { get => name; }
        public int Balance { get => balance; }
    }

    
}
