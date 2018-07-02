using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Utils;

namespace Inventory
{
    public class InventoryController : Singleton<InventoryController>
    {
        public Action<int> onAttackChanged;
        public Action<int> onDefenseChanged;

        [SerializeField]
        private InventoryView _view;

        public void Initialize(InventoryItem userWeapon, InventoryItem userDefenseItem, List<InventoryItem> bagItems)
        {
            _view.Initialize(userWeapon, userDefenseItem, _model.bagSlotsCount, bagItems);
        }

        private InventoryModel _model = new InventoryModel();
    }
}