using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;
using MySql.Data.MySqlClient;

namespace ARMS
{
    class SecsMsgController:MsgCtrInterface
    {
        SecsGem driver;
        ReceiverFactory receiverFactory;
        dynamic form;
        int S;
        int F;
        
        public SecsMsgController(SecsGem driver, dynamic form)
        {
            this.driver = driver;
            this.form = form;
            receiverFactory = new ReceiverFactory();
        }

        public SecsMessage msgReceive(PrimaryMessageWrapper pMsg)
        {
            SecsMessage reply = null;

            S = pMsg.Message.S;
            F = pMsg.Message.F;

            switch (S)
            {
                case 1:

                    switch (F)
                    {
                        case 3:
                            pMsg.ReplyAsync(new S1F4().reply());
                            break;

                        case 13:
                            pMsg.ReplyAsync(new S1F14().reply());
                            break;
                    }

                    break;

                case 2:

                    switch (F)
                    {
                        case 41:
                            S2F41ReceiverInterface receiver = receiverFactory.getS2F41Receiver(pMsg);
                            List<String> recipeParams;
                            List<String> specParams;
                            if (receiver.checkRCMD())
                            {
                                // RCMD validation 통과하면 할일
                                // 1. S2F42 HACK 0 Return (Receiver)
                                // 2. PARAMETER 뽑기  (Receiver)
                                // 3. SPEC DB 접속해서 SPEC PARAMETER 가져오기 (DB connector가 필요함, 싱글톤으로, Receiver가 DB Connector에서 요청해서 받아오자)
                                // 4. 비교하기 (Receiver)
                                // 5. S6F11 Send (Receiver)
                                receiver.replyS2F42(true);  // 1. S2F42 HACK 0 Return (Receiver)
                                recipeParams = receiver.getParams();  //PARAMETER 뽑기  (Receiver)

                                StringBuilder _strArg = new StringBuilder();
                                _strArg.Append("Server=");
                                _strArg.Append("127.0.0.1");
                                _strArg.Append(";Port=");
                                _strArg.Append("3306");
                                _strArg.Append(";Database = ");
                                _strArg.Append("recipe");          // 데이터베이스
                                _strArg.Append(";Uid = ");
                                _strArg.Append("root");                     // ID
                                _strArg.Append(";Pwd = ");
                                _strArg.Append("wisol123");                 // PWD
                                _strArg.Append(";");
                                MySqlConnection conn = new MySqlConnection(_strArg.ToString());
                                try
                                {
                                    conn.Open();
                                    form.setDBConnectionText("Connected!");
                                }
                                catch (Exception)
                                {
                                    conn.Close();
                                    form.setDBConnectionText("Not Connected!");
                                }

                                String clusterRecipe = pMsg.Message.SecsItem.Items[1].Items[0].Items[0].GetValue<String>();
                                Item items = pMsg.Message.SecsItem.Items[1].Items[0].Items[3];
                                foreach (Item item in items.Items)
                                {
                                    if (item.Items[0].GetValue<String>() == "Frontside/RecipeName")
                                    {
                                        form.setFrontsideRecipeText(item.Items[1].Items[0].GetValue<String>());
                                    }
                                    if (item.Items[0].GetValue<String>() == "Frontside/RowNumber")
                                    {
                                        form.setRowDiesText(item.Items[1].Items[0].GetValue<String>());
                                    }
                                    if (item.Items[0].GetValue<String>() == "Frontside/ColumnNumber")
                                    {
                                        form.setColumnDiesText(item.Items[1].Items[0].GetValue<String>());
                                    }
                                    if (item.Items[0].GetValue<String>() == "Frontside/TestableDies")
                                    {
                                        form.setInspectionDiesText(item.Items[1].Items[0].GetValue<String>());
                                    }
                                }
                                pMsg.ReplyAsync(new S2F42().reply());
                                driver.SendAsync(new S6F11().sendSuc());
                                form.setClusterRecipeText(clusterRecipe);
                            }
                            
                            break;
                    }
                    break;
            }
            return reply;
        }

    }
}