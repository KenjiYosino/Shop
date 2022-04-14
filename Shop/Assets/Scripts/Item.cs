using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private int cost; //���� ������
    [SerializeField] private int col; //���������� ��������� ��������
    [SerializeField] private GameObject buttonToSell; //������ �� ������ �������

    /// <summary>
    /// ����� ������� ������
    /// </summary>
    public void buy()
    {
        if (GetComponentInParent<ShopManager>().money >= cost)
        {
            GetComponentInParent<ShopManager>().money -= cost;
            col += 1;
            buttonToSell.SetActive(true);
        }
    }

    /// <summary>
    /// ����� ������� ������ 
    /// </summary>
    public void ToSell()
    {
        GetComponentInParent<ShopManager>().money += (cost/2);
        GetComponentInParent<ShopManager>().removeItem();
        col -= 1;
        if (col <= 0)
        {
            buttonToSell.SetActive(false);
        }
    }

}
