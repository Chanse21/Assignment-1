using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int Speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;

        if (Input.GetKey("a"))
        {
            newPosition.x -= .01f;
        }
        if (Input.GetKey("d"))
        {
            newPosition.x += .01f;
        }
    }
}
