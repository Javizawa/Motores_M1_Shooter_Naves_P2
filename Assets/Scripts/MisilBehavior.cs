using UnityEngine;

public class MisilBehaviuor : MonoBehaviour
{
    public float misileTime = 3f;
    private float shootedTime = 0f;
    public string tagName;

    // Update is called once per frame
    void Update()
    {
        shootedTime += Time.deltaTime;
        if (misileTime <= shootedTime)
        {
            DestroyMisile();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        Debug.Log(tagName);

        if(collision.gameObject.tag == "Untagged" || collision.gameObject.tag != tagName)
        {
            Destroy(collision.gameObject);
            DestroyMisile();
        }
    }

        private void DestroyMisile()
    {
        Destroy(this.gameObject);
    }
}
