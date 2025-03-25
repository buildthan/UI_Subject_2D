using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : BaseUI
{
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI deffenseText;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI criticalText;

    public Button MainMenuButton;

    protected override UIState GetUIState()
    {
        return UIState.Status;
    }

    public override void Init(UIManager uiManager)
    {
        base.Init(uiManager);

        MainMenuButton.onClick.AddListener(OnClickMainMenuButton);
    }

    public void FixedUpdate()
    {
        attackText.text = $"Attack : {GameManager.Instance.character.Attack}";
        deffenseText.text = $"Deffense : {GameManager.Instance.character.Deffense}";
        healthText.text = $"Health : {GameManager.Instance.character.CurHealth}";
        criticalText.text = $"Critical : {GameManager.Instance.character.Critical}";
    }

    public void OnClickMainMenuButton()
    {
        uiManager.OnClickMainMenu();
    }

}
