using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
   public GameObject[] enemies;
   public float minX = -2.6f, maxX = 2.6f;

   public float delayTimer = 0.5f;
   private float timer;

    // Update is called once per frame
    void Update()
    {
      timer -= Time.deltaTime;

      if (timer <= 0)
      {
         Vector3 temp = transform.position;
         temp.x = Random.Range(minX, maxX);

         int rand = Random.Range(0, enemies.Length);
         Instantiate(enemies[rand], temp, enemies[rand].transform.rotation);

         timer = delayTimer;
      }
    }
} // class
