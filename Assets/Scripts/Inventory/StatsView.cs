using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Inventory
{
    public class StatsView : MonoBehaviour
    {
        [SerializeField]
        private Text _powerText;

        [SerializeField]
        private Text _defenseText;

        public void SubscribeStatsEvents(Action<int> powerChanged, Action<int> defenseChanged)
        {
            powerChanged += UpdatePower;
            defenseChanged += UpdateDefense;
        }

        public void UnSubscribeStatsEvents(Action<int> powerChanged, Action<int> defenseChanged)
        {
            powerChanged -= UpdatePower;
            defenseChanged -= UpdateDefense;
        }

        public void UpdatePower(int power)
        {
            _powerText.text = "Power: " + power;
        }

        public void UpdateDefense(int defense)
        {
            _defenseText.text = "Defense: " + defense;
        }
    }
}