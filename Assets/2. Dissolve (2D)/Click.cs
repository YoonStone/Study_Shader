using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    Renderer rd;

    public float dissolveTime = 1;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Renderer>();
    }

    private void OnMouseDown()
    {
        StartCoroutine(StartDissolve());
    }

    // 아이템 스폰 시 디졸브 기능
    IEnumerator StartDissolve()
    {
        float value = -1;
        while (value < 1)
        {
            print(value);
            value += Time.deltaTime;
            rd.material.SetFloat("_Dissolve", value);
            yield return null;
        }
    }
}
