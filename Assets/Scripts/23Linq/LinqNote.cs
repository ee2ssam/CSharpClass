using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LinqNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //불형 배열 변수 선언하고 초기화
        bool[] isOuts = { true, false, true, false, true };

        //배열의 갯수 구하기, 배열의 값중에 true의 갯수는 또는 false의 갯수
        Debug.Log(isOuts.Count());
        //true의 갯수
        Debug.Log(isOuts.Count(b => b == true));
        //false의 갯수
        Debug.Log(isOuts.Count(a => a == false));

        //정렬
        string[] colors = { "Red", "Green", "Blue" };

        //오름차순 정렬
        IEnumerable<string> sortedColors = colors.OrderBy(s => s);
        foreach (string color in sortedColors)
        {
            Debug.Log(color);
        }

        //
        List<string> allColors = new List<string> { "Red", "Green", "Blue" };
        var sColors = allColors.OrderByDescending(s => s);
        foreach (string color in sColors)
        {
            Debug.Log(color);
        }



    }
}
