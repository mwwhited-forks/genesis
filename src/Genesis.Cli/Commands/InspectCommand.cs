﻿using Genesis.Cli.Extensions;
using Genesis.Output;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Cli.Commands
{
    public class InspectCommand : GenesisCommand
    {
        public override string Name { get => "inspect"; } //I keep typing 'exec' whatever, and it's annoying. 

        public override string Description => "Inspect an IGenesisExecutor";

        public override async Task<IGenesisExecutionResult> Execute(GenesisContext genesis, string[] args)
        {
            var btr = new BlankGenesisExecutionResult();

            if (args.Length < 2)
            {
                Text.White("Specify an Executor "); Text.CliCommandLine("Name");
                return btr;
            }

            var exeName = args[1];

            //NOTE: Added that default help stuff for commands. Copy / Pasted 'gen' command here ;)

            var exe = GetExecutor(exeName);
            await exe.DisplayConfiguration();

            Text.Line();

            return await Task.FromResult(btr);
        }
    }
}
