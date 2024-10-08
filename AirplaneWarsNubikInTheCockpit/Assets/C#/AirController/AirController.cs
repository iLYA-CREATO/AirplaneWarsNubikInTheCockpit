using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirController : MonoBehaviour
{
    public float speed = 10f;        // �������� ��������
    public float turnSpeed = 100f;   // �������� �������� ��������
    public float tiltSpeed = 5f;     // �������� �������

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   
    }
    void Update()
    {
        // �������� ������
        if(Input.GetKey(KeyCode.W) && speed <= 75f)
        {
            speed += 0.75f;
        }
        if (Input.GetKey(KeyCode.S) && speed >= 0.75f)
        {
            speed -= 0.75f;
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // ��������
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        transform.Rotate(0, turn, 0); // ������� �� ��� Y

        // ������ � ������� ����
        float mouseY = Input.GetAxis("Mouse Y") * tiltSpeed;
        float mouseX = Input.GetAxis("Mouse X") * tiltSpeed;

        // ������ �� ��� X (������/�����) � Y (������/�����)
        transform.Rotate(-mouseY, mouseX, 0);
    }
}
