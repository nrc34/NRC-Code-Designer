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
using NRC_Code_Designer.src.Core.Project;

namespace NRC_Code_Designer.src.UI.Details
{
    /// <summary>
    /// Interaction logic for UserControlClassDetails.xaml
    /// </summary>
    public partial class UserControlClassDetails : UserControl
    {
        private src.Core.Project.Class @class;

        public UserControlClassDetails()
        {
            InitializeComponent();

            @class = new Core.Project.Class("MyClass");

            listBoxInterfaces.ItemsSource = @class.Interfaces;
            listBoxFields.ItemsSource = @class.Fields;


            labelAddInterface.MouseLeftButtonDown += (s, e) => 
            {
                var ran = new Random();
                @class.Interfaces.Add(
                    new Interface("IanotherInterface" + ran.Next(99).ToString()));
                expanderInterfaces.IsExpanded = true;
            };

            labelRemoveInterface.MouseLeftButtonDown += (s, e) =>
            {
                if (listBoxInterfaces.SelectedItem == null) return;

                @class.Interfaces.
                    Remove(listBoxInterfaces.SelectedItem as Interface);
            };

            labelAddField.MouseLeftButtonDown += (s, e) =>
            {
                @class.Fields.Add(new src.Core.Project.Field());
                expanderFields.IsExpanded = true;
            };

            labelRemoveField.MouseLeftButtonDown += (s, e) =>
            {
                if (listBoxFields.SelectedItem == null) return;

                @class.Fields.
                   Remove(listBoxFields.SelectedItem as src.Core.Project.Field);
            };
        }
    }
}
