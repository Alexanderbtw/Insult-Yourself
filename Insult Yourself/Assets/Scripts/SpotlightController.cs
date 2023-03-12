using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class SpotlightController : MonoBehaviour
{
    [HideInInspector]
    public Light2D spotlight;

    void Awake()
    {
        spotlight = GetComponent<Light2D>();
    }

    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ);

        Vector3 LocalScale = transform.localScale;

        transform.localScale = LocalScale;

        if (Input.GetKeyDown(KeyCode.L))
        {
            spotlight.enabled = !spotlight.isActiveAndEnabled;
        }
    }
}
