using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public Config config;

    private Rigidbody2D rb;
    void Start()
    {
       //Тут задоём инпульс при создании пули и уничтожаем через 2 секунды во избижание мусора
       //Можно задовать скорость но я подумал что так ка это выстрел логичнее сделать импульс
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * config._bulletStartSpeed, ForceMode2D.Impulse);
    }
    private void OnBecameInvisible() // работает когда объект вне зоны действия камер, даже камеры инспектора
    {
        Destroy(gameObject);
    }

    public void Del()
    {
        Destroy(gameObject);
    }
}
