using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Manejo_de_excepciones
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int money;
            string userName;
            Console.WriteLine("Ingrese su nombre: ");
            userName = Console.ReadLine();
            User user = new User(userName,5000);
            try
            {
                Console.WriteLine($"Hola {user.Name}, tu saldo inicial es de: ${user.Balance} ");
                Console.WriteLine("El limite de tu cuenta es de $65000 y no puedes contar con balance negativa ya que tu linea de credito esta suspendida.");
                Console.WriteLine("Ingrese cambio en el balance:");
                money = Convert.ToInt32(Console.ReadLine());
                user.BalanceException(money);
            }
            catch(FormatException error)
            {
                Console.WriteLine(error.Message);
            }
            catch (BalanceException error2)
            {
                Console.WriteLine(error2.Message);
            }
            finally
            {
                Console.WriteLine($"{user.Name}, luego del movimiento tu saldo final es de: ${user.Balance} ");
            }

            Console.ReadKey();
        }
    }
}
