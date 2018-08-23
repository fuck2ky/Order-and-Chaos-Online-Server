using MMORPG.Source.Base.Exceptions;
using MMORPG.Source.Common;
using MMORPG.Source.Utils;
using System;
using System.Net.Sockets;

namespace MMORPG.Source.Servers
{
    public class ServerMaster : Singleton<ServerMaster>
    {
        protected Logger _logger;
        public Config Config { get; set; }
        protected bool _lobbyMode;
        public string LobbyIp { get; protected set; }
        public string OspBase64Param { get; set; }

        protected uint _gsId;
        public uint GsId
        {
            get
            {
                return _gsId;
            }
            set
            {
                _gsId = value;
                GsIdStr = value.ToString();
            }
        }
        public string GsIdStr { get; protected set; }
        public string GsName { get; set; }

        protected uint _endDelay;
        protected bool _isEnd;

        public uint IdleTime { get; protected set; }
        public string StartTime { get; protected set; }

        protected static string _virtualGGI;
        public static string VirtualGGI
        {
            get
            {
                return _virtualGGI;
            }
            set
            {
                _virtualGGI = value;
                IntVirtualGGI = int.Parse(_virtualGGI);
            }
        }
        public static int IntVirtualGGI { get; protected set; }

        public ServerMaster()
        {
            if (_instance != null)
                throw new RunTimeException("Cannot re-instantiate Singleton class ServerMasterLoader.");
            _logger = Logger.Instance();
            Config = null;
            _lobbyMode = false;
            _isEnd = false;
            GsId = 0;
            IdleTime = 0;
            _endDelay = 24 * 60 * 60 * 1000;
            StartTime = DateTime.UtcNow.ToLongDateString();
            VirtualGGI = "0";
            _instance = this;
        }

        public void SetLobbyMode(string lobbyIp)
        {
            _lobbyMode = true;
            LobbyIp = lobbyIp;
        }

        public bool IsLobbyMode()
        {
            return _lobbyMode;
        }

        public void End(uint delay)
        {
            if (!_isEnd)
                _logger.Error($"ServerMaster::End(): server will exit in {delay} ms!");
            _isEnd = true;
            delay = Math.Min(delay, 1000 * 60 * 5);
            _endDelay = Math.Min(_endDelay, delay);
        }

        public void AddIdleTime(uint t)
        {
            IdleTime += t;
        }

        public void ResetIdleTime()
        {
            IdleTime = 0;
        }

        // Game server: player count; global server: game server count 
        public virtual uint GetCurrentUserCount() => 0;

        // Game server: max player count can be supported; global server: max game server count can be supported
        public virtual uint GetMaxUserCount() => 0;

        // Game server: kick user; global server: no action
        public virtual void KickUser(string userAccountId) { }

        // Game sever: gsName; global server: empty
        public virtual string GetName() => "";

        // Game server: push msg and kick user; global server: no action
        public virtual void BanUser(uint playerId, string fromTime, string toTime) { }
        
        // Game server: push chat msg; global server: no action
        public virtual void GMChat(string playerAcctId, uint playerid, string msg) { }

        public virtual void SetListenFd(SocketType listenFd) { }

        public virtual bool InitSingleton() { throw new RunTimeException("Method ServerMaster.InitSingleton() can only be called in derived classes."); }
        public virtual bool FinishSingleton() { throw new RunTimeException("Method ServerMaster.FinishSingleton() can only be called in derived classes."); }
        public virtual int Run(string[] args) { throw new RunTimeException("Method ServerMaster.Run() can only be called in derived classes."); }
    }
}
