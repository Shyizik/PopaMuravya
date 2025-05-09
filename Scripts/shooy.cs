using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooy : MonoBehaviour
{
    public Transform shotpos;
    public GameObject star;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(star, shotpos.transform.position, transform.rotation);
        }
    }
}
