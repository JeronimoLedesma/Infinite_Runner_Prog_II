using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float jumpForce;
    bool canJump;
    Rigidbody2D rb;
    public Vector3 scaleChange;
    public GameObject gameOver;
    public GameObject enemySpawner;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        canJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump==true)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            canJump = false;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.transform.localScale -= scaleChange;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            rb.transform.localScale += scaleChange;
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("floor"))
        {
            canJump = true;
        }
        if (collision.gameObject.CompareTag("obstacle"))
        {
            enemySpawner.GetComponent<Spawner>().enabled = false;
            gameOver.SetActive(true);
        }
    }
}
