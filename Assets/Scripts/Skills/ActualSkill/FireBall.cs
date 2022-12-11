using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float speed;
    private Animator animator;
    public Agent agent;
    public Transform place;
    private Rigidbody2D rigidBody;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        place = GetComponent<Transform>();
        agent = GameObject.Find("Agent").GetComponent<Agent>();
        rigidBody = GetComponent<Rigidbody2D>();


    }
    // Start is called before the first frame update
    void Start()
    {
        float xparent = agent.transform.localScale.x;
        if (agent.transform.localScale.x < 0)
        {
            place.localScale = new Vector3(place.localScale.x * xparent, place.localScale.y, place.localScale.z);
        }
        rigidBody.velocity = new Vector3(speed * xparent, rigidBody.position.y,0);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}