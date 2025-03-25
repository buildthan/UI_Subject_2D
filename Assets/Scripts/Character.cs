using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private string name; //이름
    public string Name { get { return name; } set { name = value; } }

    [SerializeField] private int level; //레벨
    public int Level { get { return level; } set { level = value; } }
    
    [SerializeField] private float curExp; //경험치
    public float CurExp { get { return curExp; } set { curExp = value; } }
    
    [SerializeField] private float maxExp;
    public float MaxExp { get { return maxExp; } set { maxExp = value; } }

    [SerializeField] private float curHealth; //체력
    public float CurHealth { get { return curHealth; } set { curHealth = value; } }
    
    [SerializeField] private float maxHealth;
    public float MaxHealth { get { return maxHealth; } set { maxHealth = value; } }

    [SerializeField] private float attack; //공격력
    public float Attack { get { return attack; } set { attack = value; } }

    [SerializeField] private float deffense; //방어력
    public float Deffense { get { return deffense; } set { deffense = value; } }

    [SerializeField] private float critical; //크리티컬
    public float Critical { get { return critical; } set { critical = value; } }

    [SerializeField] private int gold; //소지골드
    public int Gold { get { return gold; } set { gold = value; } }


    public void EquipItem(float effect, ItemType type) //아이템 장착 매서드
    {
        if (type == ItemType.Weapon) //무기일 경우
        {
            Attack += effect;
        }
        else if (type == ItemType.Armor) //방어구일 경우
        {
            Deffense += effect;
        }

    }

    public void UnEquipItem(float effect, ItemType type) //아이템 해제 매서드
    {
        if (type == ItemType.Weapon) //무기일 경우
        {
            Attack -= effect;   
        }
        else if (type == ItemType.Armor) //방어구일 경우
        {
            Deffense -= effect;
        }
    }
}
