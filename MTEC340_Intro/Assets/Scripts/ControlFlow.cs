using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool flag;

    void Start()
    {
    if (flag)
    {
        Debug.Log("Boolean flag is set");
    }
    else
    {
        Debug.Log("Boolean flag isn't set");
    }
    for (int i = 1; i <= 10; i++)
    {
        float result = Mathf.Pow(2, i);
        Debug.Log($"The {i} power of 2 is {result}");
    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
