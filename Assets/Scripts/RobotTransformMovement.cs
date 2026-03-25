using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // GET ACCESS FIRST TO THE COMPONENTS
    // Otherwise access is requested for every update

    private Transform m_transform;
    public float velocity = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        m_transform.position = m_transform.position + new Vector3(0,0,velocity)*Time.deltaTime;
    }
}
