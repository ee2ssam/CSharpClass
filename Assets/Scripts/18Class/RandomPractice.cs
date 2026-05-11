using UnityEngine;

public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //로또번호 생성기        
        //[1] 6개 번호 - 배열 변수 선언 및 요소수 생성
        int[] rottoNumbers = new int[6];

        //중복 검사
        //rottoNumbers[0] : x
        //rottoNumbers[1] : [0]
        //rottoNumbers[2] : [0], [1]
        //rottoNumbers[3] : [0], [1], [2]
        //rottoNumbers[4] : [0], [1], [2], [3]
        //rottoNumbers[5] : [0], [1], [2], [3], [4]

        //Random 객체 가져오기
        System.Random rand = new System.Random();

        //필요변수
        int number = 0;         //랜덤번호 받아오는 값
        bool flag = false;      //중복검사, true 중복,

        //임의의 숫자 6개 번호 생성 :
        for (int i = 0; i < 6; i++)
        {
            //(1~45) 사이의 랜덤값
            number = rand.Next(1, 46);

            //중복 체크 초기화
            flag = false;

            //중복 검사
            for (int j = 0; j < i; j++)
            {
                if(number == rottoNumbers[j])
                {
                    //중복 체크
                    flag = true;
                }
            }

            if(flag == false) //중복이 아니면
            {
                //임의의 숫자를 번호 저장
                rottoNumbers[i] = number;
            }
            else //중복이면
            {
                i--;
            }
        }

        //임의의 숫자 6개를 번호 출력
        for (int i = 0; i < 6; i++)
        {
            Debug.Log($"rottoNumbers[{i}]:{rottoNumbers[i]}");
        }

    }
}

/*
//로또번호 생성기
[1] 6개 번호
[2] 1~45번 사이의 랜덤번호
[3] 6개 번호가 중복이 되면 안된다

3가지 조건이 맞는 6개의 번호를 출력하는 프로그램 구현

[1] 임의의 숫자 6개 번호 생성 :(1~45) 사이의 랜덤값
[2] 임의의 숫자 6개를 번호 저장
[3] 임의의 숫자 6개를 번호 출력

[4] 중복 제거 기능 추가 - [2]과 [3]번 사이에 추가
*/