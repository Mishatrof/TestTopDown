using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    private Rigidbody2D rb;
    public Transform Hands;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Speed", direction.magnitude);
        if (direction.x > 0.5)
        {
            transform.rotation =
            Quaternion.Euler(0, 0, 0);

        }
        else
        {
            transform.rotation =
            Quaternion.Euler(0, -direction.x * 180, 0);
            Hands.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}
