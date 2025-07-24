using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    ////variável que armazena o GO asteroide
    //public GameObject hazard;
    ////variável que armazena os pontos de spawn
    //public Vector3 spawnValues;
    ////variável que armazena o número de inimigos por onda
    //public int hazardCount = 10;
    ////variável que armazena o tempo de espera para cada spawn de asteroide
    //public float spawnWait = 0.5f;
    ////variável que armazena o tempo de espera da primeira onda
    //public float startWait = 1f;
    ////variável que armazena o tempo de espera para cada onda de inimigos
    //public float waveWait = 4f;
    
    ////variável para referenciar o componente Text UI Score
    //public Text scoreText;
    ////variável para pontuar
    //public int score;
    ////Criando um atributo estático para a classe
    //public static GameController gc;

    ////variável para referenciar o componente Text UI Restart
    //public Text restartText;
    ////variável para referenciar o componente Text UI Game Over
    //public Text gameOverText;

    ////variável que verifica fim de jogo
    //private bool isGameOver;
    ////variável que verifica reinício do jogo
    //private bool isRestart;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    if (gc == null)
    //    {
    //        gc = gameObject.GetComponent<GameController>();
    //    }

    //    isGameOver = false;
    //    isRestart = false;
    //    gameOverText.text = "";
    //    restartText.text = "";

    //    score = 0;
    //    UpdateScore();
        
    //    //inicia a co-rotina para gerar onda de inimigos
    //    StartCoroutine(SpawnWaves());
    //}

    //private void Update()
    //{
    //    if (isRestart)
    //    {
    //        if (Input.GetKeyDown(KeyCode.R))
    //        {
    //            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //        }
    //    }
    //}

    //IEnumerator SpawnWaves()
    //{
    //    //primeira onda (1s)
    //    yield return new WaitForSeconds(startWait);
    //    while(true)
    //    {
    //        for (int i = 0; i < hazardCount; i++)
    //        {
    //            //Realiza spawn no asteroid dentro da área limite da tela
    //            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x,
    //                spawnValues.x), spawnValues.y, spawnValues.z);
    //            //Inimigos serão spawnados sem nenhuma rotação
    //            Quaternion spawnRotation = Quaternion.identity;
    //            //Instancia os inimigos na posição e rotação definidas acima
    //            Instantiate(hazard, spawnPosition, spawnRotation);
    //            //tempo de espera para cada spawn (0.5s)
    //            yield return new WaitForSeconds(spawnWait);
    //        }
    //        //tempo de espera para cada onda de inimigos (4s)
    //        yield return new WaitForSeconds(waveWait);

    //        if (isGameOver)
    //        {
    //            restartText.text = "Pressione 'R' para Reiniciar";
    //            isRestart = true;
    //            break;
    //        }
    //    }
    //}

    //public void UpdateScore()
    //{
    //    scoreText.text = "Score: " + score;
    //}

    //public void AddScore(int newScoreValue)
    //{
    //    score += newScoreValue;
    //    UpdateScore();
    //}

    //public void GameOver()
    //{
    //    gameOverText.text = "Game Over!";
    //    isGameOver = true;
    //}
}
