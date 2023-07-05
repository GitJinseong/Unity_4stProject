using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody playerRigidbody = default;
    public float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
        float yInput = Input.GetAxis("Jump");

        float xSpeed = xInput * (speed * 5);
        float zSpeed = zInput * (speed * 5);
        float ySpeed = yInput * (speed * 5);

        Vector3 newVelocity = new Vector3(xSpeed, ySpeed, zSpeed);
    
        playerRigidbody.velocity = newVelocity;
    }
    //  Update()

    public void Die()
    {
        gameObject.SetActive(false);

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}
