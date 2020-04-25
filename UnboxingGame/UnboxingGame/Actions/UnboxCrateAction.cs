using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnboxingGame.Actions
{
    public class UnboxCrateAction : ActionBase
    {
        public UnboxCrateAction(Game game) : base(game)
        {
        }

        public override string Name => "Unbox crate";
        public override string Description => "Unboxes a crate!";

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
