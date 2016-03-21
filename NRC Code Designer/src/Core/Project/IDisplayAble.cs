using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using NRC_Code_Designer.src.UI.Class;

namespace NRC_Code_Designer.src.Core.Project
{
    /// <summary>
    /// Give capacity to display.
    /// </summary>
    interface IDisplayAble
    {
        /// <summary>
        /// Class absolute position in the parent grid.
        /// </summary>
        Point Position { get; set; }

        /// <summary>
        /// Event that is trigered when the position changes.
        /// </summary>
        event EventHandler Moved;

        /// <summary>
        /// User control to implement display.
        /// </summary>
        UserControlClass UserControl { get; set; }
    }
}
