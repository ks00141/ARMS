using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMS.Model;
using Secs4Net;

namespace ARMS.Repository
{
    public class ParaCheckRepository
    {
        public event EventHandler<string> SecsGemParamParsingHandler;
        PrimaryMessageWrapper pMsg;
        SpecParamRepository specParamRepository;

        public ParaCheckRepository(PrimaryMessageWrapper pMsg)
        {
            this.pMsg = pMsg;
            this.specParamRepository = new SpecParamRepository();

        }
        public SecsMessage S2F42()
        {
            S2F42 s2f42 = new S2F42
            {
                HCACK = 0
            };

            return s2f42.Message;
        }

        public SecsMessage S6F11Succ()
        {
            S6F11 s6f11 = new S6F11
            {
                DATAID = 0,
                CEID = 1000,
                RPTID = 1,
                PORTID = pMsg.Message.SecsItem.Items[1].Items[0].Items[0].GetValue<string>(),
                LOTID = pMsg.Message.SecsItem.Items[1].Items[0].Items[1].GetValue<string>(),
                CLUSTERRECIPE = pMsg.Message.SecsItem.Items[1].Items[0].Items[2].GetValue<string>()
            };

            return s6f11.Message;
        }

        public SecsMessage S6F11Fail()
        {
            S6F11 s6f11 = new S6F11
            {
                DATAID = 0,
                CEID = 2000,
                RPTID = 1,
                PORTID = pMsg.Message.SecsItem.Items[1].Items[0].Items[0].GetValue<string>(),
                LOTID = pMsg.Message.SecsItem.Items[1].Items[0].Items[1].GetValue<string>(),
                CLUSTERRECIPE = pMsg.Message.SecsItem.Items[1].Items[0].Items[2].GetValue<string>()
            };
            Console.WriteLine(s6f11.Message);
            return s6f11.Message;
        }

        public RecipeParam GetSecsGemParam()
        {
            RecipeParam param = new RecipeParam();
            Item items = pMsg.Message.SecsItem.Items[1].Items[0].Items[5];
            param.ClusterRecipe = pMsg.Message.SecsItem.Items[1].Items[0].Items[2].GetValue<String>();
            foreach (var item in items.Items)
            {
                if (item.Items[0] == "Frontside\\RecipeName")
                {
                    param.FrontsideRecipe = item.Items[1].Items[0].GetValue<string>();
                }
                if (item.Items[0] == "Frontside\\TestableDies")
                {
                    param.InspectionDies = item.Items[1].Items[0].GetValue<string>();
                }
                if (item.Items[0] == "Frontside\\ColumnNumber")
                {
                    param.InspectionColumns = item.Items[1].Items[0].GetValue<string>();
                }
                if (item.Items[0] == "Frontside\\RowNumber")
                {
                    param.InspectionRows = item.Items[1].Items[0].GetValue<string>();
                }
            }
            return param;
        }

        public RecipeParam GetSpecParam()
        {
            RecipeParam param = specParamRepository.GetRecipeParam(pMsg.Message.SecsItem.Items[1].Items[0].Items[2].GetValue<String>());
            return param;
        }

        public RecipeParam[] GetParams()
        {
            return new RecipeParam[] { this.GetSecsGemParam(), this.GetSpecParam() };
        }
    }
}
