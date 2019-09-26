using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private GameObject currentPlayer;
    public GameObject playerPrefab;
    public GameObject respawnPoint;


    void Start()
    {
        currentPlayer = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (currentPlayer == null)
        {
            Instantiate(playerPrefab, respawnPoint.transform.position, respawnPoint.transform.rotation);
            currentPlayer = GameObject.FindGameObjectWithTag("Player");
            Toolbox.GetInstance().GetPlayerManager().TotalDeaths();

            Debug.Log("Player was killed!");
        }
    }
}
