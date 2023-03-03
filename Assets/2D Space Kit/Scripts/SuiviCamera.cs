using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuiviCamera : MonoBehaviour
{

    public Transform player;
    Vector3 position;
    
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // transform.position = new Vector3(player.transform.position.x, player.transform.position. y, transform.position.z);
        position = player.position;
        position.z = transform.position.z;
        transform.position = Vector3.Lerp(transform.position, position, Time.deltaTime);

    }
}
