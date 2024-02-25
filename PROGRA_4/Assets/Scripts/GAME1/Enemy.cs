using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] private float speed;


    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Move()
    {
        Vector3 direction = (Player.Instance.transform.position - transform.position).normalized;

        rb.AddForce(direction * speed);
    }

    public void Hit(int damage)
    {
        
    }

}
