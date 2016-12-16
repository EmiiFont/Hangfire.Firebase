﻿using Hangfire.Storage;
using System.Threading;
using System.Threading.Tasks;

namespace Hangfire.Firbase.Queue
{
    public interface IPersistentJobQueue
    {
        Task<IFetchedJob> Dequeue(string[] queues, CancellationToken cancellationToken);
        void Enqueue(string queue, string jobId);
    }
}
