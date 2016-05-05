using UnityEngine;
using System.Collections;

public class Delayeffect : MonoBehaviour
{

    // FPS KIT [www.armedunity.com]

    public float amount = 0.02f;
    public float maxAmount = 0.03f;
    public float smooth = 3;
    private Vector3 def;

    void Start()
    {
        def = transform.localPosition;
    }

    void Update()
    {
        if (Cursor.lockState == CursorLockMode.None) return;

        float factorX = -Input.GetAxis("Mouse X") * amount;
        float factorY = -Input.GetAxis("Mouse Y") * amount;

        if (factorX > maxAmount)
            factorX = maxAmount;

        if (factorX < -maxAmount)
            factorX = -maxAmount;

        if (factorY > maxAmount)
            factorY = maxAmount;

        if (factorY < -maxAmount)
            factorY = -maxAmount;


        Vector3 Final = new Vector3(def.x + factorX, def.y + factorY, def.z);
        transform.localPosition = Vector3.Lerp(transform.localPosition, Final, Time.deltaTime * smooth);
    }
}