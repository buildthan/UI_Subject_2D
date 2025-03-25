using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : BaseUI
{
    protected override UIState GetUIState()
    {
        return UIState.Inventory;
    }

    public override void Init(UIManager uiManager)
    {
        base.Init(uiManager);
    }
}
