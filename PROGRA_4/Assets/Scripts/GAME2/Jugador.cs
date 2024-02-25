using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jugador : MonoBehaviour
{

	[SerializeField] private LayerMask groundLayer;
	[SerializeField] private float jumpForce = 10f;
	[SerializeField] private float groundDistance = 0.25f;
	[SerializeField] private float jumpTime = 0.3f;
	[SerializeField] private Transform feetPos;

	private bool isGrounded = false;
	private bool isJumping = false;
	private float jumpTimer;

	private Rigidbody2D rb;
	public int jumpPower = 3;
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		isGrounded = Physics2D.OverlapCircle(feetPos.position, groundDistance, groundLayer);

		if(isGrounded && Input.GetButtonDown("Jump"))
        {
			isJumping = true;
			rb.velocity = Vector2.up * jumpForce;
        }

		if (isJumping && Input.GetButtonDown("Jump"))
        {
			if (jumpTimer < jumpTime)
            {
				rb.velocity = Vector2.up * jumpForce;

				jumpTimer += Time.deltaTime;
            }

            else 
			{
				isJumping = false;
			}
        }

		if (Input.GetButtonDown("Jump"))
        {
			isJumping = false;
			jumpTimer = 0;
        }

	}
	
}
