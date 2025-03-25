using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager instance;

    public Character character;

    public ItemData[] itemDatas;
    public static GameManager Instance
    {
        get
        {
            if (null == instance) //�̱��� ���� ����
            {
                return null;
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null) //�̱��� ���� ����
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if (instance != this)
                Destroy(this.gameObject);
        }

        itemDatas = Resources.LoadAll<ItemData>("Items");
        
        for(int i=0; i<itemDatas.Length; i++)
        {
            if(itemDatas[i].isEquiped == true) //�� ������ �� ������ �������� ������ �̸� ȿ�� �߰�
            {
                character.EquipItem(itemDatas[i].effect, itemDatas[i].type);
            }
        }

    }
}
