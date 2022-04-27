using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;
using log4net;


namespace ARMS.Controller
{
    class SecsGemController
    {
        SecsGem driver;
        Dao.SecsGemDao secsGemDao;
        Model.RecipeParam secsGemParam;
        private static readonly ILog log = LogManager.GetLogger("ARMS/Recipe Para Getter");

        public SecsGemController(SecsGem driver)
        {
            this.driver = driver;
            this.secsGemDao = new Dao.SecsGemDao();
            this.secsGemParam = new Model.RecipeParam();
        }
        public Model.RecipeParam req(PrimaryMessageWrapper pMsg)
        {
            log.Info("Response Recipe Para");
            Model.RecipeParam secsGemParam = secsGemDao.req(pMsg);
            if (secsGemParam.getClusterRecipe() == null)
            {
                log.Error("Invalid Recipe Para");
            }            
            return secsGemParam;
        }
    }
}
