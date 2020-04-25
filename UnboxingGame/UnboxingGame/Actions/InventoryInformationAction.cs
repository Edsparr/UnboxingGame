using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnboxingGame.Actions
{
    public class InventoryInformationAction : ActionBase
    {
        public InventoryInformationAction(Game game) : base(game)
        {
        }

        public override string Name => "See Inventory";
        public override string Description => "Shows your inventory!";

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
