using System.Numerics;
using UnityEngine;

public class Test : MonoBehaviour
{
    int frameNumber = 0;
    public int a = 3;
    public int b = 5;

    float xPos = 0.01f;

    void Start()
    {
        Debug.Log("Run at 1st frame");
        Debug.LogWarning("This is warning!!");
        Debug.LogError("This is ERROR!!");
    }

    void Update()
    {

        Debug.Log(transform.position.x);
        frameNumber++;
        if(frameNumber > 10)
        {
            //MyMethod();
            int c = AddMethod(a,b);
            //Debug.Log(c);
            frameNumber = 0;
        }
        //Debug.Log("Run at every frame");
    }

    void MyMethod()
    {
        Debug.Log("Hello! I am My Method");
    }

    int AddMethod(int a, int b)
    {
        return a+b;
    }
}