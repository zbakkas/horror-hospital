using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hilthplayer : MonoBehaviour
{
    public float hilthPlayer, maxhilth = 100f;
    public mawt z;

    public Image hilthpar;

    public void Update()
    {
        hilthpar.fillAmount = hilthPlayer / maxhilth;
       

    }
    public void hilthpl(float damage)
    {
        hilthPlayer -= damage;
        if (hilthPlayer <= 0)
        {
            z.matt();
            //Debug.Log("maaaatplayer");
        }
    }
}
