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
using NRC_Code_Designer.src.UI.ToolBox;
using NRC_Code_Designer.src.UI.Details;

namespace NRC_Code_Designer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;

            labelClose.MouseLeftButtonDown += (s, e) => { this.Close(); };
            labelMinimize.MouseLeftButtonDown += (s, e) =>
            {
                this.WindowState = System.Windows.WindowState.Minimized;
            };
            labelNormal.MouseLeftButtonDown += (s, e) =>
            {
                this.WindowState = System.Windows.WindowState.Normal;
            };

        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            toolBoxPanel.PanelContent = new UserControlToolBox();
            detailsPanel.Label = "Class Details";
            detailsPanel.PanelContent = new UserControlClassDetails();

            int jx = 0;
            var myBClass = new src.Core.Class("MyBClass" + jx, new Point(100 + 10 * jx, 200 + 10 * jx));
            myBClass.UserControl = new src.UI.Class.UserControlClass(myBClass);
            for (int i = 0; i < 5; i++)
            {
                myBClass.Properties.Add(new src.Core.Project.Property()
                {
                    Name = "MyProperty+++++++++++++++++++++"
                });
            }

            gridDesigner.Children.Add(myBClass.UserControl);
            for (int j = 0; j < 3; j++)
            {
                
                var myClass = new src.Core.Class("MyClass" + j, new Point(100 + 50 * j, 200 + 50 * j));
                myClass.UserControl = new src.UI.Class.UserControlClass(myClass);


                for (int i = 0; i < 5; i++)
                {
                    myClass.Properties.Add(new src.Core.Project.Property()
                    {
                        Name = "MyProperty+++++++++++++++++++++"
                    });
                }


                myBClass.UserControl.gridClass.Loaded += (s, ex) =>
                {
                    myClass.DerivedFrom = myBClass;

                    gridDesigner.Children.Add(myClass.InheritancePath);
                };

                gridDesigner.Children.Add(myClass.UserControl);
                
            }
        }
    }
}
