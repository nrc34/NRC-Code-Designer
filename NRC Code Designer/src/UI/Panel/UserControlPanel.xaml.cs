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

namespace NRC_Code_Designer.src.UI.Panel
{
    /// <summary>
    /// Interaction logic for UserControlPanel.xaml
    /// </summary>
    public partial class UserControlPanel : UserControl
    {
        public string Label { get; set; }

        #region PanelGrid DP

        /// <summary>
        /// Gets or sets the Panel Grid which is bind to a resource dictionary.
        /// </summary>
        public Grid PanelGrid
        {
            get { return (Grid)GetValue(PanelGridProperty); }
            set { SetValue(PanelGridProperty, value); }
        }

        /// <summary>
        /// PanelGrid dependency property
        /// </summary>
        public static readonly DependencyProperty PanelGridProperty =
            DependencyProperty.Register("PanelGrid", typeof(Grid),
              typeof(UserControlPanel), new PropertyMetadata());

        #endregion

        public UserControlPanel()
        {
            InitializeComponent();

            DataContext = this;
        }
    }
}
