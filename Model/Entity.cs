using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMS.Model
{
    class Entity
    {

        private String clusterRecipe;
        private String frontsideRecipe;
        private String inspectionDies;
        private String inspectionColumns;
        private String inspectionRows;
        public Entity(String clusterRecipe, String frontsideRecipe, String inspectionDies, String inspectionColumns, String inspectionRows)
        {
            this.clusterRecipe = clusterRecipe;
            this.frontsideRecipe = frontsideRecipe;
            this.inspectionDies = inspectionDies;
            this.inspectionColumns = inspectionColumns;
            this.inspectionRows = inspectionRows;
        }

        public String GetClusterRecipe()
        {

            return this.clusterRecipe;
        }

        public String GetFrontsideRecipe()
        {

            return this.frontsideRecipe;
        }

        public String GetInspectionDies()
        {

            return this.inspectionDies;
        }

        public String GetInspecionColumns()
        {

            return this.inspectionColumns;
        }

        public String GetInspecionRows()
        {

            return this.inspectionRows;
        }
    }
}
