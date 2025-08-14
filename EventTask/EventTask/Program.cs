using System;

namespace EventsUsingDelegates
{

    public delegate void SimpleEventHandler();

    public class Publisher
    {
        public event SimpleEventHandler GraduationParty;

        public void Invite()
        {
            Console.WriteLine("Publisher (Event Organizer) is raising a Graduation Party event.");
            GraduationParty?.Invoke();
        }

    }

    public class Subscriber
    {
        public void Samir()
        {
            Console.WriteLine("Subscriber (Samir) received the invitation for Graduation Party.");
        }
        public void Ram()
        {
            Console.WriteLine("Subscriber (Ram) received the invitation for Graduation Party.");
        }
        public void Hari()
        {
            Console.WriteLine("Subscriber (Hari) received the invitation for Graduation Party.");
        }
        public void Sita()
        {
            Console.WriteLine("Subscriber (Sita) received the invitation for Graduation Party.");
        }
        public void Gita()
        {
            Console.WriteLine("Subscriber (Gita) received the invitation for Graduation Party.");
        }
        public void Ramesh()
        {
            Console.WriteLine("Subscriber (Ramesh) received the invitation for Graduation Party.");
        }
        public void Kabita()
        {
            Console.WriteLine("Subscriber (Kabita) received the invitation for Graduation Party.");
        }
        public void Mina()
        {
            Console.WriteLine("Subscriber (Mina) received the invitation for Graduation Party.");
        }
        public void Suman()
        {
            Console.WriteLine("Subscriber (Suman) received the invitation for Graduation Party.");
        }
        public void Nabin()
        {
            Console.WriteLine("Subscriber (Nabin) received the invitation for Graduation Party.");
        }
    }

    internal class Program
    {
        static void Main()
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            publisher.GraduationParty += subscriber.Samir;
            publisher.GraduationParty += subscriber.Ram;
            publisher.GraduationParty += subscriber.Hari;
            publisher.GraduationParty += subscriber.Sita;
            publisher.GraduationParty += subscriber.Gita;
            publisher.GraduationParty += subscriber.Ramesh;
            publisher.GraduationParty += subscriber.Kabita;
            publisher.GraduationParty += subscriber.Mina;
            publisher.GraduationParty += subscriber.Suman;
            publisher.GraduationParty += subscriber.Nabin;

            publisher.Invite();
        }
    }
}
