using UnityEngine;

//학점을 출력하는 프로그램
//점수가 90이상이면 A 출력, 80이상이면 B출력, 70이상이면 C 출력
//60이상이면 D출력, 나머지 F출력
//학점: A
public class ElseIfDemo : MonoBehaviour
{
    //스코어 입력
    public int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //학점을 저장하는 변수를 선언하고 초기화
        char grade = 'A';

        //학점을 출력하는 프로그램
        if(score >= 90) //점수가 90이상이면
        {
            //실행문 - A 출력
            //Debug.Log("학점: A");
            grade = 'A';
        }
        else if(score >= 80) //점수가 80이상이면
        {
            //실행문 - B 출력
            //Debug.Log("학점: B");
            grade = 'B';
        }
        else if (score >= 70) //점수가 70이상이면
        {
            //실행문 - C 출력
            //Debug.Log("학점: C");
            grade = 'C';
        }
        else if (score >= 60) //점수가 60이상이면
        {
            //실행문 - D 출력
            //Debug.Log("학점: D");
            grade = 'D';
        }
        else //모든 조건이 맞지 않으면, 그외 모든 경우
        {
            //실행문 - F 출력
            //Debug.Log("학점: F");
            grade = 'F';
        }

        //실행문 - 학점 출력
        Debug.Log($"학점: {grade}");


    }
}
