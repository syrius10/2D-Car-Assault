﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
   public float speed = 10f;
   private Vector3 myPosition;

    // Start is called before the first frame update
    void Start()
    {
      myPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      myPosition.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
      transform.position = myPosition;
    }

   void OnTriggerEnter2D(Collider2D target)
   {
      if (target.tag == "Enemy")
         UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
   }
} // class
