﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenttdDiscord.Common
{
    public interface IModule
    {
        void Register(in IServiceCollection services);
    }
}
