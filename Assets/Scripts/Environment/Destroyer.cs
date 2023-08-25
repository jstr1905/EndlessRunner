using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public string parentName;
    
    void Start()
    {
        parentName = transform.name;
        StartCoroutine(DestroyClone());


    }

    IEnumerator DestroyClone()
    {
        yield return new WaitForSeconds(50);
        if (parentName=="Section(Clone)")
        {
            Destroy(gameObject);
        }
    }
}


