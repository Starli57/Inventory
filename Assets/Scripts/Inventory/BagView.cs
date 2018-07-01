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

        public void Initialize(ulong slotsCount, List<InventoryItem> items)
        {
            for (ulong i = 0; i < slotsCount; i++) 
            {
                InventorySlot newSlot = Instantiate(_slotPrefab, _slotParent);
                _freeSlots.Add(newSlot);
            }

            foreach (var item in items)
                FillFreeSlot(item);
        }

        private List<InventorySlot> _freeSlots = new List<InventorySlot>();
        private List<InventorySlot> _filledSlots = new List<InventorySlot>();

        private bool FillFreeSlot(InventoryItem item)
        {
            if (_freeSlots.Count == 0)
            {
                Debug.LogError("Havent free slot");
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