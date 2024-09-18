using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public WOAPENdesplay wopen;
    public CONTROLPLAYER con;
    public Animator animLitgh;
    public Animator animPISTOL;
    public Animator animM16;
    public Animator animSHOTGUN;
    public Animator animSNAIPER;

    public ammo a;

    public AudioSource ADUIrelod;
    public AudioClip relodpistol;
    public AudioClip relodM16;
    public AudioClip relodsniper;
    public AudioClip relodshotgun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //
        if (wopen.islaithg == true)
        {
            if (horizontal == 0 && vertical == 0)
            {
                animLitgh.SetFloat("movLithg", 0);
            }
            else if (con.run == con.ISrun)
            {
                animLitgh.SetFloat("movLithg", 1);
            }
            else
            {
                animLitgh.SetFloat("movLithg", 0.5f);
            }
        }
        //
        if (wopen.ISferdi == true)
        {
            if (Input.GetMouseButton(1))//aim
            {
                animPISTOL.SetBool("aim", true);
                if (horizontal == 0 && vertical == 0)
                {
                    animPISTOL.SetFloat("aimMOV", 0);
                }
                else
                {
                    animPISTOL.SetFloat("aimMOV", 1);
                }
                //SHOOT
                if (Input.GetMouseButtonDown(0) && a.amoofrdi > 0)
                {
                    animPISTOL.SetTrigger("shootAIM");
                }
                if ((Input.GetKeyDown(KeyCode.R) && a.amoofrdi < a.Amoofrdi && a.maxamoofrdi > 0)||(a.amoofrdi == 0 && a.maxamoofrdi > 0))//relod
                {
                    animPISTOL.SetBool("aim", false);
                    animPISTOL.SetTrigger("rilood");
                    ADUIrelod.clip = relodpistol;
                    ADUIrelod.Play();
                }
            }
            else if ((Input.GetKeyDown(KeyCode.R) && a.amoofrdi < a.Amoofrdi && a.maxamoofrdi>0) || (a.amoofrdi == 0 && a.maxamoofrdi > 0))//relod
            {
                animPISTOL.SetTrigger("rilood");
                ADUIrelod.clip = relodpistol;
                ADUIrelod.Play();
            }
            else//mov
            {
                animPISTOL.SetBool("aim", false);
                //MOV
                if (horizontal == 0 && vertical == 0)
                {
                    animPISTOL.SetFloat("moV", 0);
                }
                else if (con.run == con.ISrun)
                {
                    animPISTOL.SetFloat("moV", 1);
                }
                else
                {
                    animPISTOL.SetFloat("moV", 0.5f);
                }
                //SHOOT
                if (Input.GetMouseButtonDown(0) && a.amoofrdi > 0)
                {
                    animPISTOL.SetTrigger("shoott");
                }

            }
        }
        //m16
        if (wopen.ISGAUN == true)
        {
            if (Input.GetMouseButton(1))//aim
            {
                animM16.SetBool("aim", true);
                if (horizontal == 0 && vertical == 0)
                {
                    animM16.SetFloat("aimMOV", 0);
                }
                else
                {
                    animM16.SetFloat("aimMOV", 1);
                }
                //SHOOT
                if (Input.GetMouseButton(0) && a.amoogun > 0)
                {
                    animM16.SetBool("shootAIM",true);
                }
                else
                {
                    animM16.SetBool("shootAIM", false);
                }

                if ((Input.GetKeyDown(KeyCode.R) && a.amoogun < a.Amoogun && a.maxamoogun > 0)||(a.amoogun==0 && a.maxamoogun > 0))//relod
                {
                    animM16.SetBool("aim", false);
                    animM16.SetTrigger("rilood");
                    ADUIrelod.clip = relodM16;
                    ADUIrelod.Play();
                }
            }
            else if ((Input.GetKeyDown(KeyCode.R) && a.amoogun < a.Amoogun && a.maxamoogun > 0) || (a.amoogun == 0 && a.maxamoogun > 0))//relod
            {
                
                animM16.SetTrigger("rilood");
                ADUIrelod.clip = relodM16;
                ADUIrelod.Play();
            }
            else//mov
            {
                animM16.SetBool("aim", false);
                //MOV
                if (horizontal == 0 && vertical == 0)
                {
                    animM16.SetFloat("moV", 0);
                }
                else if (con.run == con.ISrun)
                {
                    animM16.SetFloat("moV", 1);
                }
                else
                {
                    animM16.SetFloat("moV", 0.5f);
                }
                //SHOOT
                if (Input.GetMouseButton(0) && a.amoogun > 0)
                {
                    animM16.SetBool("shoott" ,true);
                }
                else
                {
                    animM16.SetBool("shoott", false);
                }

            }
        }
        //sniper
        if (wopen.issnaiper == true)
        {
            if (Input.GetMouseButton(1))//aim
            {
                animSNAIPER.SetBool("aim", true);
                if (horizontal == 0 && vertical == 0)
                {
                    animSNAIPER.SetFloat("aimMOV", 0);
                }
                else
                {
                    animSNAIPER.SetFloat("aimMOV", 1);
                }
                //SHOOT
                if (Input.GetMouseButtonDown(0) && a.amoosnaiper > 0)
                {
                    animSNAIPER.SetTrigger("shootAIM");
                }
                if ((Input.GetKeyDown(KeyCode.R) && a.amoosnaiper < a.Amoosnaiper && a.maxamoosnaiper > 0)|| (a.amoosnaiper==0 && a.maxamoosnaiper > 0))//relod
                {
                    animSNAIPER.SetBool("aim", false);
                    animSNAIPER.SetTrigger("rilood");
                    ADUIrelod.clip = relodsniper;
                    ADUIrelod.Play();
                }
            }
            else if ((Input.GetKeyDown(KeyCode.R) && a.amoosnaiper < a.Amoosnaiper && a.maxamoosnaiper > 0)|| (a.amoosnaiper == 0 && a.maxamoosnaiper > 0))//relod
            {
                animSNAIPER.SetTrigger("rilood");
                ADUIrelod.clip = relodsniper;
                ADUIrelod.Play();
            }
            else//mov
            {
                animSNAIPER.SetBool("aim", false);
                //MOV
                if (horizontal == 0 && vertical == 0)
                {
                    animSNAIPER.SetFloat("moV", 0);
                }
                else if (con.run == con.ISrun)
                {
                    animSNAIPER.SetFloat("moV", 1);
                }
                else
                {
                    animSNAIPER.SetFloat("moV", 0.5f);
                }
                //SHOOT
                if (Input.GetMouseButtonDown(0) && a.amoosnaiper > 0)
                {
                    animSNAIPER.SetTrigger("shoott");
                }

            }
        }
        //shotgun
        if (wopen.isshootgan == true)
        {
            if (Input.GetMouseButton(1))//aim
            {
                animSHOTGUN.SetBool("aim", true);
                if (horizontal == 0 && vertical == 0)
                {
                    animSHOTGUN.SetFloat("aimMOV", 0);
                }
                else
                {
                    animSHOTGUN.SetFloat("aimMOV", 1);
                }
                //SHOOT
                if (Input.GetMouseButtonDown(0) && a.amooshotgun > 0)
                {
                    animSHOTGUN.SetTrigger("shootAIM");
                }
                if ((Input.GetKeyDown(KeyCode.R) && a.amooshotgun < a.Amooshotgun && a.maxamooshorgan > 0)|| (a.amooshotgun==0 && a.maxamooshorgan > 0))//relod
                {
                    animSHOTGUN.SetBool("aim", false);
                    animSHOTGUN.SetTrigger("rilood");
                    ADUIrelod.clip = relodshotgun;
                    ADUIrelod.Play();
                }
            }
            else if ((Input.GetKeyDown(KeyCode.R) && a.amooshotgun < a.Amooshotgun && a.maxamooshorgan > 0) || (a.amooshotgun == 0 && a.maxamooshorgan > 0))//relod
            {
                animSHOTGUN.SetTrigger("rilood");
                ADUIrelod.clip = relodshotgun;
                ADUIrelod.Play();
            }
            else//mov
            {
                animSHOTGUN.SetBool("aim", false);
                //MOV
                if (horizontal == 0 && vertical == 0)
                {
                    animSHOTGUN.SetFloat("moV", 0);
                }
                else if (con.run == con.ISrun)
                {
                    animSHOTGUN.SetFloat("moV", 1);
                }
                else
                {
                    animSHOTGUN.SetFloat("moV", 0.5f);
                }
                //SHOOT
                if (Input.GetMouseButtonDown(0) && a.amooshotgun > 0)
                {
                    animSHOTGUN.SetTrigger("shoott");
                }

            }
        }
    }
}
