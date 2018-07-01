using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using Inventory;

namespace Utils
{
    public class ItemsData : ScriptableObject
    {
        public List<InventoryItem> itemsData = new List<InventoryItem>();

        public static ItemsData instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = Resources.Load("ItemsData") as ItemsData;
                }

                return _instance;
            }
        }

        [ContextMenu("AddRandomItems")]
        public void AddRandomItems()
        {
            const int itemsCount = 10;
            ulong maxId = itemsData.Count > 0 ? itemsData.Max(x => x.id) : 0;

            for (int i = 0; i < itemsCount; i++)
            {
                InventoryItem newItem = new InventoryItem();

                ulong newId = maxId + 1;
                maxId = newId;

                newItem.id = newId;
                newItem.itemType = (InventoryItem.ItemsType)UnityEngine.Random.Range(0, 2);

                newItem.attack = newItem.itemType == InventoryItem.ItemsType.weapon ?
                    UnityEngine.Random.Range(0, 100) : 0;

                newItem.def = newItem.itemType == InventoryItem.ItemsType.armor ?
                    UnityEngine.Random.Range(0, 10) : 0;

                itemsData.Add(newItem);
            }
        }

        private static ItemsData _instance;
    }
}