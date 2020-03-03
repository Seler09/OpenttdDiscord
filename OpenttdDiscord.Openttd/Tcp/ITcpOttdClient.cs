﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenttdDiscord.Openttd.Tcp
{
    public interface ITcpOttdClient
    {
        event EventHandler<ITcpMessage> MessageReceived;
        Task QueueMessage(ITcpMessage message);

        /// <summary>
        /// It should make sure that TCP client is up and running.
        /// </summary>
        Task Start(string serverIp, int serverPort, string username, string password = "");

        /// <summary>
        /// It should make sure that Tcp Client stopped
        /// </summary>
        Task Stop();
    }
}
