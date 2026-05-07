using UnityEngine;

//두개의 정수를 입력받아 두수중 작은수, 큰수를 찾는 프로그램 구현
//입력받은 정수의 절대값을 구하는 프로그램
public class FunctionMinMax : MonoBehaviour
{
    //인스펙터창 입력
    public int a = 0;
    public int b = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*int result = Min(-5, -3);
        Debug.Log(result);
        Debug.Log(Max(5, 3));*/

        //a, b의 작은값 구하기, 큰값 구하기
        int minValue = Min(a, b);
        Debug.Log($"작은 값은 {minValue}");

        int maxValue = Max(a, b);
        Debug.Log($"큰 값은 {maxValue}");

        //int absValue = Abs(a);        //사용자 함수
        int absValue = Mathf.Abs( a );  //내장 함수
        Debug.Log($"절대값은 {absValue}");
    }

    //매개변수로 입력받은 두개의 정수중 작은수를 반환하는 함수
    int Min(int x, int y)
    {
        if(x < y)   //x가 작냐?
        {
            return x;
        }
        else //아니면
        {
            return y;
        }
    }

    //매개변수로 입력받은 두수중 큰수를 반환하는 함수
    int Max(int x, int y)
    {
        /*
        int maxValue = 0;
        if (x > y)  //x가 크냐?
        {
            maxValue = x;
        }
        else //아니면
        {
            maxValue = y;
        }
        */

        /*
        //3항 연산자
        // (조건식) ? 참일때 반환값 : 거짓일때 반환값
        int maxValue = (x > y) ? x : y;

        return maxValue;
        */

        return (x > y) ? x : y;
    }

    //매개변수로 입력받은 정수의 절대값을 반환하는 함수
    //-5 => 5, 5 => 5, -99 => 99, 105 => 105
    int Abs(int number)
    {
        /*if(number < 0)
        {
            return -number;
        }
        else
        {
            return number;
        }*/

        return (number < 0) ? -number : number;
    }

}
