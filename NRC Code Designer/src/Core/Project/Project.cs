using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using NRC_Code_Designer.src.Core;
using NRC_Code_Designer.src.Global;


namespace NRC_Code_Designer.src.Core.Project
{
    /// <summary>
    /// Project class where a complete model of a project is stored.
    /// </summary>
    class Project : ISaveAble
    {

        #region  ... Public Properties ...
        /// <summary>
        /// Gets or sets project name. 
        /// The same as the file name without extension.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets project full file path.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// List of all project entities(classes, interfaces...).
        /// </summary>
        public List<Entity> Entities { get; set; }
        #endregion


        #region ... Constructors ...
        /// <summary>
        /// Default empty constructor to enable project model serialization.
        /// </summary>
        public Project()
        {
        }

        /// <summary>
        /// Project data model.
        /// </summary>
        /// <param name="name">Project name.</param>
        /// <param name="filePath">Project file path.</param>
        public Project(string name, string filePath)
        {
            Name = name;

            FilePath = filePath;
        } 
        #endregion


        #region ... Public Methods ...
        /// <summary>
        /// Saves the project at the file path.
        /// </summary>
        public void Save()
        {
            try
            {
                File.WriteAllText(FilePath, 
                                  XMLHelper.SerializeObject2Xml(this));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "ProjectSave");
            }
        } 
        #endregion
    }
}
