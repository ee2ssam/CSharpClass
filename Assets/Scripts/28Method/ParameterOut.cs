using UnityEngine;

namespace Method
{
    //[3] 반환형 전달 방법 : (out int num)
    public class ParameterOut : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //정수형 변수 선언, 초기화 x
            int num;   //반환형 전달 방식의 매개변수로 사용되는 변수는 반드시 초기화 할 필요가 없다         

            //반환형 전달 방식 메서드 호출
            PrintNumber(out num);

            Debug.Log($"[2]: {num}");   //[2] 20
        }

        //매개변수로 반환형으로 전달된 정수값을 출력하는 함수
        //메모리 동작 방식은 ref와 동일하다
        //반환형 전달 방식에서 사용되어지는 매개변수는 반드시 함수 내부에서 초기화(값)을 설정해야 한다
        private void PrintNumber(out int num)
        {
            num = 20;   //out일 경우 초기화 필수
            Debug.Log($"[1]: {num}");   //[2] 20
        }

    }
}