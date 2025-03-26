using System;
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
            if (null == instance) //싱글톤 선언 과정
            {
                return null;
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null) //싱글톤 선언 과정
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if (instance != this)
                Destroy(this.gameObject);
        }

        try //예외처리 입니다.
        {
            itemDatas = Resources.LoadAll<ItemData>("Items");
        }catch(NullReferenceException e)
        {
            Debug.Log("아이템 정보 불러오기 실패");
        }
        
        for(int i=0; i<itemDatas.Length; i++)
        {
            if(itemDatas[i].isEquiped == true) //겜 시작할 때 장착한 아이템이 있으면 미리 효과 추가
            {
                character.EquipItem(itemDatas[i].effect, itemDatas[i].type);
            }
        }

    }
}
