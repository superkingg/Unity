using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class IronBars : MonoBehaviour
{
    public float MaxY = 5.79f;
    public float MinY = 4.06f;


    // Start is called before the first frame update
    void Start()
    {
        //print(name);
    }

    // Update is called once per frame
    void Update()
    {

   
        if(Input.GetKey(KeyCode.C))
        {
            Lift();
        }
        else if (Input.GetKey(KeyCode.K))
        {   if (transform.position.y > MinY)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.01f, transform.position.z);
            }
        }

    }
    public void Lift()
    {
        if (transform.position.y < MaxY)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.01f, transform.position.z);
        }
    }


}
