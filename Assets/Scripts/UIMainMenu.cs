using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainMenu : BaseUI
{
    protected override UIState GetUIState()
    {
        return UIState.MainMenu;
    }

    public override void Init(UIManager uiManager)
    {
        base.Init(uiManager);
    }
}
