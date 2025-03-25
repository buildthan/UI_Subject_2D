using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlot : MonoBehaviour
{
    public ItemData data;

    public void OnClickInventoryItemSlot()
    {
        if(data.isEquiped == true) //��� �������̶�� ����
        {
            data.isEquiped = false;
            GameManager.Instance.character.UnEquipItem(data.effect, data.type);
            this.transform.GetChild(1).gameObject.SetActive(false);
        }else if(data.isEquiped == false) //��� ���������� ����
        {
            data.isEquiped= true;
            GameManager.Instance.character.EquipItem(data.effect, data.type);
            this.transform.GetChild(1).gameObject.SetActive(true);

        }
    }
}
