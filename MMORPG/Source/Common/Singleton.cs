﻿using MMORPG.Source.Utils;
using System;

namespace MMORPG.Source.Common
{
    public abstract class Singleton<T> : IDisposable where T: new()
    {
        protected static T _instance;

        public static T Instance()
        {
            if (_instance == null)
                _instance = new T();

            return _instance;
        }

        public static T New()
        {
            return new T();
        }

        public void Dispose()
        {
            
        }
    }
}
