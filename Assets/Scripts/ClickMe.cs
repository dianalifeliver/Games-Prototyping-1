using UnityEngine;

public class ClickMe : MonoBehaviour
{
    public string tree;
// The name must be “OnMouseDown”
void OnMouseDown() 
    {
    Debug.Log(tree);
    }
}
