using UnityEngine;
using UnityEngine.InputSystem;

public class OrthoMove : MonoBehaviour
{
    // GET ACCESS FIRST TO THE COMPONENTS
    // Otherwise access is requested for every update

    InputAction moveAction;
    private Transform m_transform;
    public float cameraSpeed = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        m_transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        m_transform.position = m_transform.position + new Vector3(moveValue.x,0,moveValue.y)*Time.deltaTime*cameraSpeed;
    }
}
