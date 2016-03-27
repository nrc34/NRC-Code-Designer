using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRC_Code_Designer.src.Core.Project
{
    public class Field : INotifyPropertyChanged
    {
        private string name;

        /// <summary>
        /// Interface name.
        /// </summary>
        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Name"));
            }
        }


        private FieldAccessModifier access;

        public FieldAccessModifier Access
        {
            get { return access; }
            set 
            {
                access = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Access"));
            }
        }


        private string type;

        public string Type
        {
            get { return type; }
            set 
            { 
                type = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Type"));
            }
        }
        


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }
}
