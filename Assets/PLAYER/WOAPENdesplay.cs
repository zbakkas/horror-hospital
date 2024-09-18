using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WOAPENdesplay : MonoBehaviour
{

    public GameObject M16;
    public GameObject frdi;
    public GameObject shotgan;
    public GameObject snaiper;
    //public GameObject katana;
    public bool ISGAUN;
    public bool ISferdi;
    public bool issnaiper;
    public bool isslah;
    public bool isshootgan;
    //public bool iskatana;
    public int weaponnum;
    public int weaponnum2;
    public int weaponnum3;
    public int weaponnum4;
    //public int weaponnum5;

    public GameObject litgh;
    public bool islaithg;
    // Start is called before the first frame update
    void Start()
    {
        islaithg = true;
        litgh.SetActive(true);

        isslah = false;
        frdi.SetActive(false);
        M16.SetActive(false);
        //katana.SetActive(false);
        snaiper.SetActive(false);
        shotgan.SetActive(false);
        ISGAUN = false;
        ISferdi = false;
        //iskatana = false;
        isshootgan = false;
        issnaiper = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (weaponnum == 1)
            {
                weaponnum = 0;
            }
            else
            {
                weaponnum += 1;
            }
        }
        if (weaponnum == 0)
        {
            isslah = false;

        }
        if (weaponnum == 1)
        {
            //weaponnum5 = 0;
            weaponnum2 = 0;
            weaponnum3 = 0;
            weaponnum4 = 0;
            isslah = true;
            frdi.SetActive(true);
            ISferdi = true;
            ISGAUN = false;
            M16.SetActive(false);
           // iskatana = false;
          //  katana.SetActive(false);
            isshootgan = false;
            issnaiper = false;
            snaiper.SetActive(false);
            shotgan.SetActive(false);
        }
        //M16
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (weaponnum2 == 1)
            {
                weaponnum2 = 0;
            }
            else
            {
                weaponnum2 += 1;
            }
        }
        if (weaponnum2 == 0)
        {
            if (/*weaponnum5 != 1 &&*/ weaponnum != 1 && weaponnum3 != 1 && weaponnum4 != 1)
            {
                isslah = false;

            }

        }
        if (weaponnum2 == 1)
        {
            weaponnum = 0;
           // weaponnum5 = 0;
            weaponnum3 = 0;
            weaponnum4 = 0;
            isslah = true;
            ISGAUN = true;
            M16.SetActive(true);
            frdi.SetActive(false);
            ISferdi = false;
            //iskatana = false;
           // katana.SetActive(false);
            isshootgan = false;
            issnaiper = false;
            snaiper.SetActive(false);
            shotgan.SetActive(false);

        }
        //SHOTGUN
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (weaponnum3 == 1)
            {
                weaponnum3 = 0;
            }
            else
            {
                weaponnum3 += 1;
            }
        }
        if (weaponnum3 == 0)
        {
            if (weaponnum2 != 1 && weaponnum != 1/* && weaponnum5 != 1*/ && weaponnum4 != 1)
            {
                isslah = false;

            }

        }
        if (weaponnum3 == 1)
        {
            weaponnum = 0;
            weaponnum2 = 0;
            //weaponnum5 = 0;
            weaponnum4 = 0;
            isslah = true;
            frdi.SetActive(false);
            M16.SetActive(false);
           // katana.SetActive(false);
            snaiper.SetActive(false);
            shotgan.SetActive(true);
            ISGAUN = false;
            ISferdi = false;
           // iskatana = false;
            isshootgan = true;
            issnaiper = false;
        }
        //SNAIPER
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (weaponnum4 == 1)
            {
                weaponnum4 = 0;
            }
            else
            {
                weaponnum4 += 1;
            }
        }
        if (weaponnum4 == 0)
        {
            if (weaponnum2 != 1 && weaponnum != 1 && weaponnum3 != 1 /*&& weaponnum5 != 1*/)
            {
                isslah = false;

            }

        }
        if (weaponnum4 == 1)
        {
            weaponnum = 0;
            weaponnum2 = 0;
            weaponnum3 = 0;
            //weaponnum5 = 0;
            isslah = true;
            frdi.SetActive(false);
            M16.SetActive(false);
          //  katana.SetActive(false);
            snaiper.SetActive(true);
            shotgan.SetActive(false);
            ISGAUN = false;
            ISferdi = false;
          //  iskatana = false;
            isshootgan = false;
            issnaiper = true;
        }
        /*
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (weaponnum5 == 1)
            {
                weaponnum5 = 0;
            }
            else
            {
                weaponnum5 += 1;
            }
        }
        if (weaponnum5 == 0)
        {
            if (weaponnum2 != 1 && weaponnum != 1 && weaponnum3 != 1 && weaponnum4 != 1)
            {
                isslah = false;

            }

        }
        if (weaponnum5 == 1)
        {
            weaponnum = 0;
            weaponnum2 = 0;
            weaponnum3 = 0;
            weaponnum4 = 0;


            isslah = true;
            frdi.SetActive(false);
            M16.SetActive(false);
            katana.SetActive(true);
            snaiper.SetActive(false);
            shotgan.SetActive(false);
            ISGAUN = false;
            ISferdi = false;
            iskatana = true;
            isshootgan = false;
            issnaiper = false;
        }
        */

        if (isslah == false)
        {
            islaithg = true;
            litgh.SetActive(true);
            //
            isslah = false;
            frdi.SetActive(false);
            M16.SetActive(false);
          //  katana.SetActive(false);
            snaiper.SetActive(false);
            shotgan.SetActive(false);
            ISGAUN = false;
            ISferdi = false;
          //  iskatana = false;
            isshootgan = false;
            issnaiper = false;

        }
        else
        {
            litgh.SetActive(false);
            islaithg = false;
        }
    }
}
