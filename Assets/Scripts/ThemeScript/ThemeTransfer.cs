using UnityEngine;

public class ThemeTransfer : MonoBehaviour
{
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(ThemeSelector.themeSelect == 0)
        {
           Instantiate(ThemeSelector.theme1hold);
        }

        else if (ThemeSelector.themeSelect == 1)
        {
            Instantiate(ThemeSelector.theme2hold);
        }
    }
}
