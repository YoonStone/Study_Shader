using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    Renderer rd;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Renderer>();
    }

    private void OnMouseDown()
    {
        StartCoroutine(StartDissolve());
    }

    // 제목 클릭 시 서서히 사라지는 디졸브 기능 후 비활성화
    IEnumerator StartDissolve()
    {
        float value = -1;
        while (value < 1)
        {
            print(value);
            value += Time.deltaTime;
            rd.material.SetFloat("_Dissolve", -value);
            yield return null;
        }

        gameObject.SetActive(false);
    }
}
