using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirController : MonoBehaviour
{
    public float speed = 10f;        // Скорость самолета
    public float turnSpeed = 100f;   // Скорость поворота самолета
    public float tiltSpeed = 5f;     // Скорость наклона

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   
    }
    void Update()
    {
        // Движение вперед
        if(Input.GetKey(KeyCode.W) && speed <= 75f)
        {
            speed += 0.75f;
        }
        if (Input.GetKey(KeyCode.S) && speed >= 0.75f)
        {
            speed -= 0.75f;
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Повороты
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        transform.Rotate(0, turn, 0); // Поворот по оси Y

        // Наклон с помощью мыши
        float mouseY = Input.GetAxis("Mouse Y") * tiltSpeed;
        float mouseX = Input.GetAxis("Mouse X") * tiltSpeed;

        // Наклон по оси X (вперед/назад) и Y (вправо/влево)
        transform.Rotate(-mouseY, mouseX, 0);
    }
}
