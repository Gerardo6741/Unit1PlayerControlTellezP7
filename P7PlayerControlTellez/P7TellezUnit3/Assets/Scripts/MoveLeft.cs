using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float speed = 30;
    private PlayerMovement playerControllerScript;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    private float leftbound = -15;
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {

        }
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        {
            if (transform.position.x < leftbound && gameObject.CompareTag("Obstacle"))
            {
                Destroy(gameObject);
            }
        }

    }
}
