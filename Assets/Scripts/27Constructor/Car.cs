using UnityEngine;

namespace Constructor
{
    //자동차를 관리하는 클래스
    public class Car
    {
        //필드
        private string color;

        //기본 생성자
        public Car()
        {
            color = "하얀";
            Debug.Log($"{color}색 자동차를 만듭니다");
        }

        //매개변수가 있는 생성자
        public Car(string color)
        {
            this.color = color;
            Debug.Log($"{this.color}색 자동차를 만듭니다");
        }

        //메서드
        public void Run()
        {
            Debug.Log($"{this.color}색 자동차를 달립니다");
        }

        //소멸자
        ~Car()
        {
            Debug.Log($"{this.color}색 자동차를 폐차합니다");
        }

    }
}