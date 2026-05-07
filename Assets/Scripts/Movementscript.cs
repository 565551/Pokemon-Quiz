using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementscript : MonoBehaviour
{
    private Rigidbody2D RB;

    private float Horizontal;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        RB = gameObject.transform.GetChild(0).GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        RB.velocity = new Vector2(Horizontal * speed,RB.velocity.y);
        if (Horizontal < 0)
        {
            transform.GetChild(0).localScale = new Vector3(1.5f, 1.5f, 1.5f);

        }
        else if(Horizontal > 0)
        {
            transform.GetChild(0).localScale = new Vector3(-1.5f, 1.5f, 1.5f);
        }
    }
}