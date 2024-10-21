using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float velocidad = 5f;           // Velidad del proyectil
    public GameObject proyectilPrefab;     // Referencia al prefab del proyectil
    public Transform puntoDisparo;         // Punto desde donde se disparará el proyectil
    public float velocidadProyectil = 10f; // Velocidad del proyectil
    public float tiempoDisparo = 2f;       // Tiempo de disparo del proyectil
    public float refrescoDisparo = 0f;     // Tiempo de refresco del disparo del proyectil


     void Start()
    {
        refrescoDisparo = 6f;
    }

    void Update()
    {
        MovimientoName();
        if (refrescoDisparo > tiempoDisparo) // Dispara cuando se presiona la tecla Espacio
        {
            Disparar();
            refrescoDisparo = 0f;
        }
        refrescoDisparo += Time.deltaTime;
    }

    void Disparar()
    {
        // Instanciar el proyectil en el punto de disparo y la misma rotación de la nave
        GameObject proyectil = Instantiate(proyectilPrefab, puntoDisparo.position, puntoDisparo.rotation);
        proyectil.GetComponent<MisilBehaviuor>().tagName = this.tag;
        // Añadir velocidad al proyectil
        Rigidbody2D rb = proyectil.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-1f,0f) * velocidadProyectil;
    }


    private void MovimientoName()
    {
        Vector2 movimiento = new Vector2(1, 0f) * velocidad * Time.deltaTime;
        transform.Translate(movimiento);
    }
}
