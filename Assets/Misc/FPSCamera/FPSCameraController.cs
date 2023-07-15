using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float HorizontalSensitivity = 500;
    public float VerticalSensitivity = 500;

    private float xRotation;
    private float yRotation;

    private GameObject _target;
    public Vector3 CameraOffset = new Vector3(0, 0.7f, 0.4f);

    private void Awake()
    {
        // Hide the cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // Get the target object that the camera is following
        _target = this.transform.parent.gameObject;

        if (_target == null)
            Debug.LogError("The camera must be a child of the player object.");

        this.transform.position = _target.transform.position + CameraOffset;
    }

    private void Update()
    {
        // Get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * VerticalSensitivity;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * HorizontalSensitivity;

        xRotation += mouseX;
        yRotation += mouseY;

        // Allow the player to look up and down, but not all the way around.
        yRotation = Mathf.Clamp(yRotation, -90f, 90f);

        // Calculate camera transformation.
        Vector3 position = _target.transform.position + CameraOffset;
        Quaternion rotation = Quaternion.Euler(-yRotation, xRotation, 0);
        _target.transform.rotation = Quaternion.Euler(0, xRotation, 0);

        transform.SetPositionAndRotation(position, rotation);
    }
}
