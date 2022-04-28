using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;
using System.Data;
using System.Net;
using log4net;

namespace ARMS.Dao
{
    class SecsGemDao
    {
        bool flag;
        Model.RecipeParam param;
        PrimaryMessageWrapper pMsg;
        private static readonly ILog log = LogManager.GetLogger("ARMS/Recipe Para Getter");
        public SecsGemDao()
        {
            this.param = new Model.RecipeParam();
        }


        public Model.RecipeParam req(PrimaryMessageWrapper pMsg)
        {
            try
            {
                replyS2F42(pMsg);
                this.pMsg = pMsg;
                log.Info("S2F42 Reply Success");
            }
            catch(Exception e)
            {
                log.Error("S2F42 Reply Fail");
                log.Info(e.Message);
                pMsg.ReplyAsync(
                   new SecsMessage(
                       2,
                       42,
                       "S2F42",
                       Item.L(
                           Item.U4(3)
                       )
                   )
               );
            }
            log.Info("Attempting to Recipe Para Parsing");
            try
            {
                log.Info("Recipe Para Parsing Start");
                Item items = pMsg.Message.SecsItem.Items[1].Items[0].Items[3];
                String clusterRecipe = pMsg.Message.SecsItem.Items[1].Items[0].Items[0].GetValue<String>().Replace('\\', '/');
                log.Info($"Cluster Recipe : {clusterRecipe}");
                String frontsideReicpe = null;
                String inspectionDies = null;
                String inspectionColumns = null;
                String inspectionRows = null;

                foreach (Item item in items.Items)
                {
                    if (item.Items[0] == "Frontside\\RecipeName")
                    {
                        frontsideReicpe = item.Items[1].Items[0].GetValue<String>().Replace('\\', '/');
                        log.Info($"Frontside Recipe : {frontsideReicpe}");
                    }
                    if (item.Items[0] == "Frontside\\TestableDies")
                    {
                        inspectionDies = item.Items[1].Items[0].GetValue<String>();
                        log.Info($"Inspection Dies : {inspectionDies}");
                    }
                    if (item.Items[0] == "Frontside\\ColumnNumber")
                    {
                        inspectionColumns = item.Items[1].Items[0].GetValue<String>();
                        log.Info($"Inspection Columns : {inspectionColumns}");
                    }
                    if (item.Items[0] == "Frontside\\RowNumber")
                    {
                        inspectionRows = item.Items[1].Items[0].GetValue<String>();
                        log.Info($"Inspection Rows : {inspectionRows}");
                    }
                }

                param.setClusterRecipe(clusterRecipe);
                param.setFrontsideRecipe(frontsideReicpe);
                param.setInspectionDies(inspectionDies);
                param.setInsepctionColumns(inspectionColumns);
                param.setInspectionRows(inspectionRows);
                log.Info("Recipe Para Parsing Succ");
                return param;
            }
            catch
            {
                log.Info("Recipe Para Parsing Fail");
                return param;
            }
        }
        public void replyS2F42(PrimaryMessageWrapper pMsg)
        {
            log.Info("S2F42 Reply Attempting");
            this.flag = true;
            pMsg.ReplyAsync(
                new SecsMessage(
                    2,
                    42,
                    "S2F42",
                    Item.L(
                        Item.U4(0)
                    )
                )
            );
        }
    }
}
