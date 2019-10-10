using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetrominion : MonoBehaviour
{
    public GameObject[] Tetrominions;

    // Start is called before the first frame update
    void Start()
    {
        Tetrocall();
    }

    public void Tetrocall()
    {
        Instantiate(Tetrominions[Random.Range(0, Tetrominions.Length)], transform.position, Quaternion.identity);
    }
}
