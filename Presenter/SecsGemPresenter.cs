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
    class SecsGemPresenter:IRecipeParamUPloadView
    {
        readonly SecsGemService service;

        public SecsGemPresenter(IRecipeParamUPloadView View)
        {
            this.service = new SecsGemService();
            this.service.RecipeParamUploadEvent += RecipeParamUpload;

        }

        private void RecipeParamUpload(object sender, RecipeParam e)
        {
            ;
        }

        public void SecsGemStart()
        {
            service.SecsGemStart();
        }
    }
}
