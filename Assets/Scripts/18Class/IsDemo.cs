using UnityEngine;
using UnityEngine.Rendering;

public class IsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //정수형 변수 선언하고 초기화
        int i = 1234;
        //object형 변수 선언하고 i값 저장
        //박싱
        object o = i;
        //object형 변수 사용
        Debug.Log(o);

        //object형 변수 선언하고 5678로 초기화
        object ob = 5678;
        //정수형 변수 선언하고 object값 가져오기
        //명시적 형식 변환, 캐스팅, 캐스트
        //언박싱
        int num = (int)ob;
        //
        Debug.Log(num);

        //is 연산
        object s = "안녕하세요";
        object j = 9871;

        //s를 string 으로 변환이 가능한지 체크
        if(s is string)
        {
            //Debug.Log($"{s}는 문자열 형식으로 변환이 가능합니다");
            string str = s as string;
            Debug.Log($"str: {str}");
        }

        //j는 int형으로 변환이 가능한지 체크
        if(j is int)
        {
            //Debug.Log($"{j}는 정수형 형식으로 변환이 가능합니다");
            int number = (int)j;
            Debug.Log($"number: {number}");
        }

    }
}

/*
데이터 타입: 변수가 값을 저장하는 방식 분류
값 형식(value type) : 객체에 값 자체를 담고 있는 구조, int, long, float, double, 구조체
참조 형식(reference type) : 객체에 값을 담고 있고 또 다른 객체를 포인터로 바라보는 구조, string, 클래스 인스턴스
: 참조 형식의 변수(인스턴스)에 값이 없는 상태를 null이라고 한다

object : c#에서 제공하는 모든 자료형의 부모, object 형식의 변수는 모든 형식의 값 할당이 가능

//박싱(boxing) : 값 형식의 데이터를 참조 형식의 데이터로 변경하는 것
//언박싱(unboxing) : 참조형식의 데이터를 값 형식의 데이터로 변경 - 캐스트, 캐스팅

//is 연산자 : 형식비교하기, 특정 형식인지 아닌지 비교
//특정 형식으로 변환이 가능하면 true, 그렇지 않으면 false 값을 반환

//as 연산자
// ~ 형식으로 변환이 가능하면 변환하고 변환이 불가능하면 null을 반환
// 참조 형식에만 사용
*/