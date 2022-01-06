using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject ThingToFollow;
    void LateUpdate() //so that the camera follows smoothly to reduce jitteryness
    {
        transform.position = ThingToFollow.transform.position + new Vector3 (0,0,-10); //setting an offset for the camera
    }
}
