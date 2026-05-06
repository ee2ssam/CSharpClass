using UnityEngine;

// break문 : 반복문(for, while)의 { } 을 빠져나오는 명령문
//       : 반복문(for, while)을 강제 종료
public class BreakDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for문 break
        //안녕하세요 5번 반복 출력하기, 단 i가 2일때 for문 종료
        /*for (int i = 0; i < 5; i++)
        {
            if (i == 2)
            {
                break;
            }

            //반복 실행문
            Debug.Log("안녕하세요");
        }*/

        //i=0 -> 0<5(참) -> 안녕하세요 출력 -> i=1 -> 1<5(참) -> 안녕하세요 출력 -> i=2
        // -> 2<5(참) -> 안녕하세요 출력 -> break -> for문 종료

        //i=0 -> 0<5(참) -> 안녕하세요 출력 -> i=1 -> 1<5(참) -> 안녕하세요 출력 -> i=2
        // -> 2<5(참) -> break -> for문 종료

        //무한루프
        /*for(;;)
        {
        }*/

        int number = 0;

        //무한루프
        //number가 5이상이면 while문 종료
        while (true)
        {
            //반복 실행문
            Debug.Log($"number: {number}");

            number++;

            //while문 종료
            if (number >= 5)
            {
                break;
            }
        }

    }
}
