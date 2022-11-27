using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;
    public Transform blaster;
    public GameObject lazerBolt;
    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); // reference GameManager script
    }

    public void Update()
    {
        // Set HorizontalInput to recieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        // Moves Player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // Keep Player within bounds
        // Left wall
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // Right wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // If spacebar is pressed, fire lazerbolt
        if(Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false) // second condition prevents player from shooting after isGameOver becomes true
        {
            // Create lazer bolt at blaster transform position with bolt rotation
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }
    }
}
