using UnityEngine;

// 데이터 값 (Literal) - 변수에 저장할 데이터 값의 종류
public class VariableLiteral : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]변수 만들기(선언)
        int num;        //정수형 변수
        double su;      //실수형 변수 (3.141592)
        bool flag;      //부울형 변수 (참(true), 거짓(false)을 담는 그릇)
        string str;     //문자열 변수 ("안녕하세요", "Hello World")
        char c;         //문자형 변수 ('a', '김')

        //[2]변수에 값을 저장
        num = 1234;
        su = 3.1415;
        flag = false;   //true, false
        str = "안녕하세요";
        c = 'b';

        //[3]변수 사용하기
        Debug.Log("num:" + num);
        Debug.Log("su:" + su);
        Debug.Log("flag:" + flag);
        Debug.Log("str:" + str);
        Debug.Log("c:" + c);
    }
}
