using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.ServiceProcess;
using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace FaceBookCommunicator
{
    class DataProcessor
    {
        Boolean isRunning;
        private static readonly log4net.ILog actionLog = log4net.LogManager.GetLogger
   (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void ThreadMethod()
        {
            Thread thread = null;
            ThreadStart job = new ThreadStart(RunCaller);
            thread = new Thread(job);
            isRunning = true;
            thread.Start();

        }


        private void RunCaller()
        {
            while (isRunning)
            {

                try
                {
                    facebook fb = new facebook();
                    fb.GetFBMsg();
                    //EmailReceiver email = new EmailReceiver();
                    NLP nlpCls = new NLP();
                   // EmailSender sendMail = new EmailSender();
                    NlpProcessor mailProcess = new NlpProcessor();
                    actionLog.Info("Receiving FB Message Strated");
                    //email.ReceiveMails();
                    actionLog.Info("Processing FB Message Started");
                    mailProcess.processData();
                    actionLog.Info("Send aknoledge FB Message started");
                   //sendMail.ComposeFinalEmail();
                    actionLog.Info("Send Slection and Assignment started");
                   // mailProcess.SelectionAndAssignProcess();
                    //sendMail.ComposeDefaultEmail();
                    
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {

                }
            }
        }


    

        

    }
}
