using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

//Контроллер отдельных кубов врагов, тут просчитывается их хп и урон
public class EnemyBoxController : MonoBehaviour
{
    public Config config;

    private UIController ui;

    private float health;
    private TextMeshPro hp_text;
    private Rigidbody2D rb;
    private void Start()
    {
        ui = GameObject.Find("Canvas").GetComponent<UIController>();
        rb = GetComponent<Rigidbody2D>();
        hp_text = GetComponentInChildren<TextMeshPro>();
        int i = Random.Range(3, 10);
        health = (float)i;
        hp_text.text = "" + health;
    }
    private void Update()
    {
        rb.velocity = Vector2.down*config._enemySpeed;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Bullet")
        {
            col.GetComponent<BulletControl>().Del();
            health -= config._bulletDamage;
            if(health <= 0)
                Destroy(gameObject);
            hp_text.text = "" + health;
            ui.points++;
        }
        if(col.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
    }
}
