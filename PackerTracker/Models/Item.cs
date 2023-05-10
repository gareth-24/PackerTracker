using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
    public string ItemName { get; set; }
    public bool PackedStatus { get; set; }

    private static List<Item> _instances = new List<Item> {};

    public Item(string itemName, bool packedStatus)
    {
      ItemName = itemName;
      PackedStatus = packedStatus;
      _instances.Add(this);
    }
  }
}