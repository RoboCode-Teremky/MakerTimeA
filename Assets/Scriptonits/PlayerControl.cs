using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private float JumpForce = 1.0f;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(move*speed, rb2d.velocity.y);
        foreach(RaycastHit2D rH2D in Physics2D.RaycastAll(transform.position, Vector2.down, 1.5f)){
            if(rH2D.collider.CompareTag("Level") && Input.GetButtonDown("Jump")){
                rb2d.AddForce(Vector2.up*JumpForce, ForceMode2D.Impulse);
            }
        }
    }
}
