using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{

    
    public int PoolSize = 10;
    public float spawnRate = 4f;
    

    

    public float ymin = -2f;
    public float ymax = 2f;
    public float xmin = -2f;
    public float xmax = 4f;

    
    private Vector2 objectpoolposition = new Vector2(1500f,1500f);
    private float timeSinceLastSpawned;

    private GameObject[] meteors;
    public int curren = 0;

    Vector2 wheretoSpawn;
    

    public GameObject meterors;
   


    // Start is called before the first frame update
    void Start()
    {
        GameControl.instance.Score = 0;
        meteors = new GameObject[PoolSize];
        for(int i=0; i < PoolSize; i++)
        {
           meteors[i] = (GameObject)Instantiate(meterors, objectpoolposition, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {

        timeSinceLastSpawned += Time.deltaTime;
        

        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnXpos = Random.Range(xmin, xmax);
            float spawnYpos = Random.Range(ymin, ymax);

            

            wheretoSpawn = new Vector2(spawnXpos,spawnYpos);
            meteors[curren].transform.position = wheretoSpawn;

            curren++;
            if(curren >= PoolSize)
            {
                curren = 0;
            }

            //Instantiate(meterors, wheretoSpawn, Quaternion.identity);
            
        }

       

    }
}
