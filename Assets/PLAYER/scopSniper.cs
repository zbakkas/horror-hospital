using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scopSniper : MonoBehaviour
{
    public GameObject camSniper;
    public WOAPENdesplay woapen;
    public bool isshot;
    public relodTime relod;
    // Start is called before the first frame update
    void Start()
    {
        camSniper.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isshot = true;
            StartCoroutine(relodttime());
        }
        

        if(woapen.issnaiper == true && Input.GetMouseButton(1) && isshot == false && relod.relod == false)
        {
            camSniper.SetActive(true);

            
        }
        else if (Input.GetMouseButton(1) && isshot == true)
        {
            camSniper.SetActive(false);
        }
        else
        {
            camSniper.SetActive(false);
        }
    }
    IEnumerator relodttime()
    {
        yield return new WaitForSeconds(1.9f);
        isshot = false;
    }
}
