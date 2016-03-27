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
        #region Label DP

        /// <summary>
        /// Gets or sets the Label Content.
        /// </summary>
        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        /// <summary>
        /// Label dependency property
        /// </summary>
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string),
              typeof(UserControlPanel), new PropertyMetadata(string.Empty));

        #endregion

        #region PanelContent DP

        /// <summary>
        /// Gets or sets the Panel Content.
        /// </summary>
        public UIElement PanelContent
        {
            get { return (UIElement)GetValue(PanelContentProperty); }
            set { SetValue(PanelContentProperty, value); }
        }

        /// <summary>
        /// PanelContent dependency property
        /// </summary>
        public static readonly DependencyProperty PanelContentProperty =
            DependencyProperty.Register("PanelContent", typeof(UIElement),
              typeof(UserControlPanel), new PropertyMetadata());

        #endregion

        public UserControlPanel()
        {
            InitializeComponent();

            DataContext = this;
        }
    }
}
