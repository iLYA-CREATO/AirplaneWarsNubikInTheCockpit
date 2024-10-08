using UnityEngine;

public class Health : MonoBehaviour
{
    private int health;


    private void Start()
    {
        health = 100;
    }

    // �������� ��� ������� � ��������
    public int HealthValue
    {
        get => health; // ���������� ������� �������� ��������
        set
        {
            // ������������� ����� �������� ��������
            if (value > 0)
            {
                health = Mathf.Max(health - value, 0); // ��������� ��������, �� �������� ��� ���� �������������
            }
        }
    }
}