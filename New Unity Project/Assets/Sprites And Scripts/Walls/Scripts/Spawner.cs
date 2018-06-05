using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject WallPrefab;
    public Color[] Colors;


    // Use this for initialization
    void Start()
    {

        StartCoroutine(SpawnWall());

    }

    // Update is called once per frame
    void Update()
    {


    }

    IEnumerator SpawnWall()
    {
        GameObject _newWall = Instantiate(WallPrefab, transform.position, Quaternion.identity);
        SpriteRenderer _spriteRenderer = _newWall.GetComponent<SpriteRenderer>();
        _spriteRenderer.color = Colors[Random.Range(0, Colors.Length)];


        yield return new WaitForSeconds(1);

        StartCoroutine(SpawnWall());
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(gameObject);
        }


    }





}
