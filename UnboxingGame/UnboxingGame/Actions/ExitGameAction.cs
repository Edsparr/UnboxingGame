using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnboxingGame.Actions
{
    public class ExitGameAction : ActionBase
    {
        public ExitGameAction(Game game) : base(game)
        {
        }

        public override string Name => "Exit game";
        public override string Description => "Exits the game";

        public override IEnumerable<ActionBase> SubActions { get; }

        public override void Execute()
        {
            Environment.Exit(0);
        }
    }
}
