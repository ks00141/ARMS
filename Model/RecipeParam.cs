using System;

namespace ARMS.Model
{
    public class RecipeParam
    {
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
