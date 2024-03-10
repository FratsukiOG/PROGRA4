using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
public class Jugador : MonoBehaviour
{
	[SerializeField] private float speed;

	[SerializeField] private LayerMask groundLayer;
	[SerializeField] private float jumpForce = 10f;
	[SerializeField] private float groundDistance = 0.25f;
	[SerializeField] private float jumpTime = 0.3f;
	[SerializeField] private Transform feetPos;

	public static Jugador Instance;
	private JugadorInputAction jugadorInputAction;

	private bool isGrounded = false;
	private bool isJumping = false;
	private float jumpTimer;

	private Rigidbody2D rb;
	public int jumpPower = 3;

	private void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
		else
		{
			Destroy(gameObject);
		}

		jugadorInputAction = new JugadorInputAction();
		rb = GetComponent<Rigidbody2D>();
	}

	private void Start()
	{
		jugadorInputAction.Enable();
		rb = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{

		Move();

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

	private void Move()
	{
		Debug.Log(jugadorInputAction.Standard.Movement.ReadValue<Vector2>());

		Vector3 direction = new Vector3(jugadorInputAction.Standard.Movement.ReadValue<Vector2>().x, jugadorInputAction.Standard.Movement.ReadValue<Vector2>().y, 0).normalized;
		rb.AddForce(direction * speed);
	}

	private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Suelo")
        {
			UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver_2");
        }
    }

}
