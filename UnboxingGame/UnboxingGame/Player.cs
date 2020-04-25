using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnboxingGame
{
    public class Player
    {
        public const int InventorySize = 5;

        public Player(string playerName, decimal balance = 500)
        {
            if (string.IsNullOrWhiteSpace(playerName))
                throw new ArgumentException(nameof(playerName));
            this.PlayerName = playerName;
            this.PlayerBalance = balance;
        }
        public string PlayerName { get; set; }
        public decimal PlayerBalance { get; set; }
        
        public ICollection<Item> Inventory { get; } = new List<Item>();

        public void AddInventoryItem(Item item)
        {
            if (Inventory.Count >= InventorySize)
                throw new InvalidOperationException("Inventory full!");
            Inventory.Add(item);
            Console.WriteLine("Your inventory is full, can't hold more items.");
        }

        public string ListInventory()
        {
            StringBuilder sb = new StringBuilder();
            if (inventorySlot1 == null)
            {
                sb.AppendLine("Slot 1: None");
            } else
            {
                sb.AppendLine($"Slot 1: {this.inventorySlot1.itemName}");
            }

            if (inventorySlot2 == null)
            {
                sb.AppendLine("Slot 2: None");
            }
            else
            {
                sb.AppendLine($"Slot 2: {this.inventorySlot2.itemName}");
            }

            if (inventorySlot3 == null)
            {
                sb.AppendLine("Slot 3: None");
            }
            else
            {
                sb.AppendLine($"Slot 3: {this.inventorySlot3.itemName}");
            }

            if (inventorySlot4 == null)
            {
                sb.AppendLine("Slot 4: None");
            }
            else
            {
                sb.AppendLine($"Slot 4: {this.inventorySlot4.itemName}");
            }

            if (inventorySlot5 == null)
            {
                sb.AppendLine("Slot 5: None");
            }
            else
            {
                sb.AppendLine($"Slot 5: {this.inventorySlot5.itemName}");
            }

            return sb.ToString();
        }
    }
}
