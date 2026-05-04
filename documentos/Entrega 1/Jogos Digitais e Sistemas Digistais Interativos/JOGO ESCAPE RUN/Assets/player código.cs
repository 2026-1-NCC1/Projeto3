using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        float Movx = Input.GetAxis("Horizontal");
        float Movy = Input.GetAxis("Vertical");

        Vector3 movimento = new Vector3(Movx, 0 , Movy);

        rb.linearVelocity = movimento * speed;
        
    }
}