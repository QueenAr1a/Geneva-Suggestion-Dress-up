using UnityEngine;

public class InstanceStageBonus : MonoBehaviour
{

    public int stage1Bonus;
    public int stage2Bonus;

    public int baseValue = 1;
    public int clothingPoints;

    // When the instance is selected by the player
    void Start()
    {
        //If theme is Summer
        if (ThemeSelector.themeSelect == 0)
        {
            //Grab the clothing base value
            //Multiply by stage bonus
            //Create a new clothing value

            clothingPoints = baseValue * stage1Bonus;
        }

        //If theme is Winter
        else if (ThemeSelector.themeSelect == 1)
        {
            clothingPoints = baseValue * stage2Bonus;
        }
    }
}
