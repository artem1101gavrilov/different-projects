using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    public Camera cam;
    public int whichkamers;

    private void Start()
    {
        float x1 = 0;
        float y1 = 2;
        float z1 = 34;
        float x2 = 0;
        float y2 = 0;
        float z2 = 36;

        float angleX = 0 / 180.0f * 3.14f;
        float angleY = -90 / 180.0f * 3.14f;
        float angleZ = 0 / 180.0f * 3.14f;


        //поворот по оси Ох
        float xx1 = x1;
        float yy1 = y1 * Mathf.Cos(angleX) + z1 * Mathf.Sin(angleX);
        float zz1 = y1 * Mathf.Sin(angleX) + z1 * Mathf.Cos(angleX);

        //По оси Оу
        float xxx1 = xx1 * Mathf.Cos(angleY) + zz1 * Mathf.Sin(angleY);
        float yyy1 = yy1;
        float zzz1 = xx1 * Mathf.Sin(angleY) + zz1 * Mathf.Cos(angleY);

        //По оси Оz
        float xxxx1 = xxx1 * Mathf.Cos(angleZ) - yyy1 * Mathf.Sin(angleZ);
        float yyyy1 = xxx1 * Mathf.Sin(angleZ) + yyy1 * Mathf.Cos(angleZ);
        float zzzz1 = zzz1;


        //поворот по оси Ох
        float xx2 = x2;
        float yy2 = y2 * Mathf.Cos(angleX) + z2 * Mathf.Sin(angleX);
        float zz2 = y2 * Mathf.Sin(angleX) + z2 * Mathf.Cos(angleX);

        //По оси Оу
        float xxx2 = xx2 * Mathf.Cos(angleY) + zz2 * Mathf.Sin(angleY);
        float yyy2 = yy2;
        float zzz2 = xx2 * Mathf.Sin(angleY) + zz2 * Mathf.Cos(angleY);

        //По оси Оz
        float xxxx2 = xxx2 * Mathf.Cos(angleZ) - yyy2 * Mathf.Sin(angleZ);
        float yyyy2 = xxx2 * Mathf.Sin(angleZ) + yyy2 * Mathf.Cos(angleZ);
        float zzzz2 = zzz2;

        Debug.Log("1 " + xxxx1 + " " + yyyy1 + " " + zzzz1);
        Debug.Log("2 " + xxxx2 + " " + yyyy2 + " " + zzzz2);

        Debug.Log(Mathf.Atan2(yyyy1  - yyyy2, xxxx1 - xxxx2) * 180 / 3.14f);
        Debug.Log("Sin = " + Mathf.Sin(90.0f / 180.0f * 3.14f));
    }

    private void OnMouseDrag()
    {
        float angleX = -20.0f / 180.0f * 3.14f;
        float angleY = -110.0f / 180.0f * 3.14f;
        float angleZ = 0 / 180.0f * 3.14f;

        // принадлежащей текущему объекту
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        // Переменная hit будет содержать результат "бросания" луча в пространство сцены
        RaycastHit hit;

        // Если не попали в какой-либо объект - выходим из функции
        if (!Physics.Raycast(ray, out hit))
            return;

        Debug.Log(hit.point);

        var positionMouse = hit.point;// Camera.allCameras[whichkamers].ScreenToWorldPoint(Input.mousePosition);
        //positionMouse.x = Camera.main.gameObject.transform.position.x - positionMouse.x;
        var posTransform = transform.position;
        Debug.Log(positionMouse + " " + posTransform);

        float x, y, z;
        y = positionMouse.y;
        z = positionMouse.z;
        positionMouse.y = y * Mathf.Cos(angleX) - z * Mathf.Sin(angleX);
        positionMouse.z = y * Mathf.Sin(angleX) + z * Mathf.Cos(angleX);
        x = positionMouse.x;
        z = positionMouse.z;
        positionMouse.x = x * Mathf.Cos(angleY) + z * Mathf.Sin(angleY);
        positionMouse.z = - x * Mathf.Sin(angleY) + z * Mathf.Cos(angleY);
        x = positionMouse.x;
        y = positionMouse.y;
        positionMouse.x = x * Mathf.Cos(angleZ) - y * Mathf.Sin(angleZ);
        positionMouse.y = x * Mathf.Sin(angleZ) + y * Mathf.Cos(angleZ);
        
        y = posTransform.y;
        z = posTransform.z;
        posTransform.y = y * Mathf.Cos(angleX) - z * Mathf.Sin(angleX);
        posTransform.z = y * Mathf.Sin(angleX) + z * Mathf.Cos(angleX);
        x = posTransform.x;
        z = posTransform.z;
        posTransform.x = x * Mathf.Cos(angleY) + z * Mathf.Sin(angleY);
        posTransform.z =  - x * Mathf.Sin(angleY) + z * Mathf.Cos(angleY);
        x = posTransform.x;
        y = posTransform.y;
        posTransform.x = x * Mathf.Cos(angleZ) - y * Mathf.Sin(angleZ);
        posTransform.y = x * Mathf.Sin(angleZ) + y * Mathf.Cos(angleZ);
        
        float angle = Mathf.Atan2(positionMouse.y - posTransform.y, positionMouse.x - posTransform.x) * 180 / 3.14f;
        Debug.Log(positionMouse + " " + posTransform + " " + angle);
        var rotationVector = transform.rotation.eulerAngles;
        rotationVector.z = angle;
        transform.rotation = Quaternion.Euler(rotationVector);
    }
}