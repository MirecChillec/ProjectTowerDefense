using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float currentTime = 0;
    public float timeTillNextWave=30f;
    public int payment=50;

    public int waveCount = 0;

    public SpawnerTile spawner1;
    public SpawnerTile spawner2;
    public SpawnerTile spawner3;
    public SpawnerTile spawner4;

    public List<SpawnerTile> spawners = new List<SpawnerTile>();

    public Money money;
    public Image fill;

    void Start()
    {
        money = GameObject.Find("Money").GetComponent<Money>();

        spawners.Add(spawner1);
        spawners.Add(spawner2);
        spawners.Add(spawner3);
        spawners.Add(spawner4);
    }

    void Update()
    {
        currentTime += Time.time * Time.deltaTime;



        if (currentTime >= timeTillNextWave)
        {
            currentTime = 0;
            timeTillNextWave += timeTillNextWave;

            money.money = payment+payment/100*10;
            waveCount++;
            if (waveCount > 6)
            {
                spawners[Random.Range(0, 3)].SpawnEnemy(1, 3);
                spawners[Random.Range(0, 3)].SpawnEnemy(waveCount-waveCount/4, Random.Range(0, 2));
            }
            else if (waveCount > 4)
            {
                spawners[Random.Range(0, 3)].SpawnEnemy(3 + waveCount / 2, Random.Range(0,2));
            }
            else if(waveCount == 3)
            {
                spawners[Random.Range(0, 3)].SpawnEnemy(3+waveCount/3, 0);
            }
            else if (waveCount < 2)
            {
                spawners[Random.Range(0, 3)].SpawnEnemy(3, 0);
            }
        }

        if (currentTime <= timeTillNextWave)
        {
            fill.fillAmount = 1 - currentTime / timeTillNextWave;
        }

        Debug.Log(currentTime);
    }

    public void NextWave()
    {
        currentTime = timeTillNextWave;
    }
}
