using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   // public GameObject Missile;
    public Transform Tourelle;
    public Rigidbody2D rb;
    public GameObject explosion;
    public BarreDeViePlayer healthbar;
    public AudioSource Audio;
    
    


    public float vitesse = 5f;
   // public float VitesseMissile = 0f;
    private int maxhp = 70;
    public int hp;
    public float acceleration;
    public bool PlayerIsDead;

    
    Vector2 mouvements;
    

    
    
    void Start()
    {
        hp = maxhp;
        healthbar.SetMaxHpPlayer(maxhp);
        PlayerIsDead = false;
    }

    
    void FixedUpdate()
    {
        PlayerDie();
       // Mouvements();

        //MOUVEMENTS AVEC LES FLECHES OU WASD
        mouvements.x = Input.GetAxisRaw("Horizontal");
        mouvements.y = Input.GetAxisRaw("Vertical");
        rb.MovePosition(rb.position + mouvements * vitesse * Time.deltaTime);
       
//---------------------------------------------------------------------------------------------------------------------------------
        //ROTATION DU VAISSEAU AVEC LA SOURIS
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);


        
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();

        }
    }

    void Shoot()
    {
        //GameObject Bullet = (GameObject)Instantiate(Missile, Tourelle.position, Tourelle.rotation);
        GameObject Bullet = ObjectPool.instance.GetObjectInPool();

        if (Bullet!=null)
        {
            Bullet.transform.position = Tourelle.position;
            //Bullet.GetComponent<Rigidbody2D>().AddForce(Tourelle.up * VitesseMissile);
            Bullet.SetActive(true);
        }
       
        Audio.Play();
        
        
    }

  

    public void PlayerDie()
    {
        if (hp <= 0) 
        {
            // J'ai utilisé setactive car si j'utilise Destroy Le public transform du enemy n'arrive pas a trouver le plauer et le jeu crash
            // j'ai fait un if player != null pour regler le probleme mais ca ne fonctionne pas, alors setactive regle le probleme ;)

            Instantiate(explosion, transform.position, transform.rotation);
            FindObjectOfType<GameManager>().GameOver();
            gameObject.SetActive(false); 
           
            
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ennemy Bullet")
        {
            TakeDamage(8);
        }
    }


    private void TakeDamage (int damage)
    {
        hp -= damage;
        healthbar.SetHpPlayer(hp);

    }

 }

   

    
    

    

