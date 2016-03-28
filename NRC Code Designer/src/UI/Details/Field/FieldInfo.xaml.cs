using NRC_Code_Designer.src.Core.Project;
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

namespace NRC_Code_Designer.src.UI.Details.Field
{
    /// <summary>
    /// Interaction logic for FieldInfo.xaml
    /// </summary>
    public partial class FieldInfo : UserControl
    {
        public FieldInfo()
        {
            InitializeComponent();

            Loaded += FieldInfo_Loaded;
        }

        void FieldInfo_Loaded(object sender, RoutedEventArgs e)
        {
            comboBoxAccess.ItemsSource = Enum.GetNames(typeof(FieldAccessModifier));
        }
    }
}
