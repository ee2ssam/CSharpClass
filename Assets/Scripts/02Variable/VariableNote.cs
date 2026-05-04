using UnityEngine;

//변수(Variable) : 프로그램에서 사용할 데이터를 저장해 놓는 그릇
public class VariableNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 변수 만들기(선언)
        int i;  //i 이름으로 정수형 변수를 만든다, 그릇모양(타입) 그릇이름

        //[2] 변수에 값을 저장하기(대입, 할당, 초기화)
        i = 1234;

        //[3] 변수에 들어있는 값을 사용하기(참조)
        Debug.Log(i);   

    }
}
