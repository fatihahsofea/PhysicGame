using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    Rigidbody rb;
    public float mSpeed = 2f;
    public float shootForce = 5f;
    public float yVal = 1.5f;
    public float zVal = 0.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 direction = new Vector3(0,yVal,zVal);
        rb.AddForce(direction * shootForce, ForceMode.Impulse);
    }

    void FixedUpdate()
    {
        //rb.linearVelocity = transform.forward * mSpeed;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }

/*
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
    }
*/


    /*
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Touch Start");
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        Debug.Log("Is Toucing");
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        Debug.Log("No Toucing");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter");
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Overlapping");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");
    }
    */
}
