using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnboxingGame.Actions
{
    public class WorkAction : ActionBase
    {
        public WorkAction(Game game) : base(game)
        {

        }

        public override string Name => "Work";

        public override string Description => "Work!";

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
