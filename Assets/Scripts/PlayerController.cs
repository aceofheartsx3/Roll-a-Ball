using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;
    private Transform pos;

    /*Update is for everything that will happen constantly
    during the game EXCEPT for physics (things effecting rigidbodies)*/
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        pos = GetComponent<Transform>();
    }


    //FixedUpdate is for physics calculations, and updates at set intervals
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }


}