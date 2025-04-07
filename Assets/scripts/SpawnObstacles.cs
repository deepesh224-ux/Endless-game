using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float mixX;
    public float maxY;
    public float mixY;
    public float timeBetweenSpawn;
    private float spawnTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime=Time.time+timeBetweenSpawn;
        }
    }
    void Spawn()
    {
        float randomX = Random.Range(mixX,maxX);
        float randomY = Random.Range(mixY,maxY);
        Instantiate(obstacle, transform.position + new Vector3(randomX,randomY,0),transform.rotation);
    }
}
