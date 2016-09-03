using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
namespace FaceBookCommunicator
{
    class Dao : Dal
    {
        // Save FB message Details to the DB
       public void SaveMsg(String sender , String Msg_id , String body)
       {

           try
            {
                string sql="";
               String str ="";
               DataSet dt;
                string NewBody = body.Replace("'", "");


                str = "SELECT        *  FROM            FB_MessageReceived WHERE        (Msg_id = '" + Msg_id + "')";
                sql = "INSERT INTO FB_MessageReceived  (Sender, Msg_id, Message, Status)  VALUES     ('" + sender + "', '" + Msg_id + "', '" + NewBody + "' ,1)";
               dt = getDataset(str);

               if (dt.Tables[0].Rows.Count==0) 
               {
                   exeNonQury(sql); 
               }
            
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }
}
