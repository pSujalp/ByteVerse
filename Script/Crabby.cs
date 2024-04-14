using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crabby : MonoBehaviour
{
     [SerializeField] private Transform player; // Reference to the player GameObject
    public float chaseRange = 10f; // Distance at which the enemy starts chasing the player
    public float moveSpeed = 5f; // Speed at which the enemy moves towards the player

    [SerializeField] private float health;

    [SerializeField] float bounceforce;

    private Animator animator;

    void Start ()
    {
        moveSpeed=0.65f;
        animator=GetComponent<Animator>();
    }

    private void Update()
    {
        if(health<=0)
        {
            animator.SetBool("dead", true);
            moveSpeed=0;
            Destroy(gameObject,1f);
        }
        // Check if the player is within the chase range
        else if (Vector3.Distance(transform.position, player.position) <= chaseRange)
        {
            moveSpeed=0.65f;
            // Calculate the direction to the player
            Vector3 direction = (player.position - transform.position).normalized;

            animator.SetFloat("speed",moveSpeed);

            // Move towards the player
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
        else
        {
            moveSpeed=0;
            animator.SetFloat("speed",moveSpeed);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if((collision.gameObject.name == "sword" )|| (collision.gameObject.tag=="sword"))
        {

            health -=1.5f;
             Vector3 pushDirection = (collision.transform.position - transform.position).normalized;
            //crabby_damage10();

            // Apply force to push the player away
            GetComponent<Rigidbody>().AddForce(-pushDirection * bounceforce, ForceMode.Impulse);
        }
    }
}
