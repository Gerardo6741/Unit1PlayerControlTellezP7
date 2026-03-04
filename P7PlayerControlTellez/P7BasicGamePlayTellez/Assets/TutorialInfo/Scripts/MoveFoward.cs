using UnityEngine;

public class MoveFoward : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float speed = 40.0f;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);  
    }
}
