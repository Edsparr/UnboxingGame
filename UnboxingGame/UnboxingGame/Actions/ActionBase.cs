using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnboxingGame.Actions
{
    public abstract class ActionBase
    {
        protected ActionBase(Game game)
        {
            this.Game = game;
        }

        public Game Game { get; }

        public abstract string Name { get; }
   
        public abstract string Description { get; }

        public abstract IEnumerable<ActionBase> SubActions { get; }

        public abstract void Execute();

        public void DisplayAlternatives()
        {
            while (true)
            {
                for (int i = 0; i < SubActions.Count(); i++)
                {
                    var currentAction = SubActions.ElementAt(i);
                    Console.WriteLine($"{i + 1}. {currentAction.Description}");
                }

                Console.Write("Choose your option: ");
                string userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out int option) || option <= 0 || option > SubActions.Count())
                {
                    Console.WriteLine($"{userInput} is not a valid input!");
                    continue;
                }

                var action = SubActions.ElementAt(option - 1);

                action.Execute(); //Action already knows about game which knows about Player so no need to pass it.
            }
        }
    }
}
