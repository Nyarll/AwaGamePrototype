using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public GameObject playerObject;

    Vector3 respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = playerObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerObject.activeSelf == false)
        {
            playerObject.transform.position = respawnPoint;
            playerObject.SetActive(true);
        }
    }
}
