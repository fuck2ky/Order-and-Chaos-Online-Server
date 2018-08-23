namespace MMORPG.Source.Base.Exceptions
{
    public class RunTimeException : GException
    {
        public RunTimeException(string message)
        {
            _error = message;
        }

        public override void Print()
        {
            _logger.Error($"RunTimeException: {_error}");
        }
    }
}
