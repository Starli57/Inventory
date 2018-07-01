using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory
{
    public class InventoryView : MonoBehaviour
    {
        [SerializeField]
        private UserItemsView _userItemsView;

        [SerializeField]
        private BagView _bagView;

        public void Initialize(InventoryItem userWeapon, InventoryItem userDefenseItem, 
            ulong bagSlotsCount, List<InventoryItem> bagItems)
        {
            _userItemsView.Initialize(userWeapon, userDefenseItem);
            _bagView.Initialize(bagSlotsCount, bagItems);
        }
    }
}