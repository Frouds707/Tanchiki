using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public GeneralVariables GeneralVariables;
    public GameObject tankAbs;
    private GameObject tank;
    private Vector3 zeroVector = new Vector3(0, 2, 0);

    private float moveVecTank;
    private float rotatVecTank;
    private float speedMove = 4f;
    private float speedRotat = 50f;

    private void Start()
    {
        tank = Instantiate(tankAbs) as GameObject;
        tank.transform.position = zeroVector;
    }
    private void Update()
    {
        MovingTank();
    }

    private void MovingTank()
    {
        moveVecTank = 0;
        rotatVecTank = 0;
        if (GeneralVariables.turnUp)
        {
            moveVecTank = 1;
            Debug.Log("JJHIKJI");
        }
        if (GeneralVariables.turnDown)
        {
            moveVecTank = -1;
        }
        if (GeneralVariables.turnRight)
        {
            if (moveVecTank == -1)
            {
                rotatVecTank = -1;
            }
            else
            {
                rotatVecTank = 1;
            }
        }
        if (GeneralVariables.turnLeft)
        {
            if (moveVecTank == -1)
            {
                rotatVecTank = 1;
            }
            else
            {
                rotatVecTank = -1;
            }
        }
        tank.transform.Translate(0,0,moveVecTank * speedMove * Time.deltaTime , Space.Self);
        tank.transform.Rotate(0, rotatVecTank * speedRotat * Time.deltaTime, 0, Space.Self);
    }
}
