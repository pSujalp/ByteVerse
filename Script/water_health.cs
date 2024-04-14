using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_health : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Health health;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            health.healthdown();
        }
    }
}
