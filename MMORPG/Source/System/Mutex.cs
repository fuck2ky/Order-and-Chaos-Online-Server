using System;

namespace MMORPG.Source.System
{
    public class Mutex
    {
        public int Lock()
        {
            throw new NotImplementedException();
        }

        public int Unlock()
        {
            throw new NotImplementedException();
        }

        public int TryLock()
        {
            throw new NotImplementedException();
        }

        public void Acquire()
        {
            Lock();
        }

        public void Release()
        {
            Unlock();
        }

        public bool AttemptAcquire()
        {
            return TryLock() == 0;
        }
    }
}
