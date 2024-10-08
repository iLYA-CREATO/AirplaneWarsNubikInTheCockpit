using UnityEngine;

public class ProfilePlayer : MonoBehaviour
{
    [Header("Иконка игрока")]
    public Sprite iconPlayer; 
    [Header("Кол-во боёв")]
    public int fightValue;
    [Header("Кол-во побед")]
    public int fightValueWin;
    [Header("Кол-во поражений")]
    public int fightValueDefeat;
    [Header("Процент побед")]
    public float winRate;
}