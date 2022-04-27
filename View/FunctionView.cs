using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMS.Controller;
using Secs4Net;
using System.Net;
using log4net;
using System.Reflection;

namespace ARMS.View
{
    class FunctionView
    {
        SecsGem driver;
        Form1 form;
        private static readonly ILog log = LogManager.GetLogger("ARMS/Finction View");

        public FunctionView(Form1 form)
        {
            this.form = form;
            try
            {
                driver = new SecsGem(false, IPAddress.Any, 5000);
                log.Info("SECS/GEM Driver is initialized");
            }
            catch(Exception e)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
            }
            driver.PrimaryMessageReceived += msgReceived;
            
        }

        public void start()
        {
            try
            {
                driver.Start();
                log.Info("SECS/GEM Driver Start");
            }catch(Exception e)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", e);
            }
            
        }

        public void msgReceived(object sender, PrimaryMessageWrapper pMsg)
        {
            int F = pMsg.Message.F;
            int S = pMsg.Message.S;
            log.Info($"SECS/GEM Message received, S{S} F{F}");
            switch (S)
            {

                case 1:

                    switch (F)
                    {
                        case 3:
                            new Controller.S1F3Controller().req(pMsg);
                            break;

                        case 13:
                            new Controller.S1F13Controller().req(pMsg);
                            break;
                    }
                    break;

                case 2:

                    switch (F)
                    {
                        case 41:
                            String RCMD = pMsg.Message.SecsItem.Items[0].GetValue<String>();
                            log.Info($"RMCD : {RCMD}");
                            
                            if (RCMD == "RECIPE_PARA_CHECK")
                            {
                                new S2F41Controller(driver).req(pMsg, form.checkboxStat());
                                
                            }
                            else if (RCMD == "RECIPE_PARA_UPLOAD")
                            {
                                Model.RecipeParam recipeParam = new Controller.SecsGemController(driver).req(pMsg);
                                form.setToolClusterRecipe(recipeParam.getClusterRecipe());
                                log.Info($"Set Form Cluster Recipe : {recipeParam.getClusterRecipe()}");
                                form.setToolFrontsideRecipe(recipeParam.getFrontsideRecipe());
                                log.Info($"Set Form Frontside Recipe : {recipeParam.getFrontsideRecipe()}");
                                form.setToolInspectionDies(recipeParam.getInspectionDies());
                                log.Info($"Set Form Inspection Dies : {recipeParam.getInspectionDies()}");
                                form.setToolInspectionColumns(recipeParam.getInspectionColumns());
                                log.Info($"Set Form Inspection Columns : {recipeParam.getInspectionColumns()}");
                                form.setToolInspectionRows(recipeParam.getInspectionRows());
                                log.Info($"Set Form Inspection Rows : {recipeParam.getInspectionRows()}");
                            }
                            break;
                    }
                    break;
            }
        }

        public void reqRecipe(String ppid)
        {
            
            driver.SendAsync(new SecsMessage(
                            6,
                            11,
                            "S6F11",
                            Item.L(
                                Item.U4(0),
                                Item.U4(3000),
                                Item.L(
                                    Item.L(
                                        Item.U4(1),
                                        Item.L(
                                            Item.L(
                                                Item.A("RECIPEID"),
                                                Item.A(ppid.Replace('/', '\\'))
                                            )
                                        )
                                    )
                                )
                            )
                        )
                    );
            Console.WriteLine("send S6F11");
        }

        public void specSearch(String ppid)
        {
            Model.RecipeParam recipeParam = new SearchController().getRecipe(ppid);
            Console.WriteLine(recipeParam.getClusterRecipe());
            form.setSpecClusterRecipe(recipeParam.getClusterRecipe());
            form.setSpecFrontsideRecipe(recipeParam.getFrontsideRecipe());
            form.setSpecInspectionDies(recipeParam.getInspectionDies());
            form.setSpecInspectionColumns(recipeParam.getInspectionColumns());
            form.setSpecInspectionRows(recipeParam.getInspectionRows());
        }

    }
    
}