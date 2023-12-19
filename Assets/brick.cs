using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter( )
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
       

    }
}
