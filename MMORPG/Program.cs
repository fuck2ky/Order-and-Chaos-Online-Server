using MMORPG.Source.Servers;

namespace MMORPG
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var server = new ServerMasterLoader())
            {
                server.Init(args);
                server.Run(args);
                server.Finish();
            }
        }
    }
}
