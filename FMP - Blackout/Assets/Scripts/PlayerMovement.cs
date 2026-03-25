using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]

    [SerializeField] private float moveSpeed;
    
    private Vector2 movementDirection;
    private Vector2 currentInput;

    private Rigidbody2D rb;

    private string lastDirection = "Down";

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

   
    void FixedUpdate()
    {
        rb.linearVelocity = movementDirection * moveSpeed;
    }

<<<<<<< HEAD
    public void OnMove(InputAction.CallbackContext context)
    {
        currentInput = context.ReadValue<Vector2>().normalized;
=======
    private void OnMove(InputValue value)
    {
        currentInput = value.Get<Vector2>().normalized;
>>>>>>> c65cb53f63b3266af7de31203df37ca7ed6901d3
        movementDirection = GetDirection(currentInput);
    }

    private Vector2 GetDirection(Vector2 input)
    {
        Vector2 finalDirection = Vector2.zero;
        if (input.y > 0.01f)
        {
            lastDirection = "Up";
<<<<<<< HEAD
            
=======

>>>>>>> c65cb53f63b3266af7de31203df37ca7ed6901d3
            finalDirection = new Vector2(0, 1f);
        }
        else if (input.y < -0.01f)
        {
            lastDirection = "Down";

            finalDirection = new Vector2(0, -1f);
        }
        else if (input.x > 0.01f)
        {
            lastDirection = "Right";

            finalDirection = new Vector2(1f, 0);
        }
        else if (input.x < -0.01f)
        {
            lastDirection = "Left";

            finalDirection = new Vector2(-1f, 0);
        }
        else
            finalDirection = Vector2.zero;

        return finalDirection;

    }
}
