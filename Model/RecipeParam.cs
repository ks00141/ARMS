using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Reflection;

namespace ARMS.Model
{
    class RecipeParam
    {
        private static readonly ILog log = LogManager.GetLogger("ARMS/Parameter Entity");

        private String clusterRecipe;
        public string ClusterRecipe
        {
            get
            {
                return this.clusterRecipe;
            }
            set
            {
                this.clusterRecipe = value.Replace('\\', '/');
            }
        }
        private String frontsideRecipe;
        public string FrontsideRecipe
        {
            get
            {
                return this.frontsideRecipe;
            }
            set
            {
                this.frontsideRecipe = value.Replace('\\', '/');
            }
        }
        public string InspectionDies { get; set; }
        public string InspectionColumns { get; set; }
        public string InspectionRows { get; set; }
    }
}
