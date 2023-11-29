using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerContr : MonoBehaviour
{
    public int coins = 0;
    public float speed = 5.0f;
    private Rigidbody2D rigb;
    float horizontal;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {
    rigb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        
    }

    private void FixedUpdate()
    {
        rigb.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
}
