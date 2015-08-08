﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace INOVIX
{
    public class SimpleAsyncResult<T> : IAsyncResult
    {
        private readonly object accessLock = new object();
        private bool isCompleted = false;
        private T result;

        public SimpleAsyncResult(object asyncState)
        {
            AsyncState = asyncState;
        }

        public T Result
        {
            get
            {
                lock (accessLock)
                {
                    return result;
                }
            }
            set
            {
                lock (accessLock)
                {
                    result = value;
                }
            }
        }

        public bool IsCompleted
        {
            get
            {
                lock (accessLock)
                {
                    return isCompleted;
                }
            }
            set
            {
                lock (accessLock)
                {
                    isCompleted = value;
                }
            }
        }

        // WCF seems to use the async callback rather than checking the wait handle
        // so we can safely return null here.
        WaitHandle IAsyncResult.AsyncWaitHandle { get { return null; } }

        // We will always be doing an async operation so completed synchronously should always
        // be false.
        public bool CompletedSynchronously { get { return false; } }

        public object AsyncState { get; private set; }

    }

}
