using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private Rigidbody2D myRigidbody2D;
    [SerializeField] private float flapStrenght = 10f;
    [SerializeField] private LogicScript logic;
    private bool _birdIsActive = false;
    
    private void Start()
    {
        
        
        // var logicObject = GameObject.FindWithTag("Logic");
        // //если такой тег есть, то вернуть
        // if (logicObject != null) logic = logicObject.GetComponent<LogicScript>();
    }
    
    private void Update()
    {
        if ((Input.GetButtonDown("Jump") || Input.touchCount > 0))
        {
            myRigidbody2D.velocity = Vector2.up * flapStrenght;
            _birdIsActive = true;
        }
        MassCheckControl();
    }

    //метод устанавливает гравитацию на 0, если не кликнул на экран
    private void MassCheckControl()
    {
        if (_birdIsActive == false)
        {
            myRigidbody2D.simulated = false;
        }
        if (_birdIsActive)
        {
            myRigidbody2D.simulated = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // logic.GameOver();
        _birdIsActive = false;
    }
}
