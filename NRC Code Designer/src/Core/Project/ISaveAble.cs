using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRC_Code_Designer.src.Core.Project
{   
    /// <summary>
    /// Interface to implemente saving capacity.
    /// </summary>
    interface ISaveAble
    {
        /// <summary>
        /// Full file path.
        /// </summary>
        string FilePath { get; set; }

        /// <summary>
        /// Save method.
        /// </summary>
        void Save();
    }
}
