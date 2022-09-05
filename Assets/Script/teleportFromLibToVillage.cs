using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teleportFromLibToVillage : MonoBehaviour
{

    private GameObject player;
    public GameObject tpPanel;
    public Text loading;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tpPanel.SetActive(true);
            StartCoroutine(removeLoadingPanel());
            player.transform.position = new Vector3(-37.66f, 2.44f, 0f);
            GameController.currentMap = PlayerMap.Village;
        }
    }

    IEnumerator removeLoadingPanel()
    {
        yield return new WaitForSeconds(1f);
        loading.text = "LOADING";
        tpPanel.SetActive(false);
        GameController.quitLibrary = true;
    }
}
