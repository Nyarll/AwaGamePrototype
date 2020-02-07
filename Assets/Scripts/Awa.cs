using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awa : MonoBehaviour
{
    public float lifeTime = 2.0f;
    public float deathPosition = 5.0f;
    public float speed = 0.1f;

    float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time > lifeTime || transform.position.y > deathPosition)
        {
            Destroy(gameObject);
        }

        time += Time.deltaTime;

        transform.position += new Vector3(0, speed, 0);

    }
}
