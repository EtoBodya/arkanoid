using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rg;
    public float speed;

    // Start is called before the first frame update
    private void Awake()
    {
        rg = GetComponent<Rigidbody2D>();
        speed = 5f;
    }
    void Start()
    {

        for (int i = 0; i < 11; i++)
        {
            GameObject ball = (GameObject)Instantiate(Resources.Load("Block"));
            ball.transform.position = new Vector2(-5.5f+i, 4.25f);
            BoxCollider2D collider =  ball.GetComponent<BoxCollider2D>();
           // collider.offset = new Vector2(collider.offset.x+i, collider.offset.y);
            
        }
    }
    void OnTriggerEnter2D(Collider2D colider)
    {
        // Destroy(gameObject);
        Debug.Log("collider");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            rg.velocity = new Vector2(speed, rg.velocity.y);
        } else if(Input.GetAxis("Horizontal") < 0)
        {
            rg.velocity = new Vector2(-speed, rg.velocity.y);
        } else
        {
            rg.velocity = new Vector2(0, rg.velocity.y);
        }



    }
}
