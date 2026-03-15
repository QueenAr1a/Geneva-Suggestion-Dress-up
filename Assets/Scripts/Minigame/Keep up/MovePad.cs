using UnityEngine;

public class MovePad : MonoBehaviour
{
    public float speed;

    float movementHorizontal;

    public float Maxx = 7.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left  * speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right  * speed * Time.deltaTime;
            }

        
       

    }
}
