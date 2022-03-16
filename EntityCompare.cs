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
        Entity spec;
        Entity job;
        byte FLAG;
        private static readonly ILog log = LogManager.GetLogger("ARMS/Entity Compare");

        public EntityCompare(Entity spec, Entity job)
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
            if (spec.GetClusterRecipe() != job.GetClusterRecipe())
            {
                FLAG |= 0b_0000_0001;
                log.Warn("Cluster Reicpe Not Matched");
            }
            else
            {
                log.Info($"Cluster Reicpe Matching SUCC - {job.GetClusterRecipe()}");
            }
            if (spec.GetFrontsideRecipe() != job.GetFrontsideRecipe())
            {
                FLAG |= 0b_0000_0010;
                log.Warn("Frontside Reicpe Not Matched");
            }
            else
            {
                log.Info($"Frontside Reicpe Matching SUCC - {job.GetFrontsideRecipe()}");
            }
            if (spec.GetInspectionDies() != job.GetInspectionDies())
            {
                FLAG |= 0b_0000_0100;
                log.Warn("Inspection Dies Not Matched");
            }
            else
            {
                log.Info($"Inspection Dies Matching SUCC - {job.GetInspectionDies()}");
            }
            if (spec.GetInspecionColumns() != job.GetInspecionColumns())
            {
                FLAG |= 0b_0000_1000;
                log.Warn("Inspection Column Count Not Matched");
            }
            else
            {
                log.Info($"Inspection Column Count Matching SUCC - {job.GetInspecionColumns()}");
            }
            if (spec.GetInspecionRows() != job.GetInspecionRows())
            {
                FLAG |= 0b_0001_0000;
                log.Warn("Inspection Row Count Not Matched");
            }
            else
            {
                log.Info($"Inspection Row Count Matching SUCC - {job.GetInspecionRows()}");
            }
            log.Info($"Compare Result - {FLAG.ToString()}");
            log.Info($"Compare End");
            return FLAG;
        }
    }
}
