using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NRC_Code_Designer.src.UI.ToolBox
{
    /// <summary>
    /// Interaction logic for UserControlToolBoxItem.xaml
    /// </summary>
    public partial class UserControlToolBoxItem : UserControl
    {
        #region Label DP

        /// <summary>
        /// Gets or sets the Label which is displayed in the toolBoxItem.
        /// </summary>
        public String Label
        {
            get { return (String)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        /// <summary>
        /// Label dependency property
        /// </summary>
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string),
              typeof(UserControlToolBoxItem), new PropertyMetadata(""));

        #endregion


        public UserControlToolBoxItem()
        {
            InitializeComponent();

            DataContext = this;
        }
    }
}
