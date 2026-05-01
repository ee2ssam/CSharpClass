using UnityEngine;

//조건문 : 조건에 맞는 명령문을 실행
//if, switch
public class IfDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //만약 점수가 60점이상이면 합격을 출력
        /*
        if(점수가 60점이상)
        {
            합격을 출력
        }
        */

        /*int score = 60;

        if (score >= 60) //조건식
        {
            //실행문
            Debug.Log("합격");
        }*/


        /*int score = 60;

        //실행문이 하나이면 {} 생략가능
        if (score >= 60) 
            Debug.Log("합격");*/

        //중첩 if문
        string name = "홍길동";
        int age = 20;

        //만약 이름이 홍길동과 같으면 실행문 실행
        if(name == "홍길동")
        {
            //실행문 : 만약 나이가 20과 실행문 실행
            if(age == 20)
            {
                //실행문
                Debug.Log($"이름은 {name}, 나이는 {age}");
            }
        }
        
    }
}

/*
== if문 : 참, 거짓 판별
조건식이 참일때 실행문을 실행한다
조건식이 거짓이면 실행문을 실행하지 않는다

만약 조건식이 참이면 {}안에 있는 실행문을 실행하라
if(조건식)
{
    //실행문1
    //실행문2
    //.....
}

== else문 : if문과 같이 사용
만약 조건식이 참이면 실행문1만 실행하고 else의 실행문2는 실행하지 않습니다.
만약 조건식 거짓이면 실행문1은 실행하지 않고 else의 실행문 2를 실행한다

if(조건식)
{
    //실행문1
}
else
{
    //실행문2
}

//실행문3

1. 조건식이 참
실행문1 -> 실행문3 실행

1. 조건식이 거짓
실행문2 -> 실행문3 실행


== elseif문 : if문과 같이 사용

if(조건식1)
{
    //실행문1
}
else if(조건식2)
{
    //실행문2
}
else
{
    //실행문3
}

실행문4

[1] 조건식 1이 참이면
실행문1 -> 실행문4 실행

[2] 조건식 1이 거짓이고 조건식 2 참이면 
실행문2 -> 실행문4 실행

[3] 조건식 1이 거짓이고 조건식 2도 거짓이면
실행문3 -> 실행문4 실행

[4] 조건식 1이 참이고 조건식 2가 참이면  ?
실행문1 -> 실행문4


*/
