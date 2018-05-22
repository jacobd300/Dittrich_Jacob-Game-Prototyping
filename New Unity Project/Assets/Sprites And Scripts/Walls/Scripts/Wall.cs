using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    public Vector3 MoveSpeed;

    public List<Color> ColorsToPickFrom = new List<Color>();

    // Use this for initialization
    void Start()
    {

        GetComponent<SpriteRenderer>().color = ColorsToPickFrom[Random.Range(0, ColorsToPickFrom.Count)];

    }

    // Update is called once per frame
    void Update()
    {

        transform.position -= MoveSpeed;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Destructible")
        {
            Destroy(gameObject);
        }
    }
}
