using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeyScript : MonoBehaviour
{
    public float speed;
    public GameManager gm;

    private float distance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, GameManager.Instance.player.transform.position);
        Vector2 direction = GameManager.Instance.player.transform.position - transform.position;


        transform.position = Vector2.MoveTowards(this.transform.position, GameManager.Instance.player.transform.position, speed * Time.deltaTime);
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            Destroy(gameObject);
            gm.score++;
        }

    }
}