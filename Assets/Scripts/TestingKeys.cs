using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestineKeys : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("button 0");
        }

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Presionaste botón saltar...");
        }

        // obtener movimientos por AXIS
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if(horizontal < 0f || horizontal > 0f)
            Debug.LogWarning("Horizontal axis es " + horizontal);

        if (vertical < 0f || vertical > 0f)
            Debug.LogWarning("Vertical axis es " + vertical);
    }
}
