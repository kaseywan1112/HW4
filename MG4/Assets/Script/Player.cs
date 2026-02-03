using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    public GameObject gameOverText;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            AudioManager.instance.PlayFlapSound();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Pipe")) 
        {
            Debug.Log("Game Over");
            AudioManager.instance.PlayDeathSound();
            Time.timeScale = 0f;

            if (gameOverText != null)
            {
                gameOverText.SetActive(true);
            }
        }
    }
}
