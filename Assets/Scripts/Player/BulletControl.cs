using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public Config config;

    private Rigidbody2D rb;
    void Start()
    {
       //��� ����� ������� ��� �������� ���� � ���������� ����� 2 ������� �� ��������� ������
       //����� �������� �������� �� � ������� ��� ��� �� ��� ������� �������� ������� �������
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * config._bulletStartSpeed, ForceMode2D.Impulse);
    }
    private void OnBecameInvisible() // �������� ����� ������ ��� ���� �������� �����, ���� ������ ����������
    {
        Destroy(gameObject);
    }

    public void Del()
    {
        Destroy(gameObject);
    }
}
