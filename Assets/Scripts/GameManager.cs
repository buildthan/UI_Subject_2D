using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager instance;

    public Character character;
    public static GameManager Instance
    {
        get
        {
            if (null == instance) //½Ì±ÛÅæ ¼±¾ð °úÁ¤
            {
                return null;
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null) //½Ì±ÛÅæ ¼±¾ð °úÁ¤
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if (instance != this)
                Destroy(this.gameObject);
        }
    }
}
