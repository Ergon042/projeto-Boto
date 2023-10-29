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

    //private bool exp;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        direction = PlayerController.instance.transform.position - transform.position;
        direction.Normalize();
        direction = direction * bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = direction * bulletSpeed;
        //UpdateAnimationUpdate();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            //exp = true;
            PlayerController.instance.TakeDamage(damageAmount);

            Destroy(gameObject);
        } else if(other.tag == "Parede")
        {
            //exp = true;
            Destroy(gameObject);
        }
        
    }

//    private void UpdateAnimationUpdate()
//    {
//        if (exp == true)
//        {
//            anim.SetBool("explosao", true);
//            exp = false;
//        }        
//    }
}
