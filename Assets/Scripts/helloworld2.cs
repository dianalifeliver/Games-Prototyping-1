using UnityEngine;

public class helloworld2 : MonoBehaviour
{
    public string Text = "Hello World!"; // public makes the variable editable in the editor.
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Text"); // Prints "Text"
        Debug.Log(Text); // Prints the value of the Text string
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
