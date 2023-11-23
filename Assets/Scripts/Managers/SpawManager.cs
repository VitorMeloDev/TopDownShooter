using UnityEngine;

public class SpawManager : MonoBehaviour
{
    [SerializeField] private float timeSpaw;
    [SerializeField] private float currentTime;
    [SerializeField] private Transform[] spawPoints;
    [SerializeField] private GameObject[] enemies;

    void Start()
    {
        currentTime = timeSpaw;
    }
    
    // Update is called once per frame
    void Update()
    {
        SpawEnemies();
    }

    void SpawEnemies()
    {
        currentTime -= Time.deltaTime;

        if(currentTime <= 0)
        {
            currentTime = timeSpaw; 
            Instantiate(enemies[Random.Range(0, enemies.Length)], spawPoints[Random.Range(0, spawPoints.Length)].position, Quaternion.identity);
        }
    }
}
