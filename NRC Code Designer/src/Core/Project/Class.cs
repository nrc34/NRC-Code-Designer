using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Threading.Tasks;
using NRC_Code_Designer.src.Core;
using System.Diagnostics;
using NRC_Code_Designer.src.Core.Project;
using System.Collections.ObjectModel;

namespace NRC_Code_Designer.src.Core.Project
{
    public class Class : Core.Project.Entity, IClass, IDisplayAble
    {
        #region ... Fields ...
        private src.Core.Project.Class derivedFrom;
        private Point position; 
        #endregion

        #region ... Properties ...
        /// <summary>
        /// Class position.
        /// </summary>
        public Point Position
        {
            get { return position; }
            set
            {
                position = value;
                OnMoved(new EventArgs());
            }
        }

        /// <summary>
        /// Class name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Class user control to display class.
        /// </summary>
        public UI.Class.UserControlClass UserControl { get; set; }

        /// <summary>
        /// Class access modifier. Can be default, internal and public.
        /// </summary>
        public ClassAccessModifiers AccessModifier { get; set; }

        /// <summary>
        /// Base class from wich this class derive from.
        /// </summary>
        public src.Core.Project.Class DerivedFrom
        {
            get
            {
                return derivedFrom;
            }
            set
            {
                derivedFrom = value;

                InheritancePath = new Path();

                InheritancePath.IsHitTestVisible = false;

                createInheritancePath(InheritancePath);

                derivedFrom.UserControl.gridClass.SizeChanged += (s, e) =>
                {
                    createInheritancePath(InheritancePath);
                };

                this.UserControl.gridClass.SizeChanged += (s, e) =>
                {
                    createInheritancePath(InheritancePath);
                };

                derivedFrom.Moved += (s, e) =>
                {
                    createInheritancePath(InheritancePath);
                };

                this.Moved += (s, e) =>
                {
                    createInheritancePath(InheritancePath);
                };
            }
        }

        /// <summary>
        /// Inheritance path to link between this class to base class.
        /// </summary>
        public Path InheritancePath { get; set; }

        /// <summary>
        /// List of the Interfaces that the class implements.
        /// </summary>
        public ObservableCollection<Interface> Interfaces { get; set; }

        /// <summary>
        /// List of class properties.
        /// </summary>
        public List<Property> Properties { get; set; } 
        #endregion

        #region ... Methods ...

        #region .. Constructors ..
        /// <summary>
        /// Empty constructor.
        /// </summary>
        public Class()
            : this(string.Empty)
        {
        }

        /// <summary>
        /// Initialize a class with the name and position(0,0).
        /// </summary>
        /// <param name="name">Class name.</param>
        public Class(string name)
        {
            Name = name;

            AccessModifier = ClassAccessModifiers.@default;

            Interfaces = new ObservableCollection<Interface>();

            Properties = new List<Property>();

            Position = new Point(0, 0);
        }

        /// <summary>
        /// Initialize a class with the name and position.
        /// </summary>
        /// <param name="name">Class name.</param>
        /// <param name="position">Class position.</param>
        public Class(string name, Point position)
            : this(name)
        {
            Position = position;
        } 
        #endregion

        #region .. Public Methods ..
        
        #endregion

        #region .. Private Methods ..
        private void createInheritancePath(Path InheritancePath)
        {
            InheritancePath.Stroke = (Brush)App.Current.
                                        FindResource("InheritancePathBrush");
            InheritancePath.StrokeThickness = 2;

            int distFromBase = 40;
            int arrowHeight = 13;
            int arrowWidth = 10;

            var baseClassStartPoint = new Point(
                derivedFrom.Position.X + derivedFrom.UserControl.gridClass.ActualWidth / 2,
                derivedFrom.Position.Y + derivedFrom.UserControl.gridClass.ActualHeight);

            var arrow1Line = new LineGeometry();
            arrow1Line.StartPoint = baseClassStartPoint;
            arrow1Line.EndPoint = new Point(
                baseClassStartPoint.X - arrowWidth / 2,
                baseClassStartPoint.Y + arrowHeight);

            var arrow2Line = new LineGeometry();
            arrow2Line.StartPoint = baseClassStartPoint;
            arrow2Line.EndPoint = new Point(
                baseClassStartPoint.X + arrowWidth / 2,
                baseClassStartPoint.Y + arrowHeight);

            var arrow3Line = new LineGeometry();
            arrow3Line.StartPoint = new Point(
                baseClassStartPoint.X - arrowWidth / 2,
                baseClassStartPoint.Y + arrowHeight);
            arrow3Line.EndPoint = new Point(
                baseClassStartPoint.X + arrowWidth / 2,
                baseClassStartPoint.Y + arrowHeight);

            var line1FromBase = new LineGeometry();
            line1FromBase.StartPoint = new Point(
                baseClassStartPoint.X,
                baseClassStartPoint.Y + arrowHeight);
            line1FromBase.EndPoint = new Point(
                baseClassStartPoint.X,
                baseClassStartPoint.Y + distFromBase);

            var line2FromBase = new LineGeometry();
            line2FromBase.StartPoint = new Point(
                baseClassStartPoint.X,
                baseClassStartPoint.Y + distFromBase);
            line2FromBase.EndPoint = new Point(
                this.position.X + this.UserControl.gridClass.ActualWidth / 2,
                baseClassStartPoint.Y + distFromBase);

            var line3FromBase = new LineGeometry();
            line3FromBase.StartPoint = new Point(
                this.position.X + this.UserControl.gridClass.ActualWidth / 2,
                baseClassStartPoint.Y + distFromBase);
            line3FromBase.EndPoint = new Point(
                this.position.X + this.UserControl.gridClass.ActualWidth / 2,
                this.position.Y);

            var geometryGroup = new GeometryGroup();
            geometryGroup.Children.Add(arrow1Line);
            geometryGroup.Children.Add(arrow2Line);
            geometryGroup.Children.Add(arrow3Line);
            geometryGroup.Children.Add(line1FromBase);
            geometryGroup.Children.Add(line2FromBase);
            geometryGroup.Children.Add(line3FromBase);

            InheritancePath.Data = geometryGroup;
        }  
        #endregion

        #endregion

        #region ... Events ...
        public event EventHandler Moved;

        protected virtual void OnMoved(EventArgs e)
        {
            if (Moved != null)
                Moved(this, e);
        } 
        #endregion
    }
}
