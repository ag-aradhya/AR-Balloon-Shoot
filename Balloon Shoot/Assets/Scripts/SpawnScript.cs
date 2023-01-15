using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] balloons;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning(0));
    }
    IEnumerator StartSpawning(int j)
    {
       yield return new WaitForSeconds(3);
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds((i+3*j)%5);
            Instantiate(balloons[i], spawnPoints[(i+j)%3].position, Quaternion.identity);
            j++;
        }
        StartCoroutine(StartSpawning(j));
    }
}
