using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMS.Model;
using log4net;
using System.Reflection;

namespace ARMS
{
    class EntityCompare
    {
        RecipeParam spec;
        RecipeParam job;
        byte FLAG;
        private static readonly ILog log = LogManager.GetLogger("ARMS/Entity Compare");

        public EntityCompare(RecipeParam job, RecipeParam spec)
        {
            log.Info("Compare Instance create");
            this.spec = spec;
            this.job = job;
            log.Info("Compare FLAG INIT - 0");
            FLAG = 0b_0000_0000;
        }
        public EntityCompare(RecipeParam[] recipeParams)
        {
            log.Info("Compare Instance create");
            this.spec = recipeParams[1];
            this.job = recipeParams[0];
            log.Info("Compare FLAG INIT - 0");
            FLAG = 0b_0000_0000;
        }

        public byte compare()
        {
            log.Info("Compare Start");
            if (spec.ClusterRecipe != job.ClusterRecipe)
            {
                FLAG |= 0b_0000_0001;
                log.Warn("Cluster Reicpe Not Matched");
                log.Info($"Tool Cluster Reicpe : {job.ClusterRecipe}");
                log.Info($"Spec Cluster Reicpe : {spec.ClusterRecipe}");
            }
            else
            {
                log.Info($"Cluster Reicpe Matching SUCC - {job.ClusterRecipe}");
            }
            if (spec.FrontsideRecipe != job.FrontsideRecipe)
            {
                FLAG |= 0b_0000_0010;
                log.Warn("Frontside Reicpe Not Matched");
                log.Info($"Tool Frontside Reicpe : {job.FrontsideRecipe}");
                log.Info($"Spec Frontside Reicpe : {spec.FrontsideRecipe}");
            }
            else
            {
                log.Info($"Frontside Reicpe Matching SUCC - {job.FrontsideRecipe}");
            }
            if (spec.InspectionDies != job.InspectionDies)
            {
                FLAG |= 0b_0000_0100;
                log.Warn("Inspection Dies Not Matched");
                log.Info($"Tool Inspection Dies : {job.InspectionDies}");
                log.Info($"Spec Inspection Dies : {spec.InspectionDies}");
            }
            else
            {
                log.Info($"Inspection Dies Matching SUCC - {job.InspectionDies}");
            }
            if (spec.InspectionColumns != job.InspectionColumns)
            {
                FLAG |= 0b_0000_1000;
                log.Warn("Inspection Column Count Not Matched");
                log.Info($"Tool Inspection Column : {job.InspectionColumns}");
                log.Info($"Spec Inspection Column : {spec.InspectionColumns}");
            }
            else
            {
                log.Info($"Inspection Column Count Matching SUCC - {job.InspectionColumns}");
            }
            if (spec.InspectionRows != job.InspectionRows)
            {
                FLAG |= 0b_0001_0000;
                log.Warn("Inspection Row Count Not Matched");
                log.Info($"Tool Inspection Row : {job.InspectionRows}");
                log.Info($"Spec Inspection Row : {spec.InspectionRows}");
            }
            else
            {
                log.Info($"Inspection Row Count Matching SUCC - {job.InspectionRows}");
            }
            log.Info($"Compare Result - {FLAG}");
            log.Info($"Compare End");
            return FLAG;
        }
    }
}
