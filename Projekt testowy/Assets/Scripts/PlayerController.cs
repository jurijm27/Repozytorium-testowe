using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    int liczbacalkowita; // np. 1,2,3,4
    float liczbaprzecinkowa = 0.1f; // np. 4,3223, 56.23423

    public float speed;

    public Rigidbody Rigidbody;
    public Transform StartPoint; 

    public object S { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            float directionhorizontal = Input.GetAxis("Horizontal");
            Rigidbody.AddForce(directionhorizontal * Time.deltaTime * speed, 0, 0, ForceMode.Impulse);
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            float directionvertical = Input.GetAxis("Vertical");
            Rigidbody.AddForce(0, 0, directionvertical * Time.deltaTime * speed, ForceMode.Impulse);
        }
       
        if (transform.position.y <-3)
        {
            transform.position = StartPoint.position;
            Rigidbody.velocity = Vector3.zero; 
        }


    }



}


