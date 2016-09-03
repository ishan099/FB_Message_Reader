using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.IO;
using System.Net.Configuration;
using System.Net;
using System.Data;



namespace FaceBookCommunicator
{
  public  class EmailSender
    {
        //Referance for data access
        Dao dataAccess;
        public void ComposeDefaultEmail()
        {

            try
                {
                    
                     DataTable dt;
                     dataAccess = new Dao();
                     string  intractionID = "";
                     dt = dataAccess.GetMailDetailsToReply();

                if (dt.Rows.Count >0)
                {
                   foreach(DataRow row in dt.Rows)
                        {
                            Console.WriteLine("Start Sending Default Replay");
                             intractionID =(row["InteractionID"].ToString()); 
                            Console.WriteLine(row["Sender"].ToString());
                            MailMessage(row["Sender"].ToString(), "Automatic Reply", "Thank you for contacting C & X costomer care. We will address your matter soon. " + "Your ticket id is " + intractionID );
                            dataAccess.UpdateStatusOfInitialMail(Convert.ToInt16(row["ID"].ToString()));
                            Console.WriteLine("Mail Final Sending complated and saved to the DB");
                        }
                }
                     
                     
               
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
        }


        public void ComposeFinalEmail()
        {

            try
            {

                DataTable dt;
                dataAccess = new Dao();
                string intractionID = "";
                String agentComment ="";
                dt = dataAccess.GetMailDetailsToFinalReply();

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Console.WriteLine("Start Sending Final Replay");
                        intractionID = (row["InteractionID"].ToString());
                        agentComment =(row["AgentRemark"].ToString());
                        Console.WriteLine(row["Sender"].ToString());
                        MailMessage(row["Sender"].ToString(), "C & X Customere Care", "We have closed the ticket number : " + intractionID +". Agent Comment is : " + agentComment + " .Thanks You....");
                        dataAccess.UpdateStatusOfFinalMail(Convert.ToInt16(row["ID"].ToString()));
                        Console.WriteLine(" Final Mail Sending complated and saved to the DB");
                    }
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        
        //To create mail meaasge 
        public void MailMessage( String toAddr,String subject,string body)
        {
            try
            {
                Console.WriteLine("Mail sending started.......... ");
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("scms.icbt@gmail.com");
                msg.To.Add(toAddr);
                msg.Subject = "SCMS Customer Care";
                msg.IsBodyHtml = true;
                msg.BodyEncoding = Encoding.ASCII;
                msg.Body = body;
                sendMail(msg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
           
            
            
        }


        // TO send email message via SMTP protocol
        public static void  sendMail(MailMessage msg)
        {
            string username = "scms.icbt@gmail.com";  
            string password = "Dal%painto13";  //password
            SmtpClient mClient = new SmtpClient();
            mClient.Host = "smtp.gmail.com";
            mClient.Port = 587;
            mClient.EnableSsl = true;
            mClient.Credentials = new NetworkCredential(username, password);
            mClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            mClient.Timeout = 100000;
            mClient.Send(msg);
            Console.WriteLine("mail message sent ");
        }
    }
}
