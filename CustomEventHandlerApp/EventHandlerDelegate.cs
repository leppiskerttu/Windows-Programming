using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment5Delegate
{
    // Määritellään delegaatti, joka mahdollistaa erilaisten toimintojen suorittamisen CustomEventHandler-luokan kautta.
    public delegate string HandleEvent(string name, string type, string location, DateTime date, double price);
}
