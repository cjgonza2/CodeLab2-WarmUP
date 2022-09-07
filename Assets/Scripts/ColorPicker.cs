using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    public int SetSprite()
    {
        return Random.Range(0, 3);
        //returns a value between 1 and 3, excludes the value 3.
        //REMINDER for self: random.range is EXCLUSIVE so it will 
        
        ///<summary>
        ///UPDATED NOTE TO SELF:
        ///for whatever type of variable in range you're trying to return
        ///float will be minInclusive AND maxInclusive.
        ///Where as returning an Int value will be minInclusive AND
        ///maxEXCLUSIVE.
        /// </summary>

    }
}
