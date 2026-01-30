using UnityEngine;

public class PlayController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the Vehicle foward
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
