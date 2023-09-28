using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    Renderer rd;

    public float dissolveTime = 1;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(StartSpawn());
        }
    }

    // 아이템 스폰 시 디졸브 기능
    IEnumerator StartSpawn()
    {
        float value = 0;
        while (value < dissolveTime)
        {
            value += Time.deltaTime;
            rd.material.SetFloat("_Dissolve", 1 - (value/dissolveTime));
            yield return null;
        }
    }
}
