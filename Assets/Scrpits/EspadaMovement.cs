using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private float x, y;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()

    {
        rb.velocity = new Vector2(x, y) * speed;

    }
}
