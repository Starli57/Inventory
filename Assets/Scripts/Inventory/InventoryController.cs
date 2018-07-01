using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

namespace Inventory
{
    public class InventoryController : Singleton<InventoryController>
    {
        [SerializeField]
        private InventoryView _view;

        public void Initialize(InventoryItem userWeapon, InventoryItem userDefenseItem, List<InventoryItem> bagItems)
        {
            _view.Initialize(userWeapon, userDefenseItem, _model.bagSlotsCount, bagItems);
        }


        private InventoryModel _model = new InventoryModel();

    }
}