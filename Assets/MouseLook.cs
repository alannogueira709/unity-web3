using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody; // Arraste o objeto "Player" aqui no Inspector

    float xRotation = 0f;

    void Start()
    {
        // Trava o mouse no centro da tela e o torna invisível
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Captura o movimento do mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotação vertical (olhar para cima/baixo) com limite
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotação horizontal (girar o corpo)
        playerBody.Rotate(Vector3.up * mouseX);
    }
}