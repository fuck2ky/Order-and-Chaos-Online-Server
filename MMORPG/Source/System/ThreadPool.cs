using System;
using System.Collections.Generic;

namespace MMORPG.Source.System
{
    public class ThreadPool
    {
        protected Mutex _mutex;
        protected List<Thread> _threads;

        protected ThreadPool()
        {
            _mutex.Lock();
            _threads.Clear();
            _mutex.Unlock();
        }

        public int Start()
        {
            throw new NotImplementedException();
        }

        public int Stop()
        {
            throw new NotImplementedException();
        }

        protected virtual int Prepare()
        {
            return 0;
        }

        protected virtual int Finish()
        {
            throw new NotImplementedException();
        }

        public void Add(Thread thread)
        {

        }

        public void Remove(Thread thread)
        {

        }
    }
}
