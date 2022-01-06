using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //float SteerSpeed = 1f;
    [SerializeField] float MoveSpeed = 20f; //adding attribute writing to disk so it is visible by inspector inside Unity
    [SerializeField] float SteerSpeed = 300f; //adding attribute writing to disk so it is visible by inspector inside Unity
    [SerializeField] float SlowSpeed = 15f; //adding attribute writing to disk so it is visible by inspector inside Unity
    [SerializeField] float BoostSpeed = 30f; //adding attribute writing to disk so it is visible by inspector inside Unity
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float SteerAmount = Input.GetAxis("Horizontal") * SteerSpeed * Time.deltaTime;
        float MoveAmount = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -SteerAmount);
        transform.Translate(0,MoveAmount,0);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Boost"){
            MoveSpeed = BoostSpeed;   
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        MoveSpeed = SlowSpeed;
    }
}
