using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeranimation : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator animator;

     float verticalInput ;
     float horizontalInput ;
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        float sum=horizontalInput+verticalInput;

        animator.SetFloat("speed",sum);
       
        
    }
}
