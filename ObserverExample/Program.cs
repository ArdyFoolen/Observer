using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObserverExample
{
    class Program
    {
        protected static int origRow;
        protected static int origCol;
        private static readonly Object lockObj = new Object();

        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                lock (lockObj)
                {
                    Console.SetCursorPosition(origCol + x, origRow + y);
                    Console.Write(s);
                    Console.SetCursorPosition(0, 1);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            Console.Clear();
            origRow = Console.CursorTop;
            origCol = Console.CursorLeft;

            StandardObserver.RealTimeDisplay realTimeDisplay = new StandardObserver.RealTimeDisplay();
            realTimeDisplay.Action = WriteAt;

            PushYouObserver.RealTimeDisplay realTimeDisplay2 = new PushYouObserver.RealTimeDisplay();
            realTimeDisplay2.Action = WriteAt;
            PushYouObserver.Clock pushYouClock = new PushYouObserver.Clock();
            pushYouClock.Register(realTimeDisplay2);

            DelegateObserver.RealTimeDisplay realTimeDisplay3 = new DelegateObserver.RealTimeDisplay();
            realTimeDisplay3.Action = WriteAt;

            GenericObserver.RealTimeDisplay realTimeDisplay4 = new GenericObserver.RealTimeDisplay();
            realTimeDisplay4.Action = WriteAt;
            GenericObserver.Clock genericClock = new GenericObserver.Clock();
            genericClock.Register(realTimeDisplay4);

            GenericDelegateObserver.RealTimeDisplay realTimeDisplay5 = new GenericDelegateObserver.RealTimeDisplay();
            realTimeDisplay5.Action = WriteAt;
            GenericDelegateObserver.ClockSubject genericDelClock = new GenericDelegateObserver.ClockSubject();
            genericDelClock.Register(realTimeDisplay5);

            Console.WriteLine("Press any key to continue. . .");
            Console.ReadKey();

            realTimeDisplay.Close();
            pushYouClock.EndTimer();
            realTimeDisplay3.Close();
            genericClock.EndTimer();
            genericDelClock.EndTimer();
        }
    }
}
