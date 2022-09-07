using UnityEngine;

//—крипт нужен дл€ управлени€ всей цепочкой врагов
//¬ основном чтобы спавнить сразу цепочки из врагов а также одновременно удол€ть остатки врагов
//ѕо примеру референса можно создать разные скрипты под разные цепочки с разным поведением, это в общем то не сложно, но по тз насколько € пон€л этого и не требуетс€
public class EnemyController : MonoBehaviour
{
    public Config config;

    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Del();
    }

    void Del()
    {
        Destroy(gameObject, 15f);
    }
}
