using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        TouchConrtol();
    }

    private void TouchConrtol()
    {
        // ��� ���������� ��� ������
        if (Input.touchCount > 0)
        {
            //��� �������� ������� ����� � ��������� � � ������� �������
            Touch touch = Input.GetTouch(0);
            Vector3 fingerPos = touch.position;
            fingerPos.z = 10.0f;
            Vector3 worldFingerPos = Camera.main.ScreenToWorldPoint(fingerPos);

            Vector3 newPos = transform.position;

            //����������� ����� ����� �� ���������������� �� ������� � ������ ����� ������
            if (worldFingerPos.x < newPos.x + 0.3f && worldFingerPos.x > newPos.x || worldFingerPos.x > newPos.x - 0.3f && worldFingerPos.x < newPos.x)
            {
                newPos.x = worldFingerPos.x;
                transform.position = newPos;
            }

            //����������� �� ������ �������� ����, �������� ��������� ��� ����� ����������� ������
            if (transform.position.x > 2.2f)
                transform.position = new Vector3(2.2f, -3.5f, 0f);
            if (transform.position.x < -2.2f)
                transform.position = new Vector3(-2.2f, -3.5f, 0f);
        }
    }
}
