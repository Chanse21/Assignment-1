using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public int Speed = 5;
    private int direction;
    public float jumpForce;
    public ProjectileBehavior ProjectilePrefab;
    public Transform ShootingPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = 1;
            newPosition.x -= .01f;
        }
        if  (Input.GetKey(KeyCode.RightArrow))
        {
            direction = 0;
            newPosition.x += .01f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }

        if(Input.GetKeyDown("g"))
        {
            var bullet = Instantiate(ProjectilePrefab, ShootingPoint.position, transform.rotation);
            if(direction == 0)
            {
                bullet.Speed = bullet.Speed;
            }
            if (direction == 1)
            {
                bullet.Speed = -bullet.Speed;
            }
        }
        transform.position = newPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("coin"))
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
