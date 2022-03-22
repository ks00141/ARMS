using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Reflection;

namespace ARMS.Model
{
    class Entity
    {
        private static readonly ILog log = LogManager.GetLogger("ARMS/Parameter Entity");

        private String clusterRecipe;
        private String frontsideRecipe;
        private String inspectionDies;
        private String inspectionColumns;
        private String inspectionRows;

        public Entity()
        {

        }
        public Entity(String clusterRecipe, String frontsideRecipe, String inspectionDies, String inspectionColumns, String inspectionRows)
        {
            log.Info("Entity Instance create");
            this.clusterRecipe = clusterRecipe;
            log.Info($"Set clusterRecipe - {this.clusterRecipe}");
            this.frontsideRecipe = frontsideRecipe;
            log.Info($"Set frontsideRecipe - {this.frontsideRecipe}");
            this.inspectionDies = inspectionDies;
            log.Info($"Set inspectionDies - {this.inspectionDies}");
            this.inspectionColumns = inspectionColumns;
            log.Info($"Set inspectionColumns - {this.inspectionColumns}");
            this.inspectionRows = inspectionRows;
            log.Info($"Set inspectionRows - {this.inspectionRows}");
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
