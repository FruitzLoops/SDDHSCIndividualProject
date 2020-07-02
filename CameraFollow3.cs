using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow3 : MonoBehaviour
{
    [SerializeField]
    private Transform targetToFollow;

    public float minx = -1f; //left edge
    public float maxx = 1f; //right edge
    public float miny = -1f; //lower edge
    public float maxy =1f; //upper edge


    void LateUpdate()
    {
        transform.position = new Vector3 (
            Mathf.Clamp(targetToFollow.position.x, minx, maxx), //camera x pos to player x pos while staying between min and max
            Mathf.Clamp(targetToFollow.position.y, miny, maxy), //camera y pos to player y pos while staying between min and max
            transform.position.z);
    }
}
