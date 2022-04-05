using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Tile : MonoBehaviour
{
    public bool row1;
    public bool row2;
    public bool row3;
    public bool row4;
    public bool isDisabled;

    public int currentRow;

    public int towerLayer;
    public int towerShieldLayer;
    public int towerGotHitLayer;
    public int towerBasicProjectileLayer;
    public int towerSniperProjectile;
    public int enemyGotHit;
    public int enemyGotHitExplosion;
    public int coinLayer;

    public CanvasTile myCanvasTrigger;

    public Placeable toPlace;

    public GameObject basicTower;
    public SpriteRenderer basicTowerRenderer;

    public GameObject tankTower;
    public SpriteRenderer tankTowerRenderer;

    public GameObject sniperTower;
    public SpriteRenderer sniperTowerRenderer;

    public GameObject generator;
    public SpriteRenderer generatorRenderer;

    private void Start()
    {
        basicTowerRenderer = basicTower.GetComponentInChildren<SpriteRenderer>();
        tankTowerRenderer = tankTower.GetComponentInChildren<SpriteRenderer>();
        sniperTowerRenderer = sniperTower.GetComponentInChildren<SpriteRenderer>();
        generatorRenderer = generator.GetComponentInChildren<SpriteRenderer>();
        myCanvasTrigger.myEvent.AddListener(Comence);
    }

    public void Place()
    {
        if (row1)
        {
            currentRow = 1;

            if (toPlace.towerType == "BasicTower")
            {
                basicTowerRenderer.sortingOrder = towerLayer + 7 * currentRow;
                basicTower.GetComponentInChildren<BasicTower>().projectile.GetComponent<SpriteRenderer>().sortingOrder = towerBasicProjectileLayer + 7 * currentRow;
                basicTower.GetComponentInChildren<BasicTower>().projectile.GetComponent<BasicTowerProjectile>().explosion.GetComponent<SpriteRenderer>().sortingOrder = enemyGotHit + 7 * currentRow;
                Instantiate(basicTower,this.gameObject.transform.position,new Quaternion(0,0,0,0));
            }
            else if (toPlace.towerType == "TankTower")
            {
                tankTowerRenderer.sortingOrder = towerLayer + 7 * currentRow;
                tankTower.GetComponentInChildren<TankTower>().shieldRenderer.sortingOrder = towerShieldLayer + 7 * currentRow;
                Instantiate(tankTower, this.gameObject.transform.position, new Quaternion(0, 0, 0, 0));
            }
            else if (toPlace.towerType == "SniperTower")
            {
                sniperTowerRenderer.sortingOrder = towerLayer + 7 * currentRow;
                sniperTower.GetComponentInChildren<SniperTower>().projectile.GetComponent<SpriteRenderer>().sortingOrder = towerSniperProjectile + 7 * currentRow;
                sniperTower.GetComponentInChildren<SniperTower>().projectile.GetComponent<SniperProjectile>().explosion.GetComponent<SpriteRenderer>().sortingOrder = enemyGotHitExplosion + 7 * currentRow;
                Instantiate(sniperTower,this.gameObject.transform.position,new Quaternion(0,0,0,0));
            }
            else if (toPlace.towerType == "Generator")
            {
                generatorRenderer.sortingOrder = towerLayer + 7 * currentRow;
                generator.GetComponentInChildren<GeneratorTower>().projectile.GetComponent<SpriteRenderer>().sortingOrder = coinLayer + 7 * currentRow;
                Instantiate(generator,this.gameObject.transform.position,new Quaternion(0,0,0,0));
            }
        }
        else if (row2)
        {
            currentRow = 2;

            if (toPlace.towerType == "BasicTower")
            {
                basicTowerRenderer.sortingOrder = towerLayer + 7 * currentRow;
                basicTower.GetComponentInChildren<BasicTower>().projectile.GetComponent<SpriteRenderer>().sortingOrder = towerBasicProjectileLayer + 7 * currentRow;
                basicTower.GetComponentInChildren<BasicTower>().projectile.GetComponent<BasicTowerProjectile>().explosion.GetComponent<SpriteRenderer>().sortingOrder = enemyGotHit + 7 * currentRow;
                Instantiate(basicTower,this.gameObject.transform.position,new Quaternion(0,0,0,0));
            }
            else if (toPlace.towerType == "TankTower")
            {
                tankTowerRenderer.sortingOrder = towerLayer + 7 * currentRow;
                tankTower.GetComponentInChildren<TankTower>().shieldRenderer.sortingOrder = towerShieldLayer + 7 * currentRow;
                Instantiate(tankTower,this.gameObject.transform.position,new Quaternion(0,0,0,0));
            }
            else if (toPlace.towerType == "SniperTower")
            {
                sniperTowerRenderer.sortingOrder = towerLayer + 7 * currentRow;
                sniperTower.GetComponentInChildren<SniperTower>().projectile.GetComponent<SpriteRenderer>().sortingOrder = towerSniperProjectile + 7 * currentRow;
                sniperTower.GetComponentInChildren<SniperTower>().projectile.GetComponent<SniperProjectile>().explosion.GetComponent<SpriteRenderer>().sortingOrder = enemyGotHitExplosion + 7 * currentRow;
                Instantiate(sniperTower,this.gameObject.transform.position,new Quaternion(0,0,0,0));
            }
            else if (toPlace.towerType == "Generator")
            {
                generatorRenderer.sortingOrder = towerLayer + 7 * currentRow;
                generator.GetComponentInChildren<GeneratorTower>().projectile.GetComponent<SpriteRenderer>().sortingOrder = coinLayer + 7 * currentRow;
                Instantiate(generator,this.gameObject.transform.position,new Quaternion(0,0,0,0));
            }
        }
        else if (row3)
        {
            currentRow = 3;

            if (toPlace.towerType == "BasicTower")
            {
                basicTowerRenderer.sortingOrder = towerLayer + 7 * currentRow;
                basicTower.GetComponentInChildren<BasicTower>().projectile.GetComponent<SpriteRenderer>().sortingOrder = towerBasicProjectileLayer + 7 * currentRow;
                basicTower.GetComponentInChildren<BasicTower>().projectile.GetComponent<BasicTowerProjectile>().explosion.GetComponent<SpriteRenderer>().sortingOrder = enemyGotHit + 7 * currentRow;
                Instantiate(basicTower,this.gameObject.transform.position,new Quaternion(0,0,0,0));
            }
            else if (toPlace.towerType == "TankTower")
            {
                tankTowerRenderer.sortingOrder = towerLayer + 7 * currentRow;
                tankTower.GetComponentInChildren<TankTower>().shieldRenderer.sortingOrder = towerShieldLayer + 7 * currentRow;
                Instantiate(tankTower,this.gameObject.transform.position,new Quaternion(0,0,0,0));
            }
            else if (toPlace.towerType == "SniperTower")
            {
                sniperTowerRenderer.sortingOrder = towerLayer + 7 * currentRow;
                sniperTower.GetComponentInChildren<SniperTower>().projectile.GetComponent<SpriteRenderer>().sortingOrder = towerSniperProjectile + 7 * currentRow;
                sniperTower.GetComponentInChildren<SniperTower>().projectile.GetComponent<SniperProjectile>().explosion.GetComponent<SpriteRenderer>().sortingOrder = enemyGotHitExplosion + 7 * currentRow;
                Instantiate(sniperTower,this.gameObject.transform.position,new Quaternion(0,0,0,0));
            }
            else if (toPlace.towerType == "Generator")
            {
                generatorRenderer.sortingOrder = towerLayer + 7 * currentRow;
                generator.GetComponentInChildren<GeneratorTower>().projectile.GetComponent<SpriteRenderer>().sortingOrder = coinLayer + 7 * currentRow;
                Instantiate(generator,this.gameObject.transform.position,new Quaternion(0,0,0,0));
            }
        }
        else if (row4)
        {
            currentRow = 4;

            if (toPlace.towerType == "BasicTower")
            {
                basicTowerRenderer.sortingOrder = towerLayer + 7 * currentRow;
                basicTower.GetComponentInChildren<BasicTower>().projectile.GetComponent<SpriteRenderer>().sortingOrder = towerBasicProjectileLayer + 7 * currentRow;
                basicTower.GetComponentInChildren<BasicTower>().projectile.GetComponent<BasicTowerProjectile>().explosion.GetComponent<SpriteRenderer>().sortingOrder = enemyGotHit + 7 * currentRow;
                Instantiate(basicTower,this.gameObject.transform.position,new Quaternion(0,0,0,0));
            }
            else if (toPlace.towerType == "TankTower")
            {
                tankTowerRenderer.sortingOrder = towerLayer + 7 * currentRow;
                tankTower.GetComponentInChildren<TankTower>().shieldRenderer.sortingOrder = towerShieldLayer +7* currentRow;
                Instantiate(tankTower,this.gameObject.transform.position,new Quaternion(0,0,0,0));
            }
            else if (toPlace.towerType == "SniperTower")
            {
                sniperTowerRenderer.sortingOrder = towerLayer + 7 * currentRow;
                sniperTower.GetComponentInChildren<SniperTower>().projectile.GetComponent<SpriteRenderer>().sortingOrder = towerSniperProjectile + 7 * currentRow;
                sniperTower.GetComponentInChildren<SniperTower>().projectile.GetComponent<SniperProjectile>().explosion.GetComponent<SpriteRenderer>().sortingOrder = enemyGotHitExplosion + 7 * currentRow;
                Instantiate(sniperTower,this.gameObject.transform.position,new Quaternion(0,0,0,0));
            }
            else if (toPlace.towerType == "Generator")
            {
                generatorRenderer.sortingOrder = towerLayer + 7 * currentRow;
                generator.GetComponentInChildren<GeneratorTower>().projectile.GetComponent<SpriteRenderer>().sortingOrder = coinLayer + 7 * currentRow;
                Instantiate(generator,this.gameObject.transform.position,new Quaternion(0,0,0,0));
            }
        }
    }

    public void Comence(Collider2D collider2D)
    {
        if (isDisabled == false)
        {
            if (collider2D.gameObject.CompareTag("Placeable"))
            {
                toPlace = collider2D.gameObject.GetComponent<Placeable>();
                Place();
                Destroy(collider2D.gameObject);
            }
        }
    }
}
