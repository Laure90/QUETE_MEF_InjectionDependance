using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace QUETE_MEF__Injection_de_dépendance
{
    class Program
    {
        private MefHost _host;
        static void Main(string[] args)
        {
            var program = new Program();
            program.Run();

            Console.ReadKey();
        }

        private void Run()
        {
            _host = new MefHost();
            SalutationService service = _host.Container.GetExportedValue<SalutationService>();
        }
    }
}
