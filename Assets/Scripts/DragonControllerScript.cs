using UnityEngine;
using System.Collections;

public class DragonControllerScript : MonoBehaviour {

    public float maxSpeed = 10f;
    public float jumpForce = 400f;
    public Rigidbody2D rb;

    Animator anim;
    bool directionRight = true;
    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (grounded && Input.GetKeyDown(KeyCode.UpArrow)) {
            anim.SetBool("Ground", false);
            rb.AddForce(new Vector2(0, jumpForce));
        }
	}

    void FixedUpdate() {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        anim.SetBool("Ground", grounded);

        anim.SetFloat("vSpeed", rb.velocity.y);

        float move = Input.GetAxis("Horizontal");

        anim.SetFloat("Speed", Mathf.Abs(move));

        //rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);
        rb.AddForce(new Vector2(move * maxSpeed, rb.velocity.y));

        if (move > 0 && !directionRight)
            ChangeDirection();
        else if (move < 0 && directionRight)
            ChangeDirection();

    }

    void ChangeDirection() {

        directionRight = !directionRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
