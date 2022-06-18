using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CenterRay : MonoBehaviour
{
    public float MouseXDex;
    public float MouseYDex;
    float inputX;
    float inputY;
    float mAngle;
    Vector3 horizontalVector;

    public Text targetName;
    public Camera mCam;
    public float rayLength;
    Vector3 rayOrigin = new Vector3(0.5f, 0.5f, 0f); // center of the screen
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Mouse X");
        inputY = Input.GetAxis("Mouse Y");

        mAngle += inputY * MouseYDex;
        //Debug.Log(mAngle);
        if (mAngle > 45.0f) mAngle = 45.0f;
        if (mAngle < -45.0f) mAngle = -45.0f;

        horizontalVector = transform.forward;
        mCam.transform.forward = horizontalVector;

        transform.Rotate(Vector3.up * MouseXDex * inputX);
        mCam.transform.Rotate(-mAngle, 0.0f, 0.0f);

        Ray ray = mCam.ViewportPointToRay(rayOrigin);
        // actual Ray

        // debug Ray
        Debug.DrawRay(ray.origin, ray.direction * rayLength, Color.red);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, rayLength))
        {
            // our Ray intersected a collider
            //Destroy(hit);
            Debug.Log(hit.collider.gameObject.name);
            targetName.text = hit.collider.gameObject.name;
        }
    }
    
}
