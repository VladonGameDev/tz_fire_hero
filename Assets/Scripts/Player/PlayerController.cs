using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        TouchConrtol();
    }

    private void TouchConrtol()
    {
        // Тач управление для экрана
        if (Input.touchCount > 0)
        {
            //Тут получаем позицию палца и переводим её в мировую позицию
            Touch touch = Input.GetTouch(0);
            Vector3 fingerPos = touch.position;
            fingerPos.z = 10.0f;
            Vector3 worldFingerPos = Camera.main.ScreenToWorldPoint(fingerPos);

            Vector3 newPos = transform.position;

            //ограничение чтобы игрок не телепортировался за пальцем в другой конец экрана
            if (worldFingerPos.x < newPos.x + 0.3f && worldFingerPos.x > newPos.x || worldFingerPos.x > newPos.x - 0.3f && worldFingerPos.x < newPos.x)
            {
                newPos.x = worldFingerPos.x;
                transform.position = newPos;
            }

            //ограничение по ширене игрового поля, работает адекватно для любых соотношений сторон
            if (transform.position.x > 2.2f)
                transform.position = new Vector3(2.2f, -3.5f, 0f);
            if (transform.position.x < -2.2f)
                transform.position = new Vector3(-2.2f, -3.5f, 0f);
        }
    }
}
