using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltManager : MonoBehaviour
{
    public GameObject belt;
    public Rigidbody tool;

    void Start()
    {
        //Find();
        tool = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Find()
    {
        Transform result;
        for (int i = 0; i < 4; i++)
        {
            string spc;
            spc = "Space" + i.ToString();
            result = gameObject.transform.Find(spc);
            if (result)
            {
                Debug.Log("Se encontro: " + spc);
            }
            else
            {
                Debug.Log("No se encontro: " + spc);
            }
        }
    }
    void OnCollisionEnter(Collision otherObj)
    {
        if(otherObj.gameObject.tag == "Space")
        {
            tool.isKinematic = true;

        }

    }
    void OnCollisionExit(Collision otherObj)
    {
        if(otherObj.gameObject.tag == "Space")
        {
            tool.isKinematic = false;
        }
    }
    
}
