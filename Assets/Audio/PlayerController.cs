using AK.Wwise;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rb; 
    private Vector2 movementInput;
    private GameObject player;
    private Vector3 lookChange;
    

    public InputActionReference jumpAction;
    public InputActionReference moveAction;
    public InputActionReference lookAction;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(jumpAction.action.triggered)
        {
            rb.AddForce(Vector3.up * 300);
            Debug.Log("Jump");
        }
        movementInput = moveAction.action.ReadValue<Vector2>();
        if (movementInput != Vector2.zero)
        {
            Debug.Log("Movement Input: " + movementInput);
        }
        rb.AddForce(new Vector3(movementInput.x, 0, movementInput.y) * 10); 
        lookChange = lookAction.action.ReadValue<Vector2>();
        player.transform.Rotate(new Vector3(0, lookChange.x, 0));
        player.transform.Rotate(new Vector3(-lookChange.y, 0, 0));
    }

    
}
