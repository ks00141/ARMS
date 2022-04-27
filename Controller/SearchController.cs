using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMS.Controller
{
    class SearchController
    {
        public SearchController()
        {
        }

        public Model.RecipeParam getRecipe(String device)
        {
            Model.RecipeParam dbParams = new Dao.SpecDbDao().getRecipeParam(device);
            return dbParams;

        }
    }
}
