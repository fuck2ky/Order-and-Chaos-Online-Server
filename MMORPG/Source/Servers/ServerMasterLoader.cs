using MMORPG.Source.Common;
using MMORPG.Source.Types.Enums;

namespace MMORPG.Source.Servers
{
    public class ServerMasterLoader : Singleton<ServerMasterLoader>
    {
        private ServerMaster _master;
        private bool _end;
        private ServerType _serverType;
        private bool _lobbyMode;
        private Config _config;

        public ServerMasterLoader()
        {
            if (_instance != null)
                throw new GException("Cannot re-instantiate Singleton class.");
            _lobbyMode = false;
            _end = false;
            _master = null;
            _serverType = ServerType.TYPE_NONE;
            _instance = this;
        }

        public void Init(string[] args)
        {
            // TODO: Implement
        }

        public void Run(string[] args)
        {
            // TODO: Implement
        }

        public void End(uint time)
        {
            _end = true;
            if (_master) _master->End(time);
            //WatchDogThread::Instance().ForceAppExit(time + 5 * 60 * 1000); // source/server/src/framework
        }

        public void Finish()
        {
            // TODO: Implement
        }
    }
}
