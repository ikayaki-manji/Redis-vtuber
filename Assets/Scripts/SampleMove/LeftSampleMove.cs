using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSampleMove : MonoBehaviour
{
    private Vector3 firstPosition;
    private float time = 0;
    [SerializeField]
    private float radius = 1;

    private void Start()
    {
        firstPosition = gameObject.transform.position;
    }

    void Update()
    {
        time += Time.deltaTime;
        gameObject.transform.position = new Vector3(Mathf.Sin(time), Mathf.Cos(time), 0) * radius + firstPosition;
    }
}
