using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadSampleMove : MonoBehaviour
{
    [SerializeField]
    private Vector3 rotation; 

    void Update()
    {
        gameObject.transform.Rotate(rotation);
    }
}
