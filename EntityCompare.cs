using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMS.Model;

namespace ARMS
{
    class EntityCompare
    {
        Entity spec;
        Entity job;
        byte FLAG;

        public EntityCompare(Entity spec, Entity job)
        {
            this.spec = spec;
            this.job = job;
            FLAG = 0b_0000_0000;
        }

        public byte compare()
        {

            if (spec.GetClusterRecipe() != job.GetClusterRecipe()) FLAG |= 0b_0000_0001;
            if (spec.GetFrontsideRecipe() != job.GetFrontsideRecipe()) FLAG |= 0b_0000_0010;
            if (spec.GetInspectionDies() != job.GetInspectionDies()) FLAG |= 0b_0000_0100;
            if (spec.GetInspecionColumns() != job.GetInspecionColumns()) FLAG |= 0b_0000_1000;
            if (spec.GetInspecionRows() != job.GetInspecionRows()) FLAG |= 0b_0001_0000;

            return FLAG;
        }
    }
}
