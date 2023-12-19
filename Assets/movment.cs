using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody myRigiBody;
    // Start is called before the first frame update
    void Start()
    {
        myRigiBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigiBody.AddForce(new Vector3(80, 0, 0));

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigiBody.AddForce(new Vector3(-80, 0, 0));

        }

        }

    }
