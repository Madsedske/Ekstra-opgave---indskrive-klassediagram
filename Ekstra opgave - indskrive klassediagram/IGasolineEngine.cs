using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekstra_opgave___indskrive_klassediagram
{
    interface IGasolineEngine : IEngine
    {
         void Inject(); // Jeg måtte ikke bruge 'public' pga forkert language version. Min er 7.3, og den ville have 8.0.

    }
}
