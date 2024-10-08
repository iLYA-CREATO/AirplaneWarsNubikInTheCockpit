using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Respawn : MonoBehaviour
{
    public GameObject player;
    
    public Transform respawnPoint;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            player.SetActive(false);
            player.transform.position = respawnPoint.position;
            player.transform.Rotate(new Vector3(0f, 90f, 0f));
            player.SetActive(true);
        }
    }
}
