using System;

namespace patterns_lab_1
{
    class Program
    {
        interface Isender
        {
            void Send(string message);
        }

        class Requester
        {
            public void SendRequest(string message)
            {
                Console.WriteLine($"As a request we sent next message: {message}");
            }
        }

        class Adapter : Requester, Isender
        {
            public void Send(string message) 
            {
                this.SendRequest(message);
            }
        }
        static void Main(string[] args)
        {
            Requester req1 = new Requester();
            req1.SendRequest("Send Request");
            Adapter ad1 = new Adapter();
            ad1.Send("Send");

            Console.WriteLine("Select the Message Type 1. For longmessage or 2. For shortmessage");
            int MessageType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the message that you want to send");
            string Message = Console.ReadLine();
            if (MessageType == 1)
            {
                AbstractMessage longMessage = new LongMessage(new EmailMessageSender());
                longMessage.SendMessage(Message);
            }
            else
            {
                AbstractMessage shortMessage = new ShortMessage(new SmsMessageSender());
                shortMessage.SendMessage(Message);
            }

            EMail bro1 = new EMail { Name = "Андрюха" };
            //bro1.Send();
            EMail bro2 = new EMail { Name = "Жека" };
            //bro2.Send();
            EMail bro3 = new EMail { Name = "Серега" };
            //bro3.Send();
            EMail bro4 = new EMail { Name = "Лёха" };
            //bro4.Send();
            Group sobutilniki = new Group(bro1, bro2, bro3);
            sobutilniki.Send("We are going to drink!");
            sobutilniki.Send("We are going to drink!", "alhogolic");

            PepperoniPizza pp = new PepperoniPizza(new Pizza());
            Console.WriteLine(pp.MakePizza);
            var ppb = new Bacon(new PepperoniPizza(new Pizza()));
            Console.WriteLine(ppb.MakePizza);

            Cooking_Actions ca = new Cooking_Actions();
            Cooking_Meal cm = new Cooking_Meal(ca);
            cm.Pohavat_breakfast();

            Human h1 = new Human();
            h1.Age = 20;
            Avatar a1 = new Avatar(h1);
            Console.WriteLine(a1.AvatarAge);
            h1.Age = 40;
            Console.WriteLine(a1.AvatarAge);

            Reprository db = new Reprository();
            Emploee e1 = new Emploee("жорик 2 алкоголик", db);
            Emploee e2 = new Emploee("валера 2 наркоман", db);
            Emploee e3 = new Emploee("ванек 4 алкоголик", db);
            Emploee e4 = new Emploee("жорик 2 наркоман", db);
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
            Console.WriteLine(e4);
            Console.WriteLine(String.Join("\n", Reprository.data));





        }
    }
}
