using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inventory;
using System.Linq;

public class Test : MonoBehaviour
{
    [SerializeField]
    private InventoryController _inventoryController;

	private void Start()
    {
        List<InventoryItem> itemsdata = Utils.ItemsData.instance.itemsData;
        List<InventoryItem> allWeapons = itemsdata.Where(
            x=>x.itemType == InventoryItem.ItemsType.weapon).ToList();

        InventoryItem playerWeapon = allWeapons[Random.Range(0, allWeapons.Count)];
        List<InventoryItem> allDefItems = itemsdata.Where(
            x => x.itemType == InventoryItem.ItemsType.armor).ToList();

        InventoryItem playerDefItem = allDefItems[Random.Range(0, allDefItems.Count)];
        List<InventoryItem> bagsItems = itemsdata.Where(x => x != playerWeapon && x != playerDefItem).ToList();


        _inventoryController.Initialize(playerWeapon, playerDefItem, bagsItems);
    }
}
