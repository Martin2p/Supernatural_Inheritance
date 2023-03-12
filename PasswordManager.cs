using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Computerfirma
{
    class PasswordManager : Displayable 
    {

        //Properties
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }


        //Konstruktor
        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

     
        //Methode aus IDisplayable
        public void Display()
        {
            if (Hidden == false)
            {
                Console.WriteLine(Password);
            }
            else 
            {
                Hidden = true;
                Console.WriteLine("*");
            }
        }

        //Methode aus IResetable

        public void Reset()
        {
            Password = " ";
            Hidden = false;
        }

    }
}
