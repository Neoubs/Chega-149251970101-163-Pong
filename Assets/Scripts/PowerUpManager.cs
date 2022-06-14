using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public int maxPU;
    public Transform spawnArea; 
    public List<GameObject> poweruptemplatelist;
    private List<GameObject> poweruplist;
    public Vector2 powerupareamin;
    public Vector2 powerupareamax;
    private float timer;
    public int SpawnInterval;

    private void Start()
    {
        poweruplist = new List<GameObject>();
    }

    
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > SpawnInterval)
        {
            GenerateRandomPowerUp();
            timer -= SpawnInterval;
        }
    }


    public void GenerateRandomPowerUp()
    {
        GenerateRandomPowerUp(new Vector2(Random.Range(powerupareamin.x,powerupareamax.x) , Random.Range(powerupareamin.y, powerupareamax.y)));
    }

    
    
    public void GenerateRandomPowerUp(Vector2 position) 
    { 
        if (poweruplist.Count >= maxPU) 
        { 
            RemovePowerUp(poweruplist[0]);
            return; 
        } 
 
        if (position.x < powerupareamin.x || 
            position.x > powerupareamax.x || 
            position.y < powerupareamin.y || 
            position.y > powerupareamax.y) 
        { 
            return; 
        } 
 
        int randomIndex = Random.Range(0, poweruptemplatelist.Count); 
 
        GameObject powerUp = Instantiate(poweruptemplatelist[randomIndex], new Vector3(position.x, position.y, poweruptemplatelist[randomIndex].transform.position.z), Quaternion.identity, spawnArea); 
        powerUp.SetActive(true); 
 
        poweruplist.Add(powerUp); 
    } 

    public void RemovePowerUp(GameObject powerup)
    {
        poweruplist.Remove(powerup);
        Destroy(powerup);
    }

    public void RemoveAllPowerUp()
    {
        while (poweruplist.Count > 0)
        {
            RemovePowerUp(poweruplist[0]);
        }
    }

} 

