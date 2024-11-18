using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject naveEnemiga;     // Referencia al prefab del proyectil

    // Start is called before the first frame update
    void Start()
    {
        GameObject proyectil = Instantiate(naveEnemiga, this.transform.position, this.transform.rotation);
        Rigidbody2D rb = proyectil.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-1f, 0f) * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }




}
