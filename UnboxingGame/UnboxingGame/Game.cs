using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboxingGame.Actions;

namespace UnboxingGame
{
    public class Game : ActionBase
    {
        public Game(GameStorage storage) : base(null)
        {
            this.Storage = storage ?? throw new ArgumentNullException(nameof(storage));
            SubActions = new ActionBase[] { new WorkAction(this) };

        }

        public override IEnumerable<ActionBase> SubActions { get; }

        public override string Name => "Game";
        public override string Description => "Game";

        public Player Player { get; private set; }
        public GameStorage Storage { get; }

        public override void Execute()
        {
            Console.Write("Before starting the game please type in your player name: ");
            var userInput = Console.ReadLine();
            Player = new Player(userInput);

            if (Player.PlayerName.Equals("maaz", StringComparison.InvariantCultureIgnoreCase))
            {
                Player.PlayerBalance = 500000;
            }
            Console.Clear();
            Console.WriteLine($"Welcome {Player.PlayerName}, please choose what you want to do:");
            Console.WriteLine($"Balance: {Player.PlayerBalance}");

            DisplayAlternatives();
        }

    }
}
