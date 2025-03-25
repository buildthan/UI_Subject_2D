using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private string name; //�̸�
    public string Name { get { return name; } set { name = value; } }

    [SerializeField] private int level; //����
    public int Level { get { return level; } set { level = value; } }
    
    [SerializeField] private float curExp; //����ġ
    public float CurExp { get { return curExp; } set { curExp = value; } }
    
    [SerializeField] private float maxExp;
    public float MaxExp { get { return maxExp; } set { maxExp = value; } }

    [SerializeField] private float curHealth; //ü��
    public float CurHealth { get { return curHealth; } set { curHealth = value; } }
    
    [SerializeField] private float maxHealth;
    public float MaxHealth { get { return maxHealth; } set { maxHealth = value; } }

    [SerializeField] private float attack; //���ݷ�
    public float Attack { get { return attack; } set { attack = value; } }

    [SerializeField] private float deffense; //����
    public float Deffense { get { return deffense; } set { deffense = value; } }

    [SerializeField] private float critical; //ũ��Ƽ��
    public float Critical { get { return critical; } set { critical = value; } }

    [SerializeField] private int gold; //�������
    public int Gold { get { return gold; } set { gold = value; } }


    public void EquipItem(float effect, ItemType type) //������ ���� �ż���
    {
        if (type == ItemType.Weapon) //������ ���
        {
            Attack += effect;
        }
        else if (type == ItemType.Armor) //���� ���
        {
            Deffense += effect;
        }

    }

    public void UnEquipItem(float effect, ItemType type) //������ ���� �ż���
    {
        if (type == ItemType.Weapon) //������ ���
        {
            Attack -= effect;   
        }
        else if (type == ItemType.Armor) //���� ���
        {
            Deffense -= effect;
        }
    }
}
