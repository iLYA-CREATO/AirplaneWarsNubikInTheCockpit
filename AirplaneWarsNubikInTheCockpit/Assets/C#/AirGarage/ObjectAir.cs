using UnityEngine;

public class ObjectAir : ScriptableObject
{
    [Header("Прфаб самолёта")]
    public GameObject air;
    [Header("Название самолёта")]
    public string nameAir;
    [Header("Скорость самолёта")]
    public float speed;
    [Header("Стоимость самолёта")]
    public int price;
    [Header("Опыт для открытия самолёта")]
    public int experience; // Нужное кол-во опыта для прокачки
}
