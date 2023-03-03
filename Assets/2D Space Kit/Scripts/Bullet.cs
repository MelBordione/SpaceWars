using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public GameObject impacte;
    public float speed = 24f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = gameObject.AddComponent<Rigidbody2D>();
        StartCoroutine(DestroyBullet());
    }

    private void FixedUpdate()
    {
        rb.AddForce(transform.up * speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Asteroide")
        {

            gameObject.SetActive(false);
        }

        if(collision.collider.tag == "Ennemie")
        {
            Instantiate(impacte, transform.position, transform.rotation);
            gameObject.SetActive(false);
        }

        
        
    }

    IEnumerator DestroyBullet() //Fred m'a aidé pour cette partie du code
    {
        yield return new WaitForSeconds(7);
        Destroy(gameObject);
    }






}
