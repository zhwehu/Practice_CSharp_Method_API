using UnityEngine;

public class Fox : MonoBehaviour
{
    [Header("移動速度"), Range(0f, 50f)]
    public float speed = 10f;

    public Rigidbody2D rig;
    public SpriteRenderer sr;

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rig.AddForce(new Vector2(h * speed, 0));
        sr.flipX = h < 0;
    }
}
