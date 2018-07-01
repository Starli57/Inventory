using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Inventory
{
    public class InventorySlot : MonoBehaviour
    {
        public Action<ulong> onPressed;

        public ulong itemId { get; private set; }

        
        public void Initialize(InventoryItem item)
        {
            itemId = item != null ? item.id : 0;
            _img.sprite = item != null ? item.sprite : _defaultSprite;
        }

        public void OnButtonPressed()
        {
            if (onPressed != null && itemId > 0)
                onPressed(itemId);
        }

        private Sprite _defaultSprite;
        private Image _img;

        private void Awake()
        {
            _img = GetComponent<Image>();

            if (_img == null)
                _img = gameObject.AddComponent<Image>();

            _defaultSprite = _img.sprite;
        }
    }
}
