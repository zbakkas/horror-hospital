using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class responzombie : MonoBehaviour
{

    public GameObject[] enemy;
    public Transform[] spawnenemy;
    public GameObject player;
    public int timerispon;

    private void Start()
    {
        StartCoroutine(spawnzombie());

    }
    private void Awake()
    {
       
    }

    private IEnumerator spawnzombie()
    {
        while(player != null)
        {

            GameObject zombie = Instantiate(enemy[Random.Range(0, enemy.Length)], spawnenemy[Random.Range(0, spawnenemy.Length)].position, Quaternion.identity);
            yield return (new WaitForSeconds(timerispon));
        }
    }
}
