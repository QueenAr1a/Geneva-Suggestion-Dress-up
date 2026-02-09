using UnityEngine;

public class ThemeSelector : MonoBehaviour
{
    public GameObject theme1;
    public GameObject theme2;
    public static GameObject theme1hold;
    public static GameObject theme2hold;
    public static int themeSelect; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        theme1hold = theme1;
        theme2hold = theme2; 
        themeSelect = Random.Range(0, 2);
        if(themeSelect == 0)
        {
            Instantiate(theme1); 
        }
        else if (themeSelect == 1)
        {
            Instantiate(theme2); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
