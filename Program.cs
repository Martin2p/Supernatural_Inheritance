﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Computerfirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //Konstruktoraufruf
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");

            tdl.Display();
            tdl.Reset();
            tdl.Display();


            PasswordManager pm = new PasswordManager("iluvpie", true);

            pm.Display();
            pm.Reset();
            pm.Display();


        }
    }
}
