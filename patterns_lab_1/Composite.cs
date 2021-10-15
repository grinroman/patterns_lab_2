using System;
using System.Collections.Generic;
using System.Text;

namespace patterns_lab_1
{
    interface IEMail
    {
        void Send(string message);
        string Name { get; set; }
        public void Send(string message, string towhom);


    }

    class Group : IEMail
    {
        public Group(params IEMail[] es) => Append(es);
        public List<IEMail> eMails = new List<IEMail>();

        public string Name { get; set; }

        public void Append (params IEMail[] es)
        {
            foreach (var item in es)
            {
                eMails.Add(item);
            }
        }

        public void Send(string message)
        {
            foreach (var item in eMails)
            {   
                item.Send(message);
            }
        }

        public void Send(string message,string towhom)
        {
            foreach (var item in eMails)
            {
                item.Name = towhom;
                item.Send(message);
                
            }
        }

   

    }

    class EMail: IEMail
    {
        public string Name { get; set; }
        public void Send(string message) => Console.WriteLine($"Was senttttt to {Name}  that {message}");
        public void Send(string message, string towhom) => Console.WriteLine($"Was senttttt to {towhom}  that {message}");

        public void Changename(string new_name) { this.Name = new_name; }

       
    }
}
