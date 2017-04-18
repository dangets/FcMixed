using System;
using Akka.Actor;

namespace FcMixed.CsLib {
    public class Greet
    {
        public Greet(string who)
        {
            Who = who;
        }

        public string Who { get; private set; }
    }

    public class GreetingActor : ReceiveActor
    {
        public GreetingActor()
        {
            Receive<Greet> (greet => Console.WriteLine("Hello {0}", greet.Who));
        }
    }

    public static class Program
    {
        public static void Go() {
            var system = ActorSystem.Create("MySystem");
            var greeter = system.ActorOf<GreetingActor>("greeter");

            greeter.Tell(new Greet("World"));
        }
    }

}