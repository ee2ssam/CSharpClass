using UnityEngine;

public class GetTypeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //변수의 타입 알아보기
        int i = 1234;               //정수형
        string s = "안녕하세요";     //문자열
        char c = 'a';               //문자
        double d = 3.14;            //실수형

        Debug.Log(i.GetType());     //i 변수의 타입을 콘솔창에 출력 
        Debug.Log(s.GetType());
        Debug.Log(c.GetType());
        Debug.Log(d.GetType());
    }
}
