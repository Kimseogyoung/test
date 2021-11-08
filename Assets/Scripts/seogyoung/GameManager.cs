using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   //���������� �� �ε�
    //���� �� 
    //�÷��̾� ���ӿ��� ���°���
    //ui ����
    public StageManager[] maps;
    public int mapIdx = 0;
    private StageManager stage;

    private bool isGameOver = false;
    private int wave;
    private int waveEnemyCnt;
    private int currentEnemyCnt;
    // Start is called before the first frame update
    void Start()
    {
        stage = Instantiate(maps[mapIdx]);
        
        stage.LoadMap();
        //currentEnemyCnt = waveEnemyCnt;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            stage.CreateEnemy();
        }
    }
}
