using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStatus : BaseUI
{
    protected override UIState GetUIState()
    {
        return UIState.Status;
    }

    public override void Init(UIManager uiManager)
    {
        base.Init(uiManager);
    }
}
