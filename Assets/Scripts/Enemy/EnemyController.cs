using UnityEngine;

//������ ����� ��� ���������� ���� �������� ������
//� �������� ����� �������� ����� ������� �� ������ � ����� ������������ ������� ������� ������
//�� ������� ��������� ����� ������� ������ ������� ��� ������ ������� � ������ ����������, ��� � ����� �� �� ������, �� �� �� ��������� � ����� ����� � �� ���������
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
