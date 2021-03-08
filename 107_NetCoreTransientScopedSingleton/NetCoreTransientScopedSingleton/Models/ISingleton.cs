using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreTransientScopedSingleton.Models
{
    public interface ISingleton
    {
        Guid GetOperation();
    }
}
