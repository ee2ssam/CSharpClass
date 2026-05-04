using UnityEngine;

//형식 변환 실습
public class TypeConversionNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //double형 변수 d를 선언하고 12.34 초기화
        double d = 12.34;   //실수형 64bit
        //int 형 변수 i 선언하고 1234 초기화
        int i = 1234;       //정수형 32bit

        //[1] d에 i값 저장하기 : double > int 묵시적(암묵적, 암시적) 형식 변환
        d = i;
        Debug.Log($"암묵적 형식변환: {d}");    //1234

        d = 12.34;
        i = 1234;

        //[2] i에 d값 저장하기: int < double 명시적인 형식 변환
        i = (int)d; // () 캐스트 연산자
        Debug.Log($"명시적인 형식변환: {i}");


        d = 12.34;
        i = 1234;

        //[3] 숫자가 아닌 다른 형식간의 변환
        //문자열 변수 선언하고 초기화
        string s = "";      //빈값으로 문자열 초기화
        //s에 d값 저장하기
        s = d.ToString();   //숫자를 문자열로 형식변환하기
        Debug.Log($"형식 변환: {s}");

    }
}
