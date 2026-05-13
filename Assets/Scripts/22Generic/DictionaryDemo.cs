using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]Dictionary 제네릭 클래스
        // Dictionary<TKey, TValue> 인스턴스 생성 : IDictionary(인터페이스)로 생성
        IDictionary<string, string> data = new Dictionary<string, string>();

        //[2]Dictionary 데이터 입력: 키, 값을 매칭해서 입력
        data.Add("도", "경기도");
        data.Add("시", "수원시");

        //[3]Dictionary 데이터 삭제
        data.Remove("도");

        //[4]Dictionary 데이터 입력2: 인덱서를 사용해서 입력
        data["구"] = "장안구";

        //[5]Dictionary 키값이 중복 불가: 에러가 발생
        try
        {
            data.Add("구", "수성구");
            //data["구"] = "수성구";
        }
        catch(System.Exception ex)
        {
            Debug.Log(ex.Message);
        }

        //[6]Dictionary 사용
        foreach (KeyValuePair<string, string> item in data)
        {
            Debug.Log($"{item.Key}, {item.Value}");
        }

        //[6]Dictionary 사용2 : 인덱서를 이요
        Debug.Log(data["구"]);

    }
}
