using UnityEngine;

public class DestoryOutOfBounds : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private float topBound = 30;
    void Update()
    {
       if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } 
    }
}
