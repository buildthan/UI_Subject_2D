using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : BaseUI
{
    public Button mainMenuButton;
    public GameObject[] items;
    public GameObject itemSlotPrefab;

    protected override UIState GetUIState()
    {
        return UIState.Inventory;
    }

    public override void Init(UIManager uiManager)
    {
        base.Init(uiManager);

        mainMenuButton.onClick.AddListener(OnClickMainMenuButton);

        items = new GameObject[GameManager.Instance.itemDatas.Count()]; //������ �����͸� �޾ƿ� ����
        for(int i = 0; i< items.Length; i++)
        {
            items[i] = Instantiate(itemSlotPrefab, this.transform.GetChild(0).GetChild(1).GetChild(0).GetChild(0));
            items[i].GetComponent<ItemSlot>().data = GameManager.Instance.itemDatas[i]; //������ ���� ��ũ��Ʈ�� ������ ���� ����
            //�̶� ���� ��ũ��Ʈ���� ������ �����Ϳ� ��ȭ�� �ָ� �������� ������ ��. �ּҸ� �Űܰ��� �����ΰ���.
            items[i].transform.GetChild(0).GetComponent<Image>().sprite =
                GameManager.Instance.itemDatas[i].icon;
            GameManager.Instance.itemDatas[i].inventoryIndex = i; //�ε��� ���Կ�
        }

        UpdateInventory(); //�κ��丮 ������ �������θ� ������

    }

    public void UpdateInventory()
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (GameManager.Instance.itemDatas[i].isEquiped == true) //�������� ������ ���
            {
                items[i].transform.GetChild(1).gameObject.SetActive(true);
            }
            else //�������� ���� ���
            {
                items[i].transform.GetChild(1).gameObject.SetActive(false);
            }
        }
    }

    public void OnClickMainMenuButton()
    {
        uiManager.OnClickMainMenu();
    }

}
