using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cont : MonoBehaviour
{
    
    public float speed = 9;
    public float run = 1;
    public float ISrun = 1;
    public GameObject came;
    [Range(0.1f, 5f)] public float mousssntit = 1f;


    public float turnspeed = 15f;
    public Camera mainca;
    public Transform cam;
    public CharacterController controller;

    public bool aais;
    float verticalvl = 0;
    public float jumpv;
    public float timejump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float Xvalue = Input.GetAxis("Mouse Y");
        float Yvalue = Input.GetAxis("Mouse X");

        //rb.AddForce(transform.forward * (vertical * speed));
        //rb.AddForce(transform.right * (horizontal * speed));
        //MOV CAMERA X Y
        transform.rotation *= Quaternion.Euler(0f, Yvalue * mousssntit, 0f);//Y
        cam.rotation *= Quaternion.Euler(-Xvalue * mousssntit, 0f, 0f);//X

        //9is-lard
        if (controller.isGrounded)
        {
            //Debug.Log("9ais");
            aais = true;
        }
        else
        {
            aais = false;
        }
        //jump
        if (Input.GetKeyDown(KeyCode.Space) && aais == true)
        {    
            verticalvl = jumpv;
        }
        else
        {
            verticalvl -= jumpv * timejump * Time.deltaTime;
        }
        //run
        if (Input.GetKey(KeyCode.LeftShift))
        {
            run = ISrun;
        }
        else
        {
            run = 1;
        }
        //mov
        Vector3 movdir = new Vector3(horizontal, 0, vertical);
        float angle = Mathf.Atan2(movdir.x, movdir.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
        transform.rotation = Quaternion.Euler(0, angle, 0);

        movdir = cam.TransformDirection(movdir);//MOV TO LOCK PLAYER
        movdir = new Vector3(movdir.x * speed * run, verticalvl, movdir.z * speed);
        controller.Move(movdir * Time.deltaTime);//mov

    }
}
