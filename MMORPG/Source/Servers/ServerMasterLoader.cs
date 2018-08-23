using MMORPG.Source.Base.Exceptions;
using MMORPG.Source.Common;
using MMORPG.Source.Types.Enums;
using MMORPG.Source.Utils;
using System;

namespace MMORPG.Source.Servers
{
    public class ServerMasterLoader : Singleton<ServerMasterLoader>
    {
        private ServerMaster _master;
        private bool _end;
        private ServerType _serverType;
        private bool _lobbyMode;
        private Config _config;
        protected Logger _logger;
        public static long IdleTime = 0; // 0 means no end

        public ServerMasterLoader()
        {
            if (_instance != null)
                throw new RunTimeException("Cannot re-instantiate Singleton class ServerMasterLoader.");
            _lobbyMode = false;
            _end = false;
            _master = null;
            _serverType = ServerType.TYPE_NONE;
            _instance = this;
            _logger = Logger.Instance();
        }

        public bool Init(string[] args)
        {
            var basePath = "./etc/mmorpg.conf"; // TODO: change
            var error = _config.Open(basePath);
            if (error != 0)
            {
                _logger.Error($"Config.Open({basePath}) failed, error {error}");
                var fullPath = AppDomain.CurrentDomain.BaseDirectory + "etc/mmorpg.conf"; // TODO: verify; change
                error = _config.Open(fullPath);
                if (error != 0)
                {
                    _logger.Error($"Config.Open({basePath}) failed, error {error}");
                    return false;
                }
            }

            if (args.Length > 2)
            {
                _lobbyMode = true;
            }

            var logLevel = _config.GetInteger("LOG", "LEVEL", 5);
            var logIdent = _config.GetString("LOG", "IDENT", "mmorpg");
            var logDir = _config.GetString("LOG", "DIR", "../log"); // TODO: change
            var enableSysLog = _config.GetInteger("LOG", "ENABLE_SYSLOG") == 1;

            // sOSPMaster.SetVirtualGGI(argv[1], strlen(argv[1])); but sOSPMaster is not defined in files
            var virtualGGI = "25470"; // sOSPMaster.GetVirtualGGI();
            ServerMaster.VirtualGGI = virtualGGI;

            if (ServerMaster.IntVirtualGGI != 0)
            {
                logIdent += "_" + virtualGGI;
            }

            _logger.Init(logLevel, logIdent, logDir, enableSysLog, !_lobbyMode);

            if (_logger.Start() < 0)
            {
                Console.WriteLine("Logger.Start() failed.");
                return false;
            }

            var minutes = _config.GetInteger("OTHER", "IDLE_TIMEOUT");
            if (minutes > 0)
            {
                IdleTime = minutes * 60 * 1000;
            }

            // SetCbLoadingGameServer(LoadingGameServer, this);
            // SetCbLoadingGlobalServer(LoadingGlobalServer, this);

            // OS.New();
            // GLLobby.New();

            return true;
        }

        public void Run(string[] args)
        {
            // TODO: Implement
            _logger.Info("ServerMasterLoader.Run()");
        }

        public void End(uint time)
        {
            _end = true;
            if (_master != null) _master.End(time);
            //WatchDogThread::Instance().ForceAppExit(time + 5 * 60 * 1000); // source/server/src/framework
        }

        public void Finish()
        {
            // TODO: Implement
            _logger.Info("ServerMasterLoader.Finish()");
        }
    }
}
