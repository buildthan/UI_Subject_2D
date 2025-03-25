using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : BaseUI
{
    public Button mainMenuButton;

    protected override UIState GetUIState()
    {
        return UIState.Inventory;
    }

    public override void Init(UIManager uiManager)
    {
        base.Init(uiManager);
    }
}
