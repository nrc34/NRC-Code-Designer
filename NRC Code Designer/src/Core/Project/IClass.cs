using System;
using System.Collections.Generic;

namespace NRC_Code_Designer.src.Core.Project
{
    interface IClass
    {
        /// <summary>
        /// Class type name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Base class from wich this class derive from.
        /// </summary>
        src.Core.Class DerivedFrom { get; set; }

        /// <summary>
        /// List of class properties.
        /// </summary>
        List<Property> Properties { get; set; }
    }
}
