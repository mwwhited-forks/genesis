﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Genesis.Cli;

namespace Genesis.Population
{
    public interface IPopulator : IGenesisExecutor<ITaskResult>
    {
        IPopulatorConfiguration Configuration { get; set; }
    }
}
