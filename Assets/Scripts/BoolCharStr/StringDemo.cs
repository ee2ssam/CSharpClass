using UnityEngine;

// string : 문자열 데이터 형식
public class StringDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] string 변수 선언하고 초기화
        string name = "홍길동";
        //[1-1] int 상수 선언하고 초기화 하기
        const int AGE = 20;

        //[2] 사용하기
        //Debug.Log(name);
        Debug.Log("name: " + name); //문자열 더하기 연산 => 문자열 + 문자열
        Debug.Log($"내 이름은 {name}"); //문자열 보간법 => $" {변수이름}  "

        //연습하기
        //문자열 보간법으로 콘솔창에 안녕하세요 홍길동 입니다를 출력해보세요
        Debug.Log($"안녕하세요 {name} 입니다");
        //이름은 홍길동, 나이는 20살 입니다 출력해보세요
        Debug.Log($"이름은 {name}, 나이는 {AGE}살 입니다");

        //이름은 이순신, 나이는 40살 입니다 출력해보세요
        name = "이순신";
        //AGE = 40; //AGE가 상수이어서 40으로 수정하면 에러가 발생
        Debug.Log($"이름은 {name}, 나이는 {AGE}살 입니다");

    }
}
