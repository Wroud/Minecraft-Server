using System.Threading;

namespace Minecraft_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Info("Minecraft Server");
            Network.Initz();
            Server.Main.Main.Initz();

            Log.Info("Инициализация");
            while (!Network.Init && !Server.Main.Main.Init)
            {
                Thread.Sleep(700);
                Log.Update("Инициализация",".");
            }
            Network.Run();
            Log.Info("Сервер запущен");
            while (true)
                Thread.Sleep(700);
        }
    }
}
