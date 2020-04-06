using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace QUETE_MEF__Injection_de_dépendance
{
    [Export]
    public class SalutationService
    {
        [Import]
        private HelloSayer helloSayer;
    }
}
