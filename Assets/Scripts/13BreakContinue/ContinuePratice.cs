using UnityEngine;

//[Q] 1부터 100까지의 합을 구하는 프로그램 구현
//단 1부터 100까지중 3의 배수는 합에서 제외한다
public class ContinuePratice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;    //합

        for (int i = 1; i <= 100; i++)
        {
            //i가 3의 배수이면 제외
            if(i%3 == 0)    //3의 배수 판별식
            {
                continue;
            }

            //반복 실행문
            sum += i;       //누적 합
        }

        Debug.Log($"sum: {sum}");
    }
}
