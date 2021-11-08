using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class StageManager : MonoBehaviour
{//enemyspowner�� �ٸ�����
    private Transform[] wayPoints;

    public Tilemap tileMap;
    public GameObject pointTiles;
    public int startCoin;

    public GameObject[] enemy;

    public  List<Enemy> enemies=new List<Enemy>();//������ ����
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void LoadMap()
    {
        wayPoints = pointTiles.GetComponentsInChildren<Transform>();
    }
    public Transform[] GetWayPoints()
    {
        return wayPoints;
    }
    public void CreateEnemy()
    {
        //���� ����
        GameObject cat = Instantiate(enemy[0]);
        Enemy _enemy = cat.GetComponent<Enemy>();
        _enemy.SetUp(wayPoints);

        //����Ʈ�� �߰�
        enemies.Add(_enemy);

        //����Ʈ���� ����
        _enemy.OnDeath += () => enemies.Remove(_enemy);
        //���� �� ��,��ȭ ���� (gm�޼ҵ�)
        //_enemy.OnDeath += () => 

        //����� ������ ���� �� ���ӿ��� ���� �޼���
        //_enemy.OnSurvive += () =>


    }

}
