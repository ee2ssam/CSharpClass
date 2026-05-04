using UnityEngine;

//점수가 60점이상이면 합격 출력, 아니면 불합격 출력
public class ElseDemo : MonoBehaviour
{
    //점수 입력
    public int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {        
        if(score >= 60) //점수가 60점이상이면 
        {
            //실행문: 합격 출력
            Debug.Log("합격");
        }
        else //아니면 불합격 출력
        {
            Debug.Log("불합격");
        }
    }
}
