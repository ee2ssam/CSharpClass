using UnityEngine;

//변수: 데이터를 저장해 놓는 그릇
//전역 변수, 지역 변수 : 변수 선언의 위치에 따라 분류
public class FunctionScope : MonoBehaviour
{
    //FunctionScope 함수 안에서 선언된 변수: 전역 변수, 필드, 멤버 변수
    string message = "전역 변수 메시지";    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //메세지 출력 함수 호출
        ShowMessage(); //지역 변수 메세지

        //
        //PrintMessage(); //전역 변수 메시지

        //
        //Debug.Log(message); //? 전역 변수 메시지
    }

    //message를 출력하는 함수
    void ShowMessage()
    {
        //ShowMessage 함수 안에서 선언된 변수 : 지역변수
        string message = "지역 변수 메세지";
        //전역변수와 지역변수 이름이 같으면 지역변수로 인식
        Debug.Log(message);

        //전역변수 메세지 출력
        Debug.Log(this.message);
    }

    //다른 message를 출력하는 함수
    void PrintMessage()
    {
        Debug.Log(this.message);
    }

}
