using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Umler.Commands
{
    public class ApplicationCommands : IApplicationCommands
    {
        public CompositeCommand  ExitApplication { get; } = new CompositeCommand ();
        public CompositeCommand  OpenFile { get; } = new CompositeCommand ();
        public CompositeCommand  ShowOptions { get; } = new CompositeCommand ();

    }

}
