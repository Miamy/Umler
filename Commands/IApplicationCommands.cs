using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umler.Commands
{
    public interface IApplicationCommands
    {
        CompositeCommand ExitApplication { get; }
        CompositeCommand OpenFile { get; } 
        CompositeCommand ShowOptions { get; }
    }
}
