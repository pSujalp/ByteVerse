using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float health=100;

    public TextMeshProUGUI textMeshProUGUI;


   [SerializeField] private Animator animator;

   [SerializeField] private PlayerMovementTutorial  playerMovementTutorial;

   [SerializeField] private float bounceforce;

    private Image image;
    void Start()
    {
        health=100;
        
        GameObject search =  GameObject.FindGameObjectWithTag("health");
        image=search.GetComponent<Image>();
        //animator=GetComponent<Animator>();
        textMeshProUGUI.text="";
    }

    // Update is called once per frame
    void Update()
    {
        if(health<=0)
        {
             animator.SetBool("dead",true);
             playerMovementTutorial.enabled=false;
            textMeshProUGUI.enabled=true;
            textMeshProUGUI.text="Dead";
            Invoke("callnewgame",5.5f);
           
            
        }
        image.fillAmount = health/100;        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="crabby")
        {
            crabby();

              Vector3 pushDirection = (collision.transform.position - transform.position).normalized;
            //crabby_damage10();

            // Apply force to push the player away
            GetComponent<Rigidbody>().AddForce(-pushDirection * bounceforce, ForceMode.Impulse);

        }
    }

    void callnewgame()
    {
        SceneManager.LoadScene("Game");
    }

    void crabby()
    {
        health -=2.5f;
    }

    public void healthdown()
    {
        health -= 3.5f;
    }
}
