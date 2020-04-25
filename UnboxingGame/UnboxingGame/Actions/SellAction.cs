using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnboxingGame.Actions
{
    public class SellAction : ActionBase
    {
        public SellAction(Game game) : base(game)
        {
        }

        public override string Name => "Sell";
        public override string Description => "Sells an item in your  inventory!";

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
