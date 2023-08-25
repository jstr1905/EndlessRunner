using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5;
    public float leftRightSpeed = 4;
    static public bool canMove = false;
    public bool isJumping = false;
    public bool comingDown = false;
    public GameObject playerObject;


    void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * moveSpeed), Space.World);
        if (canMove == true)
        {
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                if (Input.GetKey(KeyCode.A))
                {
                    transform.Translate(Vector3.left * (leftRightSpeed * Time.deltaTime));
                }
            }

            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                if (Input.GetKey(KeyCode.D))
                {
                    transform.Translate(Vector3.left * (leftRightSpeed * Time.deltaTime * -1));
                }
            }

            if (Input.GetKey(KeyCode.Space))
            {
                if (isJumping == false)
                {
                    isJumping = true;
                    playerObject.GetComponent<Animator>().Play("Jump");
                    StartCoroutine(JumpSequence());
                }
            }
        }

        if (isJumping == true)
        {
            if (comingDown == false)
            {
                transform.Translate(Vector3.up * (Time.deltaTime * 3), Space.World);
            }

            if (comingDown == true)
            {
                transform.Translate(Vector3.up * (Time.deltaTime * -3), Space.World);
            }
        }
    }

    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.45f);
        comingDown = true;
        yield return new WaitForSeconds(0.45f);
        isJumping = false;
        comingDown = false;
        playerObject.GetComponent<Animator>().Play("Standard Run");
    }
}