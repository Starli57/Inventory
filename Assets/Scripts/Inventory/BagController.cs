using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory
{
    public class BagController
    {
        public void SetupDependeses(BagView view)
        {
            _view = view;
        }

        public void Initialize()
        {
            _view.SetupDependenses(_model);
            _view.Initialize(_model.maxItems);
        }

        public void AddItems(List<InventoryItem> items)
        {
            if (_model.itemsInBag.Count + items.Count > _model.maxItems)
            {
                Debug.LogError("[BagModel] Free slots in bag less than items.count");
                return;
            }

            _model.itemsInBag.AddRange(items);
            _view.AddItems(items);
        }

        private BagModel _model = new BagModel();
        private BagView _view;
    }
}