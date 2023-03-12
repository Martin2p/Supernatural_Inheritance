using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Computerfirma
{
    class Displayable
    {
        interface IDisplayable
        {
            //Elemente in Interfaces sind immer public!
            string Display();
        }
    }
}
