using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTile : MonoBehaviour
{
    public bool row1;
    public bool row2;
    public bool row3;
    public bool row4;
    public float time;

    public List<GameObject> enemies = new List<GameObject>();
    public List<SpriteRenderer> enemyRenderers = new List<SpriteRenderer>();

    public GameObject basicEnemy;
    public GameObject heavyEnemy;
    public GameObject mothEnemy;
    public GameObject stunnerEnemy;

    public int currentRow;

    public int enemyLayer;
    public int towerGotHitLayer;
    public int enemyBasicProjectileLayer;

    public SpriteRenderer basicEnemyRenderer;
    public SpriteRenderer heavyEnemyRenderer;
    public SpriteRenderer mothEnemyRenderer;
    public SpriteRenderer StunnerRenderer;

    private void Start()
    {
        enemies.Add(basicEnemy);
        enemies.Add(heavyEnemy);
        enemies.Add(mothEnemy);
        enemies.Add(stunnerEnemy);
        basicEnemyRenderer = basicEnemy.GetComponent<SpriteRenderer>();
        heavyEnemyRenderer = heavyEnemy.GetComponent<SpriteRenderer>();
        StunnerRenderer = stunnerEnemy.GetComponent<SpriteRenderer>();
        mothEnemyRenderer = mothEnemy.GetComponent<SpriteRenderer>();
        enemyRenderers.Add(basicEnemyRenderer);
        enemyRenderers.Add(heavyEnemyRenderer);
        enemyRenderers.Add(mothEnemyRenderer);
        enemyRenderers.Add(StunnerRenderer);
    }

    public void SpawnEnemy(int max, int enemies)
    {
        CommenceSpawning(Random.Range(1, max), enemies);
    }

    public void CommenceSpawning(int amount, int enemy)
    {
        if (row1)
        {
            currentRow = 1;
            enemyRenderers[enemy].sortingOrder = enemyLayer;
            enemies[enemy].GetComponent<BaseEnemy>().projectile.GetComponent<SpriteRenderer>().sortingOrder = enemyBasicProjectileLayer*currentRow;
            enemies[enemy].GetComponent<BaseEnemy>().projectile.GetComponent<EnemyBasicProjectile>().explosion.GetComponent<SpriteRenderer>().sortingOrder = towerGotHitLayer * currentRow;
            for (int i = 0; i < amount; i++)
            {
                Instantiate(enemies[enemy], this.gameObject.transform.position, new Quaternion(0, 0, 0, 0));
            }
        }
        else if (row2)
        {
            currentRow = 2;
            enemyRenderers[enemy].sortingOrder = enemyLayer;
            enemies[enemy].GetComponent<BaseEnemy>().projectile.GetComponent<SpriteRenderer>().sortingOrder = enemyBasicProjectileLayer * currentRow;
            enemies[enemy].GetComponent<BaseEnemy>().projectile.GetComponent<EnemyBasicProjectile>().explosion.GetComponent<SpriteRenderer>().sortingOrder = towerGotHitLayer * currentRow;
            for (int i = 0; i < amount; i++)
            {
                Instantiate(enemies[enemy], this.gameObject.transform.position, new Quaternion(0, 0, 0, 0));
            }
        }
        else if (row3)
        {
            currentRow = 3;
            enemyRenderers[enemy].sortingOrder = enemyLayer;
            enemies[enemy].GetComponent<BaseEnemy>().projectile.GetComponent<SpriteRenderer>().sortingOrder = enemyBasicProjectileLayer * currentRow;
            enemies[enemy].GetComponent<BaseEnemy>().projectile.GetComponent<EnemyBasicProjectile>().explosion.GetComponent<SpriteRenderer>().sortingOrder = towerGotHitLayer * currentRow;
            for (int i = 0; i < amount; i++)
            {
                for(float j = 0; i < 20;)
                {
                    j += Time.time * Time.deltaTime;
                }
                Instantiate(enemies[enemy], this.gameObject.transform.position, new Quaternion(0, 0, 0, 0));
            }
        }
        else if (row4)
        {
            currentRow = 4;
            enemyRenderers[enemy].sortingOrder = enemyLayer;
            enemies[enemy].GetComponent<BaseEnemy>().projectile.GetComponent<SpriteRenderer>().sortingOrder = enemyBasicProjectileLayer * currentRow;
            enemies[enemy].GetComponent<BaseEnemy>().projectile.GetComponent<EnemyBasicProjectile>().explosion.GetComponent<SpriteRenderer>().sortingOrder = towerGotHitLayer * currentRow;
            for (int i = 0; i < amount; i++)
            {
                Instantiate(enemies[enemy], this.gameObject.transform.position, new Quaternion(0, 0, 0, 0));
            }
        }

    }
}
