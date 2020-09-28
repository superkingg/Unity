using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicCircle : MonoBehaviour
{

    public IronBars IronBars;
    public ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        print("hello world");
    }

    // Update is called once per frame
    void Update()
    {



    }

    private void OnTriggerEnter(Collider other)
    {
        if(ps!=null)
        {
            ps.Play();
            Destroy(ps.transform.parent.gameObject, 2.0f);
        }




    }


    private void OnTriggerStay(Collider other)
    {
        IronBars.SendMessage("Lift");



        //print(other.name+" is hit me");
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Collision Enter");
    }


}
