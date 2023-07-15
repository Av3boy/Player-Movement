using UnityEngine;

public class Base : MonoBehaviour
{
    [SerializeField]
    protected float moveSpeed = 15f;
    protected Vector3 moveDirection = Vector3.zero;

    /// <summary>
    ///     Start is called before the first frame update.
    /// </summary>
    public virtual void Start() { }

    /// <summary>
    ///     Update is called once per frame.
    /// </summary>
    public virtual void Update()
    {
        // Get horizontal and vertical input values
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Calculate movement vector based on input
        moveDirection = transform.forward * verticalInput + transform.right * horizontalInput;
        moveDirection.Normalize(); // Normalize the vector to prevent faster diagonal movement

        // Apply speed to the movement after the normalization to (TODO: Why?)
        moveDirection *= moveSpeed;
    }
}
