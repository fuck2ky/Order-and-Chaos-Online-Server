using MMORPG.Source.Utils;
using System;

namespace MMORPG.Source.Base.Exceptions
{
    public class GException : Exception
    {
        protected Logger _logger;
        protected string _error;

        public GException()
        {
            _logger = Logger.Instance();
        }

        public virtual void Print()
        {
            _logger.Warning("GException::Print()");
        }
    }
}
