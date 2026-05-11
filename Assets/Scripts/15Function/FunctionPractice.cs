using JetBrains.Annotations;
using UnityEngine;

//두개의 정수를 입력받아 더하기,빼기,곱하기,나누기(0으로 나누기 제외),나머지 값을 구하는 프로그램 구현
public class FunctionPractice : MonoBehaviour
{
    //인스펙터창에서 두개의 정수 입력
    public int a = 0;
    public int b = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result = Sum(a, b);
        Debug.Log($"{a} + {b} = {result}");

        result = Substract(a, b);
        Debug.Log($"{a} - {b} = {result}");

        result = Multiply(a, b);
        Debug.Log($"{a} * {b} = {result}");

        result = Divide(a, b);
        Debug.Log($"{a} / {b} = {result}");

        result = Remain(a, b);
        Debug.Log($"{a} % {b} = {result}");

    }

    //매개변수 입력 받은 두개의 정수를 합하여 결과를 리턴하는 함수
    int Sum(int x, int y)
    {
        /*int sum = x + y;
        return sum;*/
        return (x + y);
    }

    //
    int Minus(int x, int y)
    {
        return (x - y);
    }

    //화살표 함수
    int Substract(int x, int y) => x - y;

    //
    int Multiply(int x, int y)
    {
        return (x * y);
    }

    //
    int Divide(int x, int y)
    {
        //방어코드, 입력받은 데이터 검증
        if(y == 0)
        {
            return 0;
        }

        return (x / y);
    }

    //
    int Remain(int x, int y)
    {
        //방어코드, 입력받은 데이터 검증
        if (y == 0)
        {
            return 0;
        }

        return (x % y);
    }

}
