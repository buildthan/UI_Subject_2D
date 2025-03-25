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

        items = new GameObject[GameManager.Instance.itemDatas.Count()]; //아이템 데이터를 받아와 생성
        for(int i = 0; i< items.Length; i++)
        {
            items[i] = Instantiate(itemSlotPrefab, this.transform.GetChild(0).GetChild(1).GetChild(0).GetChild(0));
            items[i].GetComponent<ItemSlot>().data = GameManager.Instance.itemDatas[i]; //아이템 슬롯 스크립트에 아이템 정보 삽입
            //이때 슬롯 스크립트에서 아이템 데이터에 변화를 주면 원본에도 영향을 줌. 주소만 옮겨가는 형식인거임.
            items[i].transform.GetChild(0).GetComponent<Image>().sprite =
                GameManager.Instance.itemDatas[i].icon;
            GameManager.Instance.itemDatas[i].inventoryIndex = i; //인덱스 삽입용
        }

        UpdateInventory(); //인벤토리 아이템 장착여부를 따져줌

    }

    public void UpdateInventory()
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (GameManager.Instance.itemDatas[i].isEquiped == true) //아이템을 장착한 경우
            {
                items[i].transform.GetChild(1).gameObject.SetActive(true);
            }
            else //장착하지 않은 경우
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
