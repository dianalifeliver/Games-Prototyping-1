using UnityEngine;
using TMPro;

public class SpacebarScore : MonoBehaviour
{
    public TextMeshProUGUI score_text;
    public int score_count;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score_count ++;
            score_text.text = score_count.ToString();

        }

    }

    public void increase()
    { 
        score_count ++;// will increase the value by 1
        score_text.text = score_count.ToString();
        print("Score Increased");
    }

    public void decrease()
    {
        score_count--; //will decrease the value by 2
        score_text.text = score_count.ToString();
        print("Score Decreased");
    }

}
