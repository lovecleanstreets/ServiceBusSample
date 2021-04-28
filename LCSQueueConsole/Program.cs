using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using LCSShared.Domain;
using LoveCleanStreets.Contracts.ServiceBus;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;


namespace LCSQueueConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var factory = MessagingFactory.CreateFromConnectionString("xxxxx");

            Console.WriteLine("Send Queue Messages");
         //   SendMessage(factory);

            Console.WriteLine("Getting Queue Messages");
            GetMessages(factory, "testreports/subscriptions/XXXXX");


            Console.WriteLine("Finished press any key to exit");
            Console.ReadKey();
        }

        private static void SendMessage(MessagingFactory factory)
        {
      
            MessageSender topicSender = factory.CreateMessageSender("testincoming");

            var record = CreateRecordForAppFabircWithImage();

        
            var bMsg = new BrokeredMessage(record);      
            topicSender.Send(bMsg);
        }

        private static ClientReportItem CreateRecordForAppFabirc()
        {
            return new ClientReportItem()
                {
                    Description = "Hello Azure Service Bus",
                    DateTimeRecorded = DateTime.UtcNow,
                    CategoryId = 1, // This is the category id
                    EmailAddress = "",
                    Latitude = 53.408406,
                    Longitude = -2.991636
                };
        }

        private static ClientReportItem CreateRecordForAppFabircWithImage()
        {
            var item = CreateRecordForAppFabirc();
    
            return item;
            
        }


    

        private static void GetMessages(MessagingFactory factory, string name)
        {

            Console.WriteLine("Starting: {0}", name);
            MessageReceiver messages =
                factory.CreateMessageReceiver(name);

            BrokeredMessage msg = messages.Receive(new TimeSpan(0, 0, 5));

            int count = 0;
            while (msg != null)
            {
                //msg.Complete();
                var orderOut = msg.GetBody<Report>();                

                // Display some message information to the console.
                Console.WriteLine("Received: , {0} {1} for {2} - LA {3} - {4}:{5}", orderOut.CreatedDateTime, orderOut.ReportId,
                                    orderOut.Description, orderOut.LocalAuthority,orderOut.AdditionalLocationInformation,orderOut.ReportLocation);

                msg.Complete();
                count++;
                Console.WriteLine("Count : {0}", count);
             
                msg = messages.Receive(new TimeSpan(0, 0, 5));
            }

            Console.WriteLine("Done: {0}", name);
        }
    }
}
