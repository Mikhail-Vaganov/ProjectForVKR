using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{

    public float axis_X;
    public float axis_Y;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Mouse1))
        //{
        //    gameObject.GetComponent<Animator>().SetTrigger("Attack");
        //}

        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{
        //    gameObject.GetComponent<Animator>().SetTrigger("Attack_Hand");
        //}

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    gameObject.GetComponent<Animator>().SetTrigger("Jump");
        //}

        //if (Input.GetKeyDown(KeyCode.LeftShift))
        //{
        //    gameObject.GetComponent<Animator>().SetTrigger("Sprint");
        //}
        //if (Input.GetKeyUp(KeyCode.LeftShift))
        //{
        //    gameObject.GetComponent<Animator>().SetTrigger("Idle");
        //}

        axis_X = Input.GetAxis("Vertical");
        axis_Y = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, transform.rotation.y + 180, 0), 0.2f);
            gameObject.GetComponent<Animator>().SetTrigger("WalkTR");

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            gameObject.GetComponent<Animator>().SetTrigger("IdleTR");
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, transform.rotation.y, 0), 0.2f);
            gameObject.GetComponent<Animator>().SetTrigger("WalkTR");

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            gameObject.GetComponent<Animator>().SetTrigger("IdleTR");
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, transform.rotation.y + 90, 0), 0.2f);
            gameObject.GetComponent<Animator>().SetTrigger("WalkTR");

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            gameObject.GetComponent<Animator>().SetTrigger("IdleTR");
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, transform.rotation.y - 90, 0), 0.2f);
            gameObject.GetComponent<Animator>().SetTrigger("WalkTR");

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            gameObject.GetComponent<Animator>().SetTrigger("IdleTR");
        }
    }
    private void FixedUpdate()
    {
        gameObject.GetComponent<Animator>().SetFloat("Speed", axis_X, 0.1f, Time.deltaTime);
        gameObject.GetComponent<Animator>().SetFloat("Direction", axis_Y, 0.1f, Time.deltaTime);
    }
}
