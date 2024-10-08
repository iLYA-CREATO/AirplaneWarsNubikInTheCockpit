using UnityEngine;

public class Health : MonoBehaviour
{
    private int health;


    private void Start()
    {
        health = 100;
    }

    // Свойство для доступа к здоровью
    public int HealthValue
    {
        get => health; // Возвращаем текущее значение здоровья
        set
        {
            // Устанавливаем новое значение здоровья
            if (value > 0)
            {
                health = Mathf.Max(health - value, 0); // Уменьшаем здоровье, не позволяя ему быть отрицательным
            }
        }
    }
}