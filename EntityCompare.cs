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

        public byte compare()
        {
            log.Info("Compare Start");
            if (spec.getClusterRecipe() != job.getClusterRecipe())
            {
                FLAG |= 0b_0000_0001;
                log.Warn("Cluster Reicpe Not Matched");
                log.Info($"Tool Cluster Reicpe : {job.getClusterRecipe()}");
                log.Info($"Spec Cluster Reicpe : {spec.getClusterRecipe()}");
            }
            else
            {
                log.Info($"Cluster Reicpe Matching SUCC - {job.getClusterRecipe()}");
            }
            if (spec.getFrontsideRecipe() != job.getFrontsideRecipe())
            {
                FLAG |= 0b_0000_0010;
                log.Warn("Frontside Reicpe Not Matched");
                log.Info($"Tool Frontside Reicpe : {job.getFrontsideRecipe()}");
                log.Info($"Spec Frontside Reicpe : {spec.getFrontsideRecipe()}");
            }
            else
            {
                log.Info($"Frontside Reicpe Matching SUCC - {job.getFrontsideRecipe()}");
            }
            if (spec.getInspectionDies() != job.getInspectionDies())
            {
                FLAG |= 0b_0000_0100;
                log.Warn("Inspection Dies Not Matched");
                log.Info($"Tool Inspection Dies : {job.getInspectionDies()}");
                log.Info($"Spec Inspection Dies : {spec.getInspectionDies()}");
            }
            else
            {
                log.Info($"Inspection Dies Matching SUCC - {job.getInspectionDies()}");
            }
            if (spec.getInspectionColumns() != job.getInspectionColumns())
            {
                FLAG |= 0b_0000_1000;
                log.Warn("Inspection Column Count Not Matched");
                log.Info($"Tool Inspection Column : {job.getInspectionColumns()}");
                log.Info($"Spec Inspection Column : {spec.getInspectionColumns()}");
            }
            else
            {
                log.Info($"Inspection Column Count Matching SUCC - {job.getInspectionColumns()}");
            }
            if (spec.getInspectionRows() != job.getInspectionRows())
            {
                FLAG |= 0b_0001_0000;
                log.Warn("Inspection Row Count Not Matched");
                log.Info($"Tool Inspection Row : {job.getInspectionRows()}");
                log.Info($"Spec Inspection Row : {spec.getInspectionRows()}");
            }
            else
            {
                log.Info($"Inspection Row Count Matching SUCC - {job.getInspectionRows()}");
            }
            log.Info($"Compare Result - {FLAG.ToString()}");
            log.Info($"Compare End");
            return FLAG;
        }
    }
}
