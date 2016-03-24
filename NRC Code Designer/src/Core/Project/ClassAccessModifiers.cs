using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRC_Code_Designer.src.Core.Project
{
    /// <summary>
    /// Class access modifier. Can be default, internal and public.
    /// Nested classes are not covered, so private; protected and
    /// protected internal are not present.
    /// </summary>
    public enum ClassAccessModifiers
    {
        @default,
        @public,
        @internal
    }

}
