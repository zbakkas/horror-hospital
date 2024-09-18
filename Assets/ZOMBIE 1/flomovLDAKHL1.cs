using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class flomovLDAKHL1 : MonoBehaviour
{
    //TAJWAL
    public Transform[] pos;

    int randomdes;
    //TATBO3 player
    public Transform player;
    public float chaserenge;
    NavMeshAgent nav;
    public float distoplayer = Mathf.Infinity;
    //TIME
    private float waittime;
    public float starwaitetime =1f;

    public float chaserengeattack;
    public Animator anim;

    public float spedmov;
    public float spedsee;
    public zombiehilth s;
    public hilthplayer z;
    public float damage = 10f;

    public bool moov = false;
    public bool atttckk = false;
    public bool raaaaan = false;

    float hilthzombie;
    // Start is called before the first frame update
    void Start()
    {
        hilthzombie = s.hilth;
        nav = GetComponent<NavMeshAgent>();

        waittime = starwaitetime;

        randomdes = Random.Range(0, pos.Length);

        pos = new Transform[2];
        pos[0] = GameObject.Find("P2 (1)").transform;
        pos[1] = GameObject.Find("P2 (2)").transform;


    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Player").transform;
        
        distoplayer = Vector3.Distance(player.position, transform.position);

        if(distoplayer > chaserenge && s.hilth >= hilthzombie)
        {
            patrol();
            moov = true;
            raaaaan = false;
            atttckk = false;
        }
        else if (distoplayer <= chaserenge )
        {
            attackplayer();
            
        }
        else if(s.hilth < hilthzombie)
        {
            if (s.hilth >0)
            {
                nav.SetDestination(player.position);
                if (distoplayer > chaserenge)
                {
                    anim.SetFloat("mov", 0.5f);
                    nav.speed = spedsee;

                }
            }
            if(s.hilth <= 0)
            {
                nav.speed = 0;

            }
            

                   
        }
        else
        {
            raaaaan = false;
            atttckk = false;
            moov = false;
        }
    }

    void attackplayer()
    {
        if (distoplayer > chaserengeattack && s.hilth > 0)
        {
            folo();
            raaaaan = true;
            atttckk = false;
            moov = false;
        }
        else if (distoplayer <= chaserengeattack && s.hilth > 0)
        {
            atack();
            atttckk = true;
            raaaaan = false;
            raaaaan = false;
        }
        else
        {
            anim.SetBool("attack", false);
            raaaaan = false;
            atttckk = false;
            moov = false;
        }
       
    }

    void folo()
    {
        nav.SetDestination(player.position);
        nav.speed = spedsee;
        anim.SetFloat("mov", 0.5f);
        anim.SetBool("attack", false);
        //
       

    }

    void atack()
    {
        nav.speed = 0;
        //tatbo3 rotation player
        Vector3 movdir = player.transform.position - transform.position;
        float angle = Mathf.Atan2(movdir.x, movdir.z) * Mathf.Rad2Deg + movdir.y;
        transform.rotation = Quaternion.Euler(0, angle, 0);
        //
        anim.SetBool("attack", true);
        //
    

    }

    void patrol()
    {
        nav.SetDestination(pos[randomdes].position);

        //
        nav.speed = spedmov;
        anim.SetFloat("mov", 0f);
        //

        if (Vector3.Distance(transform.position, pos[randomdes].position) < 2f)
        {
            if (waittime <= 0)
            {
                randomdes = Random.Range(0, pos.Length);
                waittime = starwaitetime;
            }
            else
            {
                waittime -= Time.deltaTime;
            }
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, chaserenge);
        Gizmos.DrawWireSphere(transform.position, chaserengeattack);
    }

    public void atttack()
    {
        z = GameObject.Find("Player").GetComponent<hilthplayer>();
        Debug.Log("attach");
        z.hilthpl(damage);

    }
}
