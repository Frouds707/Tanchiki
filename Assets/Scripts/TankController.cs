using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public GeneralVariables GeneralVariables;

    private void Update()
    {
        KeystrokeTracking();
    }

    private void KeystrokeTracking()
    {
        if(Input.GetKey(KeyCode.W) & !Input.GetKey(KeyCode.S))
        {
            GeneralVariables.turnUp = true;
            Debug.Log("JJHIKJI");
        }
        else
        {
            GeneralVariables.turnUp = false;
        }
        if(Input.GetKey(KeyCode.S) & !Input.GetKey(KeyCode.W))
        {
            GeneralVariables.turnDown = true;
        }
        else
        {
            GeneralVariables.turnDown = false;
        }
        if (Input.GetKey(KeyCode.A) & !Input.GetKey(KeyCode.D))
        {
            GeneralVariables.turnLeft = true;
        }
        else
        {
            GeneralVariables.turnLeft = false;
        }
        if(Input.GetKey(KeyCode.D) & !Input.GetKey(KeyCode.A))
        {
            GeneralVariables.turnRight = true;
        }
        else
        {
            GeneralVariables.turnRight = false;
        }
        if(!Input.GetKey(KeyCode.S)& !Input.GetKey(KeyCode.W) & !Input.GetKey(KeyCode.A) & !Input.GetKey(KeyCode.D))
        {
            GeneralVariables.turnUp = false;
            GeneralVariables.turnDown = false;
            GeneralVariables.turnLeft = false;
            GeneralVariables.turnRight = false;

        }
    }
}
