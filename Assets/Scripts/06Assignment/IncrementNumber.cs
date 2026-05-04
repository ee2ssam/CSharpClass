using UnityEngine;

//정수형 변수의 값을 1씩 증가하기
public class IncrementNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]정수형 변수의 값을 1씩 증가하기
        //정수형 변수 num 선언하고 10으로 초기화
        int num = 10;
        //정수형 변수 num의 값을 1씩 증가하는 식 - 증가후 다시 num에 저장한다
        num = num + 1;  //num 1 증가식

        Debug.Log($"num: {num}");           //11

        //[2]정수형 변수의 값을 1씩 감소하기

        //정수형 변수 number 선언하고 10으로 초기화
        int number = 10;
        //정수형 변수 number의 값을 1씩 감소하는 식 - 감수후 다시 number에 저장한다
        number = number - 1;  //num 1 감소식

        Debug.Log($"number: {number}");           //9

        //[3]증가식, 감소식 축약해서 사용하기 (+=, -=, *=, /=, %=)
        //2씩 증가하는 식
        int x = 3;
        x = x + 2;      //2씩 증가시켜주는 증가식
        Debug.Log($"x: {x}");           //5

        //2씩 증가하는 축약식 
        int y = 3;
        //y = y + 2;
        y += 2;         //축약 식
        Debug.Log($"y: {y}");           //5

        //[4] 누적식 (+=, -=, *=, /=, %=)
        int a = 3;
        int b = 5;

        //누적 : b변수에 a변수의 값을 누적
        //b = b + a;
        b += a;
        Debug.Log($"b: {b}");       //8

        //b변수에 a변수의 값을 감산 누적
        //b = b - a;
        b -= a;
        Debug.Log($"b: {b}");       //5
    }
}
