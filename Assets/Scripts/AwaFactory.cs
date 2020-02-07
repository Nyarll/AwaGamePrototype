using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwaFactory : MonoBehaviour
{
    public GameObject awaObject;
    public GameObject deathAwaObject;

    public float generateTime = 2.0f;

    public float awaDeathPosition = 10.0f;

    float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time > generateTime)
        {
            time = 0;
            GameObject obj;
            int r = Random.Range(0, 3);
            if (r != 0)
            {
                obj = Instantiate(awaObject) as GameObject;
            }
            else
            {
                obj = Instantiate(deathAwaObject) as GameObject;
            }
            obj.transform.position = new Vector3(transform.position.x, transform.position.y, 0);

            obj.GetComponent<Awa>().deathPosition = awaDeathPosition;
        }

        time += Time.deltaTime;
    }
}
