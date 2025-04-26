using UnityEngine;

public class RigidbodyScript : MonoBehaviour
{
    Rigidbody rb;
    public float radius = 5.0F;
    public float power = 10.0F;
    public Transform explosionPos;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddExplosionForce(power, explosionPos.position, radius, 3.0F);
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Rigidbody>().position = Vector3.zero;
        //rb.position = Vector3.zero;
        
    }
}
