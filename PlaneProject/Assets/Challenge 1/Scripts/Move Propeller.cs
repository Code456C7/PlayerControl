using UnityEngine;

public class MovePropeller : MonoBehaviour
{
    private float propeller;
    private Vector3 propellers = Vector3.zero;
    private float speed = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        propeller = Input.GetAxis("Vertical") * 30.0f;

        transform.Rotate(Vector3.forward + propellers * speed * Time.deltaTime, 35.0f);
       
    }
}
