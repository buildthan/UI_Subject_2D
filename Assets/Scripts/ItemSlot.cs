using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlot : MonoBehaviour
{
    public ItemData data;

    public void OnClickInventoryItemSlot()
    {
        if(data.isEquiped == true) //장비를 장착중이라면 벗고
        {
            data.isEquiped = false;
            GameManager.Instance.character.UnEquipItem(data.effect, data.type);
            this.transform.GetChild(1).gameObject.SetActive(false);
        }else if(data.isEquiped == false) //장비를 벗고있으면 장착
        {
            data.isEquiped= true;
            GameManager.Instance.character.EquipItem(data.effect, data.type);
            this.transform.GetChild(1).gameObject.SetActive(true);

        }
    }
}
