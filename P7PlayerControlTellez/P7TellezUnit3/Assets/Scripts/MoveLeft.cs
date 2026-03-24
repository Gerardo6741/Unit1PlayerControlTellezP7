using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float speed = 30;
    void Start()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
