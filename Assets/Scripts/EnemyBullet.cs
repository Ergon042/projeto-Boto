using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public int damageAmount;

    public float bulletSpeed = 5f;

    public Rigidbody2D theRB;

    private Vector3 direction;

    private Animator anim;

    private int exp;

    // Start is called before the first frame update
   private void Start()
    { 
        anim = GetComponent<Animator>();
        direction = PlayerController.instance.transform.position - transform.position;
        direction.Normalize();
        direction = direction * bulletSpeed;
    }

    // Update is called once per frame
   private void Update()
    {
        UAS(0);
        theRB.velocity = direction * bulletSpeed;
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            UAS(1);
            PlayerController.instance.TakeDamage(damageAmount);

            Destroy(gameObject);
        } else if(other.tag == "Parede")
        {

            UAS(1);
            Destroy(gameObject);
        }
        
    }

    private void UAS(int exp)
    {
        
        if (exp == 1)
        {
            Debug.Log("batata");
            anim.SetBool("expo", true);
            
        }        
    }
}
