using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camer_follow : MonoBehaviour
{
    // Start is called before the first frame update
    public float Follow_speed = 2f;
    public Transform target;
    public float yOffset = 1f;

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = new Vector3(target.position.x, target.position.y, -1f);
        transform.position = Vector3.Slerp(transform.position, newpos, Follow_speed * Time.deltaTime);
    }   
}
