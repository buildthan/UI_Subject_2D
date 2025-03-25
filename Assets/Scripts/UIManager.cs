using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum UIState
{
    MainMenu,
    Status,
    Inventory
}

public class UIManager : MonoBehaviour
{
    UIState currentState = UIState.MainMenu;

    UIMainMenu mainMenuUI = null;
    UIStatus statusUI = null;
    UIInventory inventoryUI = null;

    static UIManager instance;

    public TextMeshProUGUI characterName;
    public TextMeshProUGUI characterLevel;
    public TextMeshProUGUI characterGold;
    public TextMeshProUGUI characterExp;
    public Image characterExpImage;


    public static UIManager Instance //�̱��� ����
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }

    private void Awake() //�̱��� ����
    {


        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if (instance != this)
                Destroy(this.gameObject);
        }


        mainMenuUI = GetComponentInChildren<UIMainMenu>(true);
        mainMenuUI?.Init(this);
        statusUI = GetComponentInChildren<UIStatus>(true);
        statusUI?.Init(this);
        inventoryUI = GetComponentInChildren<UIInventory>(true);
        inventoryUI?.Init(this);


        ChangeState(UIState.MainMenu);
    }

    public void FixedUpdate()
    {
        characterName.text = GameManager.Instance.character.Name;
        characterLevel.text = $"Lv. {GameManager.Instance.character.Level}";
        characterExp.text = $"{GameManager.Instance.character.CurExp}/{GameManager.Instance.character.MaxExp}";
        characterExpImage.fillAmount = GameManager.Instance.character.CurExp/GameManager.Instance.character.MaxExp;
        characterGold.text = $"{GameManager.Instance.character.Gold}";
}


    public void ChangeState(UIState state) //UI������Ʈ�� on off ���ִ� ���
    {
        currentState = state; //�Ʒ����� �ش��ϴ� UI������Ʈ�� ã�� on off ����
        mainMenuUI?.SetActive(currentState);
        statusUI?.SetActive(currentState);
        inventoryUI?.SetActive(currentState);

    }

    //MainMenu ����

    public void OnClickStatus()
    {
        ChangeState(UIState.Status);
    }

    public void OnClickInventory()
    {
        ChangeState(UIState.Inventory);
    }

    //Status ����

    public void OnClickMainMenu()
    {
        ChangeState(UIState.MainMenu);
    }

}


