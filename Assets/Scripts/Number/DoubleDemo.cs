using UnityEngine;

//
public class DoubleDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] float형 변수 선언하고 초기화 하기
        float f = 3.14F;
        Debug.Log(f);

        //[2] double형 변수 선언하고 초기화 하기
        double d = 3.141592D;
        Debug.Log(d);

        //[3] decimal형 변수 선언하고 초기화 하기
        decimal m = 3.14M;
        Debug.Log(m);

    }
}

/*
실수형 데이터
float : 32비트 실수형 데이터 형식
double : 64비트 실수형 데이터 형식
decimal : 128비트 실수형 데이터 형식
*/

