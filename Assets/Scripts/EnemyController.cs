using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
   public float speed = 8f;

    // Update is called once per frame
    void Update()
    {
      Vector3 temp = transform.position;
      temp.y -= speed * Time.deltaTime;
      transform.position = temp;

      if (transform.position.y < -7)
         gameObject.SetActive(false);
    }
} // class
