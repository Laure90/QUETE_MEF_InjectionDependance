using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace QUETE_MEF__Injection_de_dépendance
{
    public class MefHost
    {
        public CompositionContainer Container
        {
            get
            {
                if (_container == null)
                {
                    AssemblyCatalog catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
                    _container = new CompositionContainer(catalog);
                }
                return _container;
            }
        }
        private CompositionContainer _container = null;
    }

}
