using UnityEngine;

// PrefixOperator(전위 증감연산자) : 변수 앞에 위치하는 증감연산자, 같은 라인에서 연산하는 순위가 가장 높음
// PostfixOperator(후위 증감연산자) : 변수 뒤쪽에 위치하는 증감연산자, 같은 라인에서 연산하는 순위가 가장 낮음
public class PrefixOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]전위 증감연산자
        int i = 3;
        int j = ++i;

        Debug.Log($"i: {i}");       //? 4
        Debug.Log($"j: {j}");       //? 4

        //[2]후위 증감연산자
        int x = 3;
        int y = x++;

        Debug.Log($"x: {x}");       //? 4
        Debug.Log($"y: {y}");       //? 3

    }
}
