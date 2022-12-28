using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class villageTeleport : MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameController.currentMap == PlayerMap.Village)
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.position = new Vector3(-27.98f, 17.7f, 0f);
                GameController.currentMap = PlayerMap.Village1;
            }
        }
    }
    
}
