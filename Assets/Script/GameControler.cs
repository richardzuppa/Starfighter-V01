using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{

    public GameObject hazard;
    public GameObject hazard2;
    public GameObject hazard3;
    public GameObject hazard4;

    public Vector3 spawnValues;

    public int hazardCount;
    public float spawnWait;
    public float startWait;

    public int hazardCount2;
    public float spawnWait2;
    public float startWait2;

    public int hazardCount3;
    public float spawnWait3;
    public float startWait3;

    public int hazardCount4;
    public float spawnWait4;
    public float startWait4;

    public Text scoreText;
    private int score;


    private void Start()
    {
        score = 0;
        UpdateScore ();
        StartCoroutine (SpawnWaves());
        StartCoroutine (SpawnWaves2());
        StartCoroutine (SpawnWaves3());
        StartCoroutine (SpawnWaves4());
        Debug.Log("Comeco do jogo");
    }


    // Spawn Asteroide 1

    IEnumerator SpawnWaves ()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-11, 17), 0, 9);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
        }
    }

    // Spawn Asteroide 2
    IEnumerator SpawnWaves2()
    {
        yield return new WaitForSeconds(startWait2);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition2 = new Vector3(Random.Range(-11, 17), 0, -8);
                Quaternion spawnRotation2 = Quaternion.identity;
                Instantiate(hazard2, spawnPosition2, spawnRotation2);
                yield return new WaitForSeconds(spawnWait2);
            }
        }
    }

    // Spawn Bomb
    IEnumerator SpawnWaves3()
    {
        yield return new WaitForSeconds(startWait2);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition3 = new Vector3(Random.Range(-11, 17), 0, -8);
                Quaternion spawnRotation3 = Quaternion.identity;
                Instantiate(hazard3, spawnPosition3, spawnRotation3);
                yield return new WaitForSeconds(spawnWait3);
            }
        }
    }

    // Spawn powerup
    IEnumerator SpawnWaves4()
    {
        yield return new WaitForSeconds(startWait2);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition4 = new Vector3(Random.Range(-11, 17), 0, -8);
                Quaternion spawnRotation4 = Quaternion.identity;
                Instantiate(hazard4, spawnPosition4, spawnRotation4);
                yield return new WaitForSeconds(spawnWait4);
            }
        }
    }

    public void Addscore (int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore ();
    }

    void UpdateScore ()
    {
        scoreText.text = "Score: " + score;
    }
}
