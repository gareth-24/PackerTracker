using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
    public string ItemName { get; set; }
    public bool PurchasedStatus { get; set;}
    public bool PackedStatus { get; set; }
    public int Cost { get; set; }
    public int Weight { get; set; }
    public int Id { get; }

    private static List<Item> _instances = new List<Item> {};

    public Item(string itemName, string purchasedStatus, string packedStatus, int cost, int weight)
    {
      ItemName = itemName;

      if (purchasedStatus == "True")
      {
        PurchasedStatus = true;
      }
      else if (purchasedStatus == "False")
      {
        PurchasedStatus = false;
      }

      if (packedStatus == "True")
      {
        PackedStatus = true;
      }
      else if (packedStatus == "False")
      {
        PackedStatus = false;
      }

      Cost = cost;
      Weight = weight;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public Item(string itemName, string packedStatus)
    {
      ItemName = itemName;
      // PurchasedStatus = false;
      if (packedStatus == "True")
      {
        PackedStatus = true;
      }
      else if (packedStatus == "False")
      {
        PackedStatus = false;
      }

      Cost = 0;
      Weight = 0;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }    

    public void MarkItemAsPacked()
    {
      this.PackedStatus = true;
    }
  }
}