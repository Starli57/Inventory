using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Inventory
{
    public class UserItemsView : MonoBehaviour
    {
        [SerializeField]
        private InventorySlot _weaponSlot;

        [SerializeField]
        private InventorySlot _defenseSlot;

        public void Initialize(InventoryItem weapon, InventoryItem defenseItem)
        {
            _weaponSlot.Initialize(weapon);
            _defenseSlot.Initialize(defenseItem);
        }
    }
}