using UnityEngine;

public class Healing : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Ally")
        {
            Vector3 scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
            other.gameObject.transform.localScale += scaleChange;
        }

        if(other.gameObject.tag == "Enemy")
        {
            Vector3 scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);
            other.gameObject.transform.localScale += scaleChange;
        }
    }
}
