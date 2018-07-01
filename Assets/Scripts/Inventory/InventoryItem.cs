using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Inventory
{
    [Serializable]
    public class InventoryItem
    {
        public enum ItemsType { weapon = 0, armor = 1 }

        public ulong id;

        public ItemsType itemType;

        public int attack;
        public int def;

        public Sprite sprite;
    }
}