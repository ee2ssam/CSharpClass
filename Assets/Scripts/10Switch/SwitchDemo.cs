using UnityEngine;

//조건문 : 조건에 맞는 명령문을 실행
//if, switch
public class SwitchDemo : MonoBehaviour
{
    //정수 데이터값 입력
    public int num = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //num이 1이면 num은 1입니다 출력
        //num이 2이면 num은 2입니다 출력
        //다른 수이면 아무것도 안한다

        switch(num) //num 데이터 판별
        {
            case 1:
                Debug.Log("num은 1입니다");
                break;

            case 2:
                Debug.Log("num은 2입니다");
                break;
        }

    }
}

/*
switch문 : Data의 값 판별
조건 Data의 값에 따라 명령문을 실행

switch(조건 Data) 값 판별
{
    case 1번:
        //실행문1
        break;

    case 2번:
        //실행문2
        break;

    case 3번:
        //실행문3
        break;

    default:    //모든 경우가 아니면
        //실행문4
        break;
}

*/