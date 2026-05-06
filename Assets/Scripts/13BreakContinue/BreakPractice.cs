using UnityEngine;

// 1부터 10까지의 정수의 합을 구하는 프로그램 구현
// 단, 합 구하다가 합이 22이상이 되면 더이상 합을 구하지말고 합을 출력하라 
public class BreakPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;    //합

        int i = 1;  //초기식
        while(i <= 10) //조건식
        {
            //반복 실행문
            sum += i;

            //단, 합 구하다가 합이 22이상이 되면
            if(sum >= 22)
            {
                break;
            }

            //증감식
            i++;
        }

        Debug.Log($"sum: {sum}");
    }
}
