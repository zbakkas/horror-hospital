using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TAJACTEV : MonoBehaviour
{
    public GameObject respon1;
    public GameObject respon2;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        respon1.SetActive(true);
        respon2.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "sansor1" && Input.GetKeyDown(KeyCode.E))
        {
            respon1.SetActive(false);
            respon2.SetActive(true);
            
            player.transform.position = new Vector3(-135.14f, -2.71f, -1947.3f);
        }
        
        if (other.gameObject.tag == "sansor2" && Input.GetKeyDown(KeyCode.E) )
        {
            player.transform.position = new Vector3(-144.8f, -0.5f, -1946);
            respon1.SetActive(true);
            respon2.SetActive(false);
        }
    }
}
