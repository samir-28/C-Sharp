using System;

namespace EventsUsingDelegates
{
     
    public delegate void SimpleEventHandler();

    public class Publisher
    {
        public event SimpleEventHandler SimpleEvent;


        //method to raise the event
        //public void RaiseEvent()
        public void Invite()
        {
            Console.WriteLine("Publisher (Event Organizer) is raising an event .");
            SimpleEvent?.Invoke();
        }

    }

    public class Subscriber
    {
        //event handler method
        //public void OnEvent()
        public void Samir()
        {
            Console.WriteLine("Subscriber (Samir) received the invitation for event.");
        }
        public void Ram()
        {
            Console.WriteLine("Subscriber (Ram) received the invitation for event.");
        }
        public void Hari()
        {
            Console.WriteLine("Subscriber (Hari) received the invitation for event.");
        }
    }
    internal class Program
    {
        static void Main()
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            //publisher.SimpleEvent += subscriber.OnEvent;
            //publisher.RaiseEvent();

            publisher.SimpleEvent += subscriber.Ram;
            publisher.SimpleEvent += subscriber.Samir; 
            publisher.SimpleEvent += subscriber.Hari;
            publisher.Invite();
        }
    }
}
