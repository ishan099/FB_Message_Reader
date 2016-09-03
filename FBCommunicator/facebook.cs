﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using Newtonsoft.Json;



namespace FaceBookCommunicator
{
    class facebook
    {

        Dao dataAccess;

        public String fbMsg;
        public String custName;
        public String custId;

        public void GetFBMsg()
        {
            //Console start and print the message
            Console.WriteLine("Message Receiving Started");
            string facebookToken = "EAACEdEose0cBAOqbvbEkRQg7hMYNpD9z4vKfpMhNpX1xmwnEyoGZCzepEluXPJa3FsPzbiNz3zrQT7Jtgx6Du3yIZCZByZBTJ58D9SrFnsrRsz8J7ZBVQPZCjyHjpwgHoitDTWTnkjgGZCOsXIDJcSnZAZAPswYE414EvA9NZAZAIXiBgZDZD";
            var client = new FacebookClient(facebookToken);
            try
            {
            dynamic me = client.Get("me/conversations?fields=messages", null);
            
            

                foreach (dynamic item in me.data)
                {
                    //item is a conversation
                    //the latest updated conversations come first so
                    //im just gona grab the first conversation with unreaded / unseen messages
                    // string conversationID = item.id;
                    
                    var name = item[2][0];


                    foreach (var it in item.messages.data)
                    {
                        var val = it;
                        string jsonss = Newtonsoft.Json.JsonConvert.SerializeObject(val);
                        fbMsg = val.message;
                        custName = val.from.name; ;
                         custId = val.id;



                         Console.WriteLine("From: {0}", fbMsg.ToString());
                    

                         //save fb message to DB
                         dataAccess = new Dao();
                        dataAccess.SaveMsg(custName, custId, fbMsg);
                         Console.WriteLine("Fb msg receiving complated and saved to the DB");
                        


                    }

                }



            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message.ToString());
            }

        }
    }
}