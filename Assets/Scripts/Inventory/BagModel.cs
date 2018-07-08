using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory
{
    public class BagModel
    {
        public uint maxItems = 20;

        public List<InventoryItem> itemsInBag = new List<InventoryItem>();
    }
}