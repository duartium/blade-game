using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{   public GameObject bulletPrefab; // Prefab of the bullet to be instantiated; 
    public GameObject shooter;
    private Transform _firepoint;
    
    private void Awake() {
        _firepoint = transform.Find("FirePoint"); // Find the firepoint child of the weapon object
    }
    // Start is called before the first frame update
    void Start()
    {
        shoot();
    }

    void shoot(){
        if(bulletPrefab != null && _firepoint != null){
            GameObject myBullet = Instantiate(
                bulletPrefab, 
                _firepoint.position, 
                _firepoint.rotation) as GameObject;
            
            Bullet bulletComponent = myBullet.GetComponent<Bullet>();
            if(shooter.transform.localScale.x < 0f){
                bulletComponent.direction = Vector2.left;
            }else{
                bulletComponent.direction = Vector2.right;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
