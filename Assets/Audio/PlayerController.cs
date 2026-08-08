using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    
    public InputActionReference jumpAction;
    public int fuerzaDeSalto;

    public InputActionReference moveAction;
    public int velocidad;

    public InputActionReference lookAction;
    public float sensitivity;

    private Vector2 lookVector;
    private Vector2 moveVector;    

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(jumpAction.action.triggered)
        {
            Debug.Log("Salte");
            if(rb.linearVelocity.y == 0)
            {
                rb.AddForce(0,fuerzaDeSalto,0);
                
            }
        }

        moveVector = moveAction.action.ReadValue<Vector2>();
        
        rb.linearVelocity = new Vector3(moveVector.x * velocidad, rb.linearVelocity.y, moveVector.y * velocidad);

        lookVector = lookAction.action.ReadValue<Vector2>();

        transform.Rotate(0, lookVector.x * sensitivity, 0);




    }


    
    


    
}
