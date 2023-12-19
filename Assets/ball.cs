using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(0,2) == 0 ? -1 : 1;
        float y = Random.Range(0,2) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().velocity = new Vector3(speed * x, speed * y,0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -6)
        {
            transform.position = new Vector3(0, 5, 0);
        }
    }
}
