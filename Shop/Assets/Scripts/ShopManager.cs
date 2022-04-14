using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    [SerializeField] private Text moneyText; //������ �� ��������� ������
    [SerializeField] private GameObject[] button; //������, ������ ������ ��������
    [HideInInspector] public int money = 100; //���������� �����

    private void Update()
    {
        moneyText.text = money.ToString();
        activeButton();
    }

    /// <summary>
    /// ����� ����������� (���������� �����)
    /// </summary>
    public void addItem()
    {
        moneyText.text = money.ToString();
    }

    /// <summary>
    /// ����� ����������� (���������� �����) 
    /// </summary>
    public void removeItem()
    {
        moneyText.text = money.ToString();
    }

    /// <summary>
    /// ����� ���������� ����� �� 5, ��� ������� ������ "�����"
    /// </summary>
    public void buttonClick()
    {
        money += 5;
    }

    /// <summary>
    /// ����� ��������� ������ ��������
    /// </summary>
    public void activeButton()
    {
       if (money > 200)
       {
            foreach (var item in button)
            {
                item.GetComponent<Button>().interactable = true;
            }
       }
    }
}
