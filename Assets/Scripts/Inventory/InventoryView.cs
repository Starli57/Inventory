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
        private StatsPrinter _statsPrinter;

        public void Initialize(InventoryItem userWeapon, InventoryItem userDefenseItem)
        {
            _userItemsView.Initialize(userWeapon, userDefenseItem);

            _statsPrinter.UpdatePower(userWeapon.attack);
            _statsPrinter.UpdateDefense(userDefenseItem.def);
        }
    }
}