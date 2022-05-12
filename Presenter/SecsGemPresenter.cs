using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMS.Model;
using ARMS.Service;
using ARMS.View;

namespace ARMS.Presenter
{
    class SecsGemPresenter {

        readonly SecsGemService service;
        IRecipeParamUPloadView view;

        public SecsGemPresenter(IRecipeParamUPloadView view)
        {
            this.service = new SecsGemService();
            this.service.RecipeParamUploadEvent += RecipeParamUpload;
            this.view = view;
        }

        private void RecipeParamUpload(object sender, RecipeParam e)
        {
            view.ClusterRecipe = e.ClusterRecipe;
            view.FrontsideRecipe = e.FrontsideRecipe;
            view.InspectionDies = e.InspectionDies;
            view.InspectionColumns = e.InspectionColumns;
            view.InspectionRows = e.InspectionRows;
        }

        public void SecsGemStart()
        {
            service.SecsGemStart();
        }

        public void ParamUploadRequest(string ppid)
        {
            this.service.ParamUploadRequest(ppid.Replace('/', '\\'));
        }
    }
}
