using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secs4Net;
using MySql.Data.MySqlClient;
using System.Data;

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
                            
                            
                            
                            if (receiver.checkRCMD())
                            {
                                // RCMD validation 통과하면 할일
                                // 1. S2F42 HACK 0 Return (Receiver)
                                // 2. PARAMETER 뽑기  (Receiver)
                                // 3. SPEC DB 접속해서 SPEC PARAMETER 가져오기 (DB connector가 필요함, Receiver가 DB ConnectorFactory에서 요청해서 받아오자)
                                // 4. 비교하기 (Receiver)
                                // 5. S6F11 Send (Receiver)

                                receiver.replyS2F42(true);  // 1. S2F42 HACK 0 Return (Receiver)

                                DataTable recipeParams = receiver.getParams(); // 2. SECS/GEM Message로부터 recipe parameter 뽑아서 table로 반환
                                MySqlConnection conn = new DBConnectorFactory().getConnection(); // 3-1. SPEC DB connection 받아오기

                                try
                                {
                                    conn.Open();

                                    form.setDBConnectionText("Connected! Recipe DB (10.29.10.54:3306)");

                                    string sq =
@"SELECT
	a.cluster_recipe
	, a.frontside_recipe
	, a.inspection_dies
	, a.inspection_columns
	, a.inspection_rows
FROM 
	recipe.spec a
WHERE 1 = 1
    AND a.cluster_recipe ='{0}';";
                                    
                                    string q = string.Format(sq, recipeParams.Rows[0][0].ToString());
                                    /*
                                    flag
                                    0 = All Matched
                                    1 = Cluster Recipe Not Matched
                                    2 = Frontside Recipe Not Matched
                                    3 = Frontside Recipe Not Matched, Cluster Recipe Not Matched
                                    4 = Inspection Dies Not Matched
                                    5 = Inspection Dies Not Matched, Cluster Recipe Not Matched
                                    6 = Inspection Dies Not Matched, Frontside Recipe Not Matched
                                    7 = Inspection Dies Not Matched, Frontside Recipe Not Matched, Cluster Recipe Not Matched
                                    8 = Inspection Column Not Matched
                                    9 = Inspection Column Not Matched, Cluster Recipe Not Matched
                                    10 = Inspection Column Not Matched, Frontside Recipe Not Matched
                                    11 = Inspection Column Not Matched, Frontside Recipe Not Matched, Cluster Recipe Not Matched
                                    12 = Inspection Column Not Matched, Inspection Dies Not Matched
                                    13 = Inspection Column Not Matched, Inspection Dies Not Matched, Cluster Recipe Not Matched
                                    14 = Inspection Column Not Matched, Inspection Dies Not Matched, Frontside Recipe Not Matched
                                    15 = Inspection Column Not Matched, Inspection Dies Not Matched, Frontside Recipe Not Matched, Cluster Recipe Not Matched
                                    16 = Inspection Row Not Matched
                                    17 = Inspection Row Not Matched, Cluster Recipe Not Matched
                                    18 = Inspection Row Not Matched, Frontside Recipe Not Matched
                                    19 = Inspection Row Not Matched, Frontside Recipe Not Matched, Cluster Recipe Not Matched
                                    20 = Inspection Row Not Matched, Inspection Dies Not Matched
                                    21 = Inspection Row Not Matched, Inspection Dies Not Matched, Cluster Recipe Not Matched
                                    22 = Inspection Row Not Matched, Inspection Dies Not Matched, Frontside Recipe Not Matched
                                    23 = Inspection Row Not Matched, Inspection Dies Not Matched, Frontside Recipe Not Matched, Cluster Recipe Not Matched
                                    24 = Inspection Row Not Matched, Inspection Column Not Matched
                                    25 = Inspection Row Not Matched, Inspection Column Not Matched, Cluster Recipe Not Matched
                                    26 = Inspection Row Not Matched, Inspection Column Not Matched, Frontside Recipe Not Matched
                                    27 = Inspection Row Not Matched, Inspection Column Not Matched, Frontside Recipe Not Matched, Cluster Recipe Not Matched
                                    28 = Inspection Row Not Matched, Inspection Column Not Matched, Inspection Dies Not Matched
                                    29 = Inspection Row Not Matched, Inspection Column Not Matched, Inspection Dies Not Matched, Cluster Recipe Not Matched
                                    30 = Inspection Row Not Matched, Inspection Column Not Matched, Inspection Dies Not Matched, Frontside Recipe Not Matched
                                    31 = Inspection Row Not Matched, Inspection Column Not Matched, Inspection Dies Not Matched, Frontside Recipe Not Matched, Cluster Recipe Not Matched

                                    */
                                    List<byte> ERR_CODE = new List<byte>();
                                    byte FLAG = 0b_0000_0000;

                                    ERR_CODE.Add(0b_0000_0001);
                                    ERR_CODE.Add(0b_0000_0010);
                                    ERR_CODE.Add(0b_0000_0100);
                                    ERR_CODE.Add(0b_0000_1000);
                                    ERR_CODE.Add(0b_0001_0000);

                                    

                                    MySqlDataAdapter adt = new MySqlDataAdapter(q, conn);
                                    DataTable specParams = new DataTable();
                                    adt.Fill(specParams);

                                    form.setClusterRecipeText(specParams.Rows[0][0].ToString());
                                    form.setFrontsideRecipeText(recipeParams.Rows[0][1].ToString());
                                    form.setInspectionDiesText(specParams.Rows[0][2].ToString());
                                    form.setColumnDiesText(specParams.Rows[0][3].ToString());
                                    form.setRowDiesText(specParams.Rows[0][4].ToString());

                                    for(int i=0; i<5; i++)
                                    {
                                        if(recipeParams.Rows[0][i].ToString() != specParams.Rows[0][i].ToString())
                                        {
                                            FLAG |= ERR_CODE[i];
                                        }
                                    }

                                    form.setPValidText(FLAG.ToString());

                                    form.setRecipeTable(recipeParams);

                                    form.setSpecTable(specParams);

                                    if (FLAG == 0)
                                    {
                                        pMsg.ReplyAsync(new S2F42().reply());
                                        driver.SendAsync(new S6F11().sendSuc(recipeParams.Rows[0][0].ToString()));
                                    }
                                    else
                                    {
                                        pMsg.ReplyAsync(new S2F42().reply());
                                        driver.SendAsync(new S6F11().sendFail(recipeParams.Rows[0][0].ToString()));
                                    }

                                }
                                catch (Exception)
                                {
                                    conn.Close();
                                    driver.SendAsync(new S6F11().sendFail(pMsg.Message.SecsItem.Items[0].GetValue<String>()));
                                }
                            }
                            else
                            {
                                pMsg.ReplyAsync(new S2F42().reply());
                                driver.SendAsync(new S6F11().sendFail(pMsg.Message.SecsItem.Items[0].GetValue<String>()));
                            }
                            
                            break;
                    }
                    break;
            }
            return reply;
        }

    }
}