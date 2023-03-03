using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject missiles;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject bullet = (GameObject)Instantiate(missiles);
            bullet.transform.position = mousePos;
        }
    }
}
