
namespace Cursor
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventLoop = new EventLoop();
            var cursor = new CursorControle();

            eventLoop.LeftHandler += cursor.OnLeft;
            eventLoop.RightHandler += cursor.OnRight;
            eventLoop.UpHandler += cursor.OnUp;
            eventLoop.DownHandler += cursor.OnDown;

            eventLoop.Run();
        }
    }
}
