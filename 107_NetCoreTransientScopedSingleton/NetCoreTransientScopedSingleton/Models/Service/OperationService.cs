using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreTransientScopedSingleton.Models.Service
{
    public class OperationService : ITransient,ISingleton,IScoped
    {
        private Guid _id;
        public OperationService()
        {
            _id = Guid.NewGuid();
        }

        public Guid GetOperation()
        {
            return _id;
        }
    }
}
