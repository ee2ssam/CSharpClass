using UnityEngine;

namespace Constructor
{
    //소멸자 테스트 클래스
    public class DestructorTest
    {
        //생성자
        public DestructorTest()
        {
            Debug.Log("[1]생성");
        }

        //함수-메서드
        public void Run()
        {
            Debug.Log("[2]실행");
        }

        //소멸자
        ~DestructorTest()
        {
            Debug.Log("[3]소멸");
        }
    }
}
