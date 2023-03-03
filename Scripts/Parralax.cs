using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parralax : MonoBehaviour
{

    Vector3 position;
    public float défilement = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        position = Camera.main.transform.position * défilement;
        position.z = transform.position.z;
        transform.position = position;
    }
}
