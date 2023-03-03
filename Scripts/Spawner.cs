using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Ennemy;
    public Transform Player;
    
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;

        Instantiate(Ennemy, transform.position, transform.rotation);
    }

    
    void Update()
    {
       
    }
}
