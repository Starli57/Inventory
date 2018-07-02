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

        [SerializeField]
        private StatsView _statsView;

        public void Initialize(InventoryItem userWeapon, InventoryItem userDefenseItem, 
            ulong bagSlotsCount, List<InventoryItem> bagItems)
        {
            _userItemsView.Initialize(userWeapon, userDefenseItem);
            _bagView.Initialize(bagSlotsCount, bagItems);

            _statsView.UpdatePower(userWeapon.attack);
            _statsView.UpdateDefense(userDefenseItem.def);
        }
    }
}