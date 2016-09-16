using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    [SerializeField]private float speed = 6f;

	public GameObject bulletPrefab; 

	public Transform bulletInitialTransform;

    void Update() 
    {
        Shoot();
        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.A))
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.W))
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.S))
            transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
    }
    void Shoot()
    {
        if (Input.GetKey(KeyCode.Space))
        {
             Debug.Log("Shoot!");
             GameObject bullet = Instantiate(bulletPrefab);
             bullet.transform.position = bulletInitialTransform.position;
        }
     
    }  
}
