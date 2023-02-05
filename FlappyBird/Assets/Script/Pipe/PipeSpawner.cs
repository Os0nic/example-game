using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeSpawner : MonoBehaviour
{
 
    
    [SerializeField] private GameObject pipe;
    [SerializeField] private float timer = 0;
    [SerializeField] private float heightOffset = 1.1f;
    [SerializeField] private float spawnRate;
    [SerializeField] private float _elapsedTime;

    private bool startSpawn;
    
    private void Start()
    {
        // //В начале игры:
        // //Устанавливается рандомное значение через сколько появится скала
        // spawnRate = Random.Range(3, 7);
        //
        // //Спавнится скала
        // _SpawnPipe();
        
        
        startSpawn = false;
    }

    private void Update()
    {
        if (!startSpawn) return;
        
        //Каждый кадр ведется отсчет продолжительности игры
        _elapsedTime += Time.deltaTime;
        
        //Если время игры 30 секунд, то происходит запуск усложненного спавна
        if (_elapsedTime >= 30) spawnRate = Random.Range(3, 4);

        //Если время игры 90 секунд, то происходит запуск усложненного спавна
        if (_elapsedTime >= 90) spawnRate = Random.Range(2, 3);

        //Если время таймера меньше значения через сколько появится,
        //то запускается отсчет таймера
        if (timer < spawnRate) timer += Time.deltaTime;

        //Когда таймер стал больше, чем spawnRate,
        //спавнится скала и таймер сбрасывается
        //А затем, опять рандомизируется через сколько произойдет след спавн
        if (timer >= spawnRate && _elapsedTime <= 120) EnableSpawnPipe(3, 7);

        //если таймер больше или равен спавну
        //и при этом продолжительность игры больше 120 сек
        //Вызывается метод спавна и рандомизации чисел
        
        if (timer >= spawnRate && _elapsedTime >= 120) EnableSpawnPipe(2,3);
    }

    private void _SpawnPipe()
     {
         var lowestPoint = transform.position.y - heightOffset;
         var highesPoint = transform.position.y + heightOffset;
         
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint, highesPoint), 0), transform.rotation);
    }

     public void EnableSpawnPipe(int firstNumber, int secondNumber)
     {
         _SpawnPipe();
         timer = 0;
         spawnRate = Random.Range(firstNumber, secondNumber);
     }

     
}
