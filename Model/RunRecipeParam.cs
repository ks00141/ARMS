using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMS.Model
{
    public class RunRecipeParam:RecipeParam
    {
        public RunRecipeParam(RecipeParam param)
        {
            this.ClusterRecipe = param.ClusterRecipe;
            this.FrontsideRecipe = param.FrontsideRecipe;
            this.InspectionDies = param.InspectionDies;
            this.InspectionColumns = param.InspectionColumns;
            this.InspectionRows = param.InspectionRows;
        }
        public string Date { get; set; }
        public string Port { get; set; }
        public string LotId { get;set; }
        public string Result { get; set; }
    }
}
