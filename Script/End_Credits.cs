using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End_Credits : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        Invoke("Main_menu",10f);
    }

    void Main_menu()
    {
        SceneManager.LoadScene("Main_menu");
    } 
}

