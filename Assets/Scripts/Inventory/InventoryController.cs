using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Utils;

namespace Inventory
{
    public class InventoryController : Singleton<InventoryController>
    {
        public Action<int> onWeaponChanged;
        public Action<int> onDefenseItemChanged;

        [SerializeField]
        private InventoryView _view;

        [SerializeField]
        private BagView _bagView;

        public void Initialize(InventoryItem userWeapon, InventoryItem userDefenseItem, List<InventoryItem> bagItems)
        {
            _bagController.SetupDependeses(_bagView);
            _bagController.Initialize();
            _bagController.AddItems(bagItems);

            _view.Initialize(userWeapon, userDefenseItem);
        }

        private InventoryModel _model = new InventoryModel();

        private BagController _bagController = new BagController();
    }
}