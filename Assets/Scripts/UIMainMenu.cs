using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : BaseUI
{
    public Button statusButton;
    public Button inventoryButton;

    protected override UIState GetUIState()
    {
        return UIState.MainMenu;
    }

    public override void Init(UIManager uiManager)
    {
        base.Init(uiManager);

        statusButton.onClick.AddListener(OnClickStatusButton);
        inventoryButton.onClick.AddListener(OnClickInventoryButton);
    }

    public void OnClickStatusButton()
    {
        uiManager.OnClickStatus();
    }

    public void OnClickInventoryButton()
    {
        uiManager.OnClickInventory();
    }

}
