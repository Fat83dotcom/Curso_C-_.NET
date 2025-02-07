using Timmer;

Timerr t = new();

t.Start();

namespace Timmer
{
    public class Timerr
    {
        public void Start()
        {
            int time = 10;
            int currentTime = 0;
            while (currentTime < time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
        }
    }
}
