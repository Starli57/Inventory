using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory
{
    public class BagView : MonoBehaviour
    {
        [SerializeField]
        private InventorySlot _slotPrefab;

        [SerializeField]
        private Transform _slotParent;

        public void SetupDependenses(BagModel model)
        {
            _model = model;
        }

        public void Initialize(ulong slotsCount)
        {
            for (ulong i = 0; i < slotsCount; i++) 
            {
                InventorySlot newSlot = Instantiate(_slotPrefab, _slotParent);
                _freeSlots.Add(newSlot);
            }
        }

        public void AddItems(List<InventoryItem> items)
        {
            foreach(var item in items)
            {
                FillFreeSlot(item);
            }
        }

        private BagModel _model;

        private List<InventorySlot> _freeSlots = new List<InventorySlot>();
        private List<InventorySlot> _filledSlots = new List<InventorySlot>();

        private bool FillFreeSlot(InventoryItem item)
        {
            if (_freeSlots.Count == 0)
            {
                Debug.LogError("[BagView] Havent free slot");
                return false;
            }

            InventorySlot itemSlot = _freeSlots[0];
            itemSlot.Initialize(item);

            _freeSlots.Remove(itemSlot);
            _filledSlots.Add(itemSlot);

            return true;
        }
    }
}