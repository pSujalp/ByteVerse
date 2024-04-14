using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spritebillboarding : MonoBehaviour
{
 [SerializeField]
    private bool freezeXZAxis;


    // Update is called once per frame
    void Update()
    {
        if (freezeXZAxis)

        {

            transform.rotation = Quaternion.Euler(0f, Camera.main.transform.rotation.eulerAngles.y, 0f);
        }
        else
        {
            transform.rotation = Camera.main.transform.rotation;

        }
    }
}
