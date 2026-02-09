using UnityEngine;

public class MoveFoward : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}