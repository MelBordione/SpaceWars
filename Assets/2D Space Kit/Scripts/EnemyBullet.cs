using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float vitesse;

    private Transform player;
    public GameObject impacte;

    private Vector2 cible;
    
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        cible = new Vector2(player.position.x, player.position.y);

        StartCoroutine(DestroyBullet());
    }

    
    void Update()
    {
        
        transform.position += transform.up * vitesse * Time.deltaTime;

      


    }

    IEnumerator DestroyBullet() //Fred m'a aidé pour cette partie du code
    {
        yield return new WaitForSeconds(7);
        Destroy(gameObject);
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == ("Player"))
        {
            Instantiate(impacte, transform.position, transform.rotation);
            DestroyProjectile();
        }

        if (collision.collider.tag == "Asteroide")
        {
            Instantiate(impacte, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
