using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis_Rotate : MonoBehaviour
{
   
    private void Update()
    {
#if UNITY_ANDROID
        if (Input.GetMouseButton(0) && Input.touchCount == 1)
        {
            float rotX = Input.GetAxis("Mouse X") * 400* Mathf.Deg2Rad;
            float rotY = Input.GetAxis("Mouse Y") * 400 * Mathf.Deg2Rad;
            //float rotZ= Input.GetAxis("Mouse Z") * 400 * Mathf.Deg2Rad;
            GameObject parent = this.gameObject;
            parent.transform.Rotate(Vector3.up, -rotX);
            parent.transform.Rotate(Vector3.right, rotY);

        }
#endif
        if (Input.GetMouseButton(0))
        {
            float rotX = Input.GetAxis("Mouse X") * 400 * Mathf.Deg2Rad;
            float rotY = Input.GetAxis("Mouse Y") * 400 * Mathf.Deg2Rad;
            // float rotZ = Input.GetAxis("Mouse Z") * 400 * Mathf.Deg2Rad;
            GameObject parent = this.gameObject;
            parent.transform.Rotate(Vector3.up, -rotX);
            parent.transform.Rotate(Vector3.right, rotY);
            


        }
    }
}
