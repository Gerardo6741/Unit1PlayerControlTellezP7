using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DestoryOutOfBounds : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private float topBound = 30;
    private float lowerbound = -10;
    void Update()
    {
       if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerbound)
        {
            Destroy(gameObject);
        }
    } 
}
