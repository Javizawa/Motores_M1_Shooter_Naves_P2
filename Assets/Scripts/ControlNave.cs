using UnityEngine;

public class ControlNave : MonoBehaviour
{
    public float velocidad = 5f;           // Velidad del proyectil
    public GameObject proyectilPrefab;     // Referencia al prefab del proyectil
    public Transform puntoDisparo;         // Punto desde donde se disparará el proyectil
    public float velocidadProyectil = 10f; // Velocidad del proyectil

    void Update()
    {
        MovimientoName();
        if (Input.GetKeyDown(KeyCode.Space)) // Dispara cuando se presiona la tecla Espacio
        {
            Disparar();
        }
    }

    void Disparar()
    {
        this.GetComponent<AudioSource>().Play();
        // Instanciar el proyectil en el punto de disparo y la misma rotación de la nave
        GameObject proyectil = Instantiate(proyectilPrefab, puntoDisparo.position, puntoDisparo.rotation);
        proyectil.GetComponent<MisilBehaviuor>().tagName = this.tag;
        // Añadir velocidad al proyectil
        Rigidbody2D rb = proyectil.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * velocidadProyectil; // Asume que la nave está orientada hacia arriba
    }


    private void MovimientoName()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector2 movimiento = new Vector2(movimientoHorizontal, movimientoVertical) * velocidad * Time.deltaTime;
        transform.Translate(movimiento);
    }
}
