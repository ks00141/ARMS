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
        public event EventHandler<string[]> SpecParamUpload;
        public event EventHandler<string[]> SecsGemParamUpload;

        public SecsGemPresenter(IRecipeParamUPloadView view)
        {
            this.service = new SecsGemService();
            this.service.RecipeParamUploadEvent += RecipeParamUpload;
            this.service.RecipeParamCheckEvent += RunRecipeParamPrint;
            this.view = view;
        }

        public void RunRecipeParamPrint(object sender, RunRecipeParam e)
        {
            view.RunRecipeParams = new string[]
            {
                e.Date,
                e.Port,
                e.LotId,
                e.ClusterRecipe,
                e.FrontsideRecipe,
                e.InspectionDies,
                e.InspectionColumns,
                e.InspectionRows,
                e.Result
            };
        }

        public void RecipeParamUpload(object sender, RecipeParam[] paramArray)
        {
            SecsGemParamUpload?.Invoke(this, new string[]
            {
                paramArray[0].ClusterRecipe,
                paramArray[0].FrontsideRecipe,
                paramArray[0].InspectionDies,
                paramArray[0].InspectionColumns,
                paramArray[0].InspectionRows
            });
            SpecParamUpload?.Invoke(this, new string[]
            {
                paramArray[1].ClusterRecipe,
                paramArray[1].FrontsideRecipe,
                paramArray[1].InspectionDies,
                paramArray[1].InspectionColumns,
                paramArray[1].InspectionRows
            });
        }

        public void SecsGemStart()
        {
            service.SecsGemStart();
        }

        public void ParamUploadRequest(string ppid)
        {
            this.service.ParamUploadRequest(ppid.Replace('/', '\\'));
        }

        public void ParamUpload(string ppid)
        {
            this.service.ParamUploadRequest(ppid.Replace('/', '\\'));
        }
    }
}
