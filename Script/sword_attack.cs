using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword_attack : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator animator;

    [SerializeField] Animator player;

    private CapsuleCollider capsuleCollider;
    void Start()
    {
        animator = GetComponent<Animator>(); 
        capsuleCollider = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            capsuleCollider.enabled=true;
            animator.SetBool("attack",true);
            player.SetBool("attack",true);
                Cursor.lockState = CursorLockMode.Locked;
         Cursor.visible = false;
        }
        else if(Input.GetKeyUp(KeyCode.F))
        {
            capsuleCollider.enabled = false;
            animator.SetBool("attack",false);
            player.SetBool("attack",false);
        }
        
    }
}
