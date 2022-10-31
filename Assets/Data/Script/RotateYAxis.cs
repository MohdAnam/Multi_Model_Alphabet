using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateYAxis : MonoBehaviour
{

    private void Update()
    {
#if UNITY_ANDROID
        if (Input.GetMouseButton(0) && Input.touchCount == 1)
        {
            float rotX = Input.GetAxis("Mouse X") * 400 * Mathf.Deg2Rad;
            GameObject parent = this.gameObject;
            parent.transform.Rotate(Vector3.forward, rotX);
        }
#endif
        if (Input.GetMouseButton(0))
        {
            float rotX = Input.GetAxis("Mouse X") * 400 * Mathf.Deg2Rad;
            GameObject parent = this.gameObject;
            parent.transform.Rotate(Vector3.forward, rotX);
        }
    }
}
