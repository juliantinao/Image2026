using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rb; 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnJump()
    {
        Debug.Log("pressed");
        rb.AddForce(new Vector3(0,300,0));

    }

    void OnMove(InputAction input)
    {
        Debug.Log("moving");
    }
}
