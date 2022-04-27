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
        private String frontsideRecipe;
        private String inspectionDies;
        private String inspectionColumns;
        private String inspectionRows;

        public String getClusterRecipe()
        {
            return this.clusterRecipe;
        }

        public String getFrontsideRecipe()
        {
            return this.frontsideRecipe;
        }

        public String getInspectionDies()
        {
            return this.inspectionDies;
        }

        public String getInspectionColumns()
        {
            return this.inspectionColumns;
        }

        public String getInspectionRows()
        {
            return this.inspectionRows;
        }
        public void setClusterRecipe(String clusterRecipe)
        {
            this.clusterRecipe = clusterRecipe;
        }

        public void setFrontsideRecipe(String frontsideRecipe)
        {
            this.frontsideRecipe = frontsideRecipe;
        }

        public void setInspectionDies(String inspectionDies)
        {
            this.inspectionDies = inspectionDies;
        }
        public void setInsepctionColumns(String inspectionColumns)
        {
            this.inspectionColumns = inspectionColumns;
        }
        public void setInspectionRows(String inspectionRows)
        {
            this.inspectionRows = inspectionRows;
        }

    }
}
