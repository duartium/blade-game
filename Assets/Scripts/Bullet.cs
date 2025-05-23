using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2f;
    public float tiempoVida = 3f;
    public Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        //destruye la bala después de un tiempo
        Destroy(gameObject, tiempoVida);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = direction.normalized * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
