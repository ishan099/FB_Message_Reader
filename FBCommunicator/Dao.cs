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



       // Get FB message Details to the DB
       public DataTable GetMailDetailsToReply()
       {

           try
           {

               try
               {
                   string sql = "";
                   DataSet dt;
                   sql = "SELECT     FB_MessageReceived.ID, FB_MessageReceived.Sender, FB_MessageReceived.Msg_id, FB_MessageReceived.Message, FB_MessageReceived.ReceivedDate, " + 
                         " FB_MessageReceived.RepliedDate, FB_MessageReceived.Status, FB_MessageReceived.IsReplied, FB_MessageReceived.IsProcessed, FB_MessageReceived.IsResolved," +
                         " CIA_Interaction.InteractionID " +
                         " FROM         FB_MessageReceived INNER JOIN "  +
                         " CIA_Interaction ON FB_MessageReceived.ID = CIA_Interaction.EmailReferance " +
                         " WHERE     (FB_MessageReceived.IsReplied = 0 )";
                   dt = getDataset(sql);
                   return dt.Tables[0];
               }
               catch (Exception ex)
               {
                   throw ex;
               }

           }
           catch (Exception ex)
           {
               throw ex;
           }
       }



       // Get FB message Details to the DB
       public DataTable GetMailDetailsToFinalReply()
       {

           try
           {

               try
               {
                   string sql = "";
                   DataSet dt;
                   sql = "SELECT     FB_MessageReceived.IsResolved, FB_MessageReceived.ID, CIA_Interaction.AgentRemark, CIA_Interaction.Status, FB_MessageReceived.Message,  "+
                         " FB_MessageReceived.Sender,CIA_Interaction.InteractionID " +
                         " FROM         FB_MessageReceived INNER JOIN " +
                         " CIA_Interaction ON FB_MessageReceived.ID = CIA_Interaction.EmailReferance " +
                         " WHERE     (CIA_Interaction.Status = N'Closed') AND (FB_MessageReceived.IsResolved = 0)";
                   dt = getDataset(sql);
                   return dt.Tables[0];
               }
               catch (Exception ex)
               {
                   throw ex;
               }

           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
        //Update DB after responding to the mail
       public void UpdateStatusOfInitialMail(int id)
       {

           try
           {
               string sql = "";
               sql = "UPDATE     FB_MessageReceived SET  IsReplied  =1 where iD ='" + id + "' ";
               exeNonQury(sql);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

       //Update DB after responding to the mail
       public void UpdateStatusOfFinalMail(int id)
       {

           try
           {
               string sql = "";
               sql = "UPDATE     FB_MessageReceived SET  IsResolved = 1 where iD ='" + id + "' ";
               exeNonQury(sql);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }


       // Get email message details to process
       public DataTable GetMailDetailsToProcess()
       {

           try
           {

               try
               {
                   string sql = "";
                   DataSet dt;
                   sql = "SELECT     ID, Sender, Msg_id, Message, ReceivedDate, RepliedDate, Status, IsReplied, IsProcessed, IsResolved FROM FB_MessageReceived where IsProcessed =0";
                   dt = getDataset(sql);
                   return dt.Tables[0];
               }
               catch (Exception ex)
               {
                   throw ex;
               }

           }
           catch (Exception ex)
           {
               throw ex;
           }
       }


       // Get  message details to process
       public DataTable GetMailDetailsForIntractions(Int16 ID)
       {

           try
           {

               try
               {
                   string sql = "";
                   DataSet dt;
                   sql = "SELECT   FB_MessageReceived.ID, FB_MessageReceived.Sender,  FB_MessageReceived.Message, FB_MessageReceived_Details.MessageParts, " + 
                            " FB_MessageReceived_Details.Count " +
                            " FROM   FB_MessageReceived INNER JOIN " +
                            " FB_MessageReceived_Details ON FB_MessageReceived.ID = FB_MessageReceived_Details.ID where IsAssigned =0 and FB_MessageReceived.ID ='" + ID + "' order by FB_MessageReceived_Details.Count desc ";
                   dt = getDataset(sql);
                   return dt.Tables[0];
               }
               catch (Exception ex)
               {
                   throw ex;
               }

           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

       public DataTable GetMailDetails()
       {

           try
           {

               try
               {
                   string sql = "";
                   DataSet dt;
                   sql = "SELECT     ID, Sender, Msg_id, Message, IsAssigned FROM    FB_MessageReceived WHERE (IsAssigned = 0) ";
                   dt = getDataset(sql);
                   return dt.Tables[0];
               }
               catch (Exception ex)
               {
                   throw ex;
               }

           }
           catch (Exception ex)
           {
               throw ex;
           }
       }


       //public DataTable GetReassignedIntractions()
       //{

       //    try
       //    {

       //        try
       //        {
       //            string sql = "";
       //            DataSet dt;
       //            sql = "SELECT      CIA_Interaction.InteractionID, CIA_Interaction.TypeID, CIA_Interaction.CatID, CIA_Interaction.SubCatID, CIA_Interaction.EmailReferance, CIA_Interaction.InteractionTypeID, "+
       //              " FB_MessageReceived.ID, FB_MessageReceived_Details.MessageParts, FB_MessageReceived_Details.Count, CIA_Interaction.AssignedGroup, CIA_Interaction.Reassign, "+
       //              " FB_MessageReceived.IsResolved " +
       //              " FROM         CIA_Interaction INNER JOIN "+
       //              " FB_MessageReceived ON CIA_Interaction.EmailReferance = FB_MessageReceived.ID INNER JOIN "+
       //              " FB_MessageReceived_Details ON FB_MessageReceived.ID = FB_MessageReceived_Details.ID " +
       //              " WHERE     (CIA_Interaction.Reassign = 1) AND (FB_MessageReceived.IsResolved = 1) ";
       //            dt = getDataset(sql);
       //            return dt.Tables[0];
       //        }
       //        catch (Exception ex)
       //        {
       //            throw ex;
       //        }

       //    }
       //    catch (Exception ex)
       //    {
       //        throw ex;
       //    }
       //}


       //Update DB after processing
       public void UpdateStatusOfProcessedMails(int id)
       {

           try
           {
               string sql = "";
               sql = "UPDATE     FB_MessageReceived SET  IsProcessed  =1 where iD ='" + id + "' ";
               exeNonQury(sql);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

       //Update DB after processing
       public void UpdateStatusOfAssignIntractionMails(int id)
       {

           try
           {
               string sql = "";
               sql = "UPDATE     FB_MessageReceived SET  IsAssigned   =1 where iD ='" + id + "' ";
               exeNonQury(sql);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }


       // Save email message Details to the DB
       public void SaveMailDetails(int ID, String messageParts, String count)
       {

           try
           {
               string sql = "";
               sql = "INSERT INTO FB_MessageReceived_Details  (ID, MessageParts, Count)  VALUES     ('" + ID + "', '" + messageParts + "', '" + count + "' )";
               exeNonQury(sql);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }


       public DataTable GetCategoryAndGroupDetaile()
       {

           try
           {

               try
               {
                   string sql = "";
                   DataSet dt;
                   sql = " SELECT     CIA_InteractionType.InteractionType, CIA_InteractionType.InteractionTypeID, CIA_Type.TypeID, CIA_Type.Type, CIA_Category.CatID, CIA_Category.Category, CIA_SubCategory.SubCatID, " +
                    " CIA_SubCategory.SubCategory, CIA_SubCategory.AssignedGroup, CIA_SubCategory.IsActive " +
                     " FROM         CIA_Type INNER JOIN " +
                    " CIA_InteractionType ON CIA_Type.InteractionTypeID = CIA_InteractionType.InteractionTypeID INNER JOIN " +
                    " CIA_Category ON CIA_Type.TypeID = CIA_Category.TypeID INNER JOIN " +
                    " CIA_SubCategory ON CIA_Category.CatID = CIA_SubCategory.CatID " +
                    " WHERE     (CIA_SubCategory.IsActive = 1)";
                   dt = getDataset(sql);
                   return dt.Tables[0];
               }
               catch (Exception ex)
               {
                   throw ex;
               }

           }
           catch (Exception ex)
           {
               throw ex;
           }
       }


       public Boolean InserIntraction(Int32 intractionID, int cusType, int cusID, int type, int mainCat, int cat, int subCat, String remarks, String phoneNum, int cUser, String status, int modifiedUser, int assignGrp, int assignUser, String email, int emailRef)
       {
           try
           {
               SqlParameter[] param = new SqlParameter[16];
               param[0] = new SqlParameter("@IntractionID", intractionID);
               param[1] = new SqlParameter("@CCustype", cusType);
               param[2] = new SqlParameter("@CusID", cusID);
               param[3] = new SqlParameter("@Type", type);
               param[4] = new SqlParameter("@MainCat", mainCat);
               param[5] = new SqlParameter("@Cat", cat);
               param[6] = new SqlParameter("@SubCat", subCat);
               param[7] = new SqlParameter("@Remarks", remarks);
               param[8] = new SqlParameter("@phoneNumber", phoneNum);
               param[9] = new SqlParameter("@CreateUser", cUser);
               param[10] = new SqlParameter("@Status", status);
               param[11] = new SqlParameter("@ModifiedUser", modifiedUser);
               param[12] = new SqlParameter("@AssignedGroup", assignGrp);
               param[13] = new SqlParameter("@AssignUser", assignUser);
               param[14] = new SqlParameter("@Email", email);
               param[15] = new SqlParameter("@EmailRef", emailRef);
               callSp("Sp_InsertIntraction", param);
               return true;
           }
           catch (Exception ex)
           {
               throw ex;
           }

       }


       
    }
}
