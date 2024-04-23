using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoiScript : MonoBehaviour
{
    public Rigidbody2D BoiRigidbody;
    public float flapPower = 20;
    public LogicScript logic;
    public bool boiAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && boiAlive) BoiRigidbody.velocity = Vector2.up * flapPower;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        boiAlive = false;
    }
}
