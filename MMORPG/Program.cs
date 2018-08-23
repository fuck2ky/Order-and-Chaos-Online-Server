#define DEBUG

using MMORPG.Source.Servers;
using MMORPG.Source.Utils;
using System;

namespace MMORPG
{
    public class Program
    {
        static void Main(string[] args)
        {
            Logger.Instance();

            using (var server = new ServerMasterLoader())
            {
                server.Init(args);
                server.Run(args);
                server.Finish();
            }

#if DEBUG
            Console.ReadLine();
#endif
        }
    }
}
