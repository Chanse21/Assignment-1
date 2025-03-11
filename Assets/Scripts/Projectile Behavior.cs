using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float Speed = 8.5f;
    public GameManager gm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * Speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            gm.score++;
            Destroy(gameObject);
        }
    }

}
