using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Guide.Event
{
    //Subscriber에서 사용할 커스텀 이벤트 구현
    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }

    
    class Publisher
    {
        // 이벤트 핸들러 선언
        public event EventHandler<CustomEventArgs> RaiseCustomEvent;

        public void DoSomething()
        {
            // publisher에서 DoSOmthing을 호출히 달려있는 모든 함수 호출
            OnRaiseCustomEvent(new CustomEventArgs("Event triggered"));
        }

        
        protected virtual void OnRaiseCustomEvent(CustomEventArgs e)
        {
            
            EventHandler<CustomEventArgs> raiseEvent = RaiseCustomEvent;

            if (raiseEvent != null)
            {
                e.Message += $" at {DateTime.Now}";

                raiseEvent(this, e);
            }
        }
    }

    //Class that subscribes to an event
    class Subscriber
    {
        private readonly string _id;

        public Subscriber(string id, Publisher pub)
        {
            _id = id;

            // Subscribe to the event
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        // Define what actions to take when the event is raised.
        void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine($"{_id} received this message: {e.Message}");
        }
    }

    class EventExample
    {
        static void EventBegin()
        {
            var pub = new Publisher();
            var sub1 = new Subscriber("sub1", pub);
            var sub2 = new Subscriber("sub2", pub);

            // Call the method that raises the event.
            pub.DoSomething();

            // Keep the console window open
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
