using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Computerfirma
{
    class TodoList : Displayable
    {

        //Properties
        public string[] Todos
        { get; set; }

        private int nextOpenIndex;


        //Konstruktor
        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }


        //Methoden
        public void Add(string todo)
        {
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
        }

        //Methode aus IDisplayable
        public void Display()
        {
            Console.WriteLine(Todos);
        }

        //Methode aus IResetable
        public void Reset()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

    }
}
