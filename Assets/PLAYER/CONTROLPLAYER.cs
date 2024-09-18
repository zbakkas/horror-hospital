using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONTROLPLAYER : MonoBehaviour
{
    
    public Transform cam = null;
    public CharacterController controller;
    public float moussansfti = 1;

    float campich = 0.0f;

    bool louckcrous = true;

    public float wolkspeed =1 ;

    public bool aais;
    public float jump =0;
    public float isjump ;
    public float timjump;

    public float run = 1;
    public float ISrun = 2;

    public AudioSource ADUI;
    public AudioClip audjump;

    public float recoil =0;
    // Start is called before the first frame update
    void Start()
    {
        if (louckcrous)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        updatmus();
        mov();

    }
    
    void updatmus()
    {
        Vector2 mosdelt = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        campich -= ((mosdelt.y) + recoil) * moussansfti;// campich -= mosdelt.y * moussansfti;
        campich = Mathf.Clamp(campich, -90.0f, 90.0f);//lhad dyal lock

        cam.localEulerAngles = Vector3.right * campich;

        transform.Rotate(Vector2.up * mosdelt.x * moussansfti);

    }

    void mov()
    {
        Vector2 vulompv = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        vulompv.Normalize();
        //
        if (controller.isGrounded)
        {
            //Debug.Log("9ais");
            aais = true;
        }
        else
        {
            aais = false;
        }
        //
        if (Input.GetKeyDown(KeyCode.Space) && aais == true)
        {
            jump = isjump;
            ADUI.clip = audjump;
            ADUI.Play();
        }
        else
        {
            if (aais == false)
            {
                jump -= isjump * timjump * Time.deltaTime;
            }
            
        }
        //
        if (Input.GetKey(KeyCode.LeftShift))
        {
            run = ISrun;
        }
        else
        {
            run = 1;
        }
        //

        Vector3 velocity = (transform.forward * vulompv.y + transform.right * vulompv.x)* wolkspeed*run + Vector3.up * jump;
        controller.Move(velocity * Time.deltaTime);
    }
}
