
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    [SerializeField] 
    private SaveWallet saveWallet;
    public List<KeyValueProp> keyValue = new List<KeyValueProp>();
    public Wallet(int value, string walletTypeCoin)
    {

    }
}