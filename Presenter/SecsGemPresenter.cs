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
        
        bool status = false;
        int port;
        SecsGemService service;
        IRecipeParamUPloadView view;

        public SecsGemPresenter(IRecipeParamUPloadView view)
        {
            
            this.view = view;
        }

        public void RunRecipeParamPrint(object sender, RunRecipeParam e)
        {
            try
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
            }catch(Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
        }

        public void RecipeParamUpload(object sender, RecipeParam[] paramArray)
        {
            view.ToolClusterRecipe = paramArray[0].ClusterRecipe;
            view.ToolFrontsideRecipe = paramArray[0].FrontsideRecipe;
            view.ToolInspectionDies = paramArray[0].InspectionDies;
            view.ToolInspectionColumns = paramArray[0].InspectionColumns;
            view.ToolInspectionRows = paramArray[0].InspectionRows;
            view.SpecClusterRecipe = paramArray[1].ClusterRecipe;
            view.SpecFrontsideRecipe = paramArray[1].FrontsideRecipe;
            view.SpecInspectionDies = paramArray[1].InspectionDies;
            view.SpecInspectionColumns = paramArray[1].InspectionColumns;
            view.SpecInspectionRows = paramArray[1].InspectionRows;
        }

        public void SecsGemStart()
        {
            if (!status)
            {
                port = Int32.Parse(PortManager.Port);
                this.service = new SecsGemService(port);
                this.service.RecipeParamUploadEvent += RecipeParamUpload;
                this.service.RecipeParamCheckEvent += RunRecipeParamPrint;
                service.SecsGemStart();
                status = true;
            }
            else
            {
                LogPresenter.SetLogString($"SecsGem Service is already starting on {port} port.");
                return;
            }
        }

        public void ParamUploadRequest(string ppid)
        {
            this.service.ParamUploadRequest(ppid.Replace('/', '\\'));
        }

        public void ParamUpload(string ppid)
        {
            this.service.ParamUploadRequest(ppid.Replace('/', '\\'));
        }

        public void DbParamUpload(string[] param)
        {
            RecipeParam paramObj = new RecipeParam()
            {
                ClusterRecipe = param[0],
                FrontsideRecipe = param[1],
                InspectionDies = param[2],
                InspectionColumns = param[3],
                InspectionRows = param[4]
            };

            this.service.DBParamUpload(paramObj);
        }

        internal void SecsGemStop()
        {
            service.SecsGemStop();
            status = false;
            LogPresenter.SetLogString($"SecsGem Service stop (port : {port}).");
        }
    }
}
