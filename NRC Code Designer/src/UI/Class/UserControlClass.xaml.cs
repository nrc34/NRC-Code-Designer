using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace NRC_Code_Designer.src.UI.Class
{
    /// <summary>
    /// Class user control to add to parent grid.
    /// </summary>
    public partial class UserControlClass : UserControl
    {
        private src.Core.Project.Class class2Use;

        private bool isMouseLeftButtonDown;

        public UserControlClass(src.Core.Project.Class class2Use)
        {
            InitializeComponent();

            this.class2Use = class2Use;

            Loaded += UserControlClass_Loaded;

            labelClassName.MouseEnter += (s, e) =>
                                        Mouse.OverrideCursor = Cursors.SizeAll;

            labelClassName.MouseLeave += (s, e) => 
                                        Mouse.OverrideCursor = Cursors.Arrow;

            labelClassName.MouseLeftButtonDown += (s, e) => 
                                        isMouseLeftButtonDown = true;

            labelClassName.MouseLeftButtonUp += (s, e) => 
                                        isMouseLeftButtonDown = false;

            labelClassName.MouseMove += (s, e) =>
            {
                if (!isMouseLeftButtonDown) return;

                var position2Parent = (Vector)Mouse.GetPosition((Grid)this.Parent);
                
                    class2Use.Position = (Point)(position2Parent - new Vector(gridClass.ActualWidth/2, 15));
                    gridClass.Margin = new Thickness(class2Use.Position.X,
                                                     class2Use.Position.Y,
                                                     0, 0);
            };

        }

        void UserControlClass_Loaded(object sender, RoutedEventArgs e)
        {
            LoadUI();
        }

        public void LoadUI()
        {
            gridClass.Margin = new Thickness(class2Use.Position.X, 
                                             class2Use.Position.Y, 
                                             0, 0);
            
            labelClassName.Content = class2Use.Name;

            itemsControlProperties.ItemsSource = class2Use.Properties;

            itemsControlMethods.ItemsSource = class2Use.Properties;
        }

        public void UpdateUI()
        {
            LoadUI();
        }
    }
}
