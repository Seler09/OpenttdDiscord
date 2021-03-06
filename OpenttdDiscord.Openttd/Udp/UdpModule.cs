﻿using Microsoft.Extensions.DependencyInjection;
using OpenttdDiscord.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenttdDiscord.Openttd.Udp
{
    public class UdpModule : IModule
    {
        public void Register(in IServiceCollection services)
        {
            services.AddSingleton<IUdpPacketCreator, UdpPacketCreator>();
            services.AddSingleton<IUdpPacketReader, UdpPacketReader>();
            services.AddTransient<IUdpOttdClient, UdpOttdClient>();
        }
    }
}
