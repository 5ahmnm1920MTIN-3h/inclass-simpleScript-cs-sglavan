using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public InputField ipVarA;
    public InputField ipVarB;
    public Text result;

    float varA;
    float varB;

    public void SetResult()
    {
        float a = float.Parse(ipVarA.text);
        float b = float.Parse(ipVarB.text);
        Debug.Log("in SetResult" + (a - b));
        float resultAB = a - b;
        result.text = resultAB.ToString();

    }

    public string TestMethode()
    {
        Debug.Log("Test");
        return "Test";
    }
    public void TestMethodeVOID()
    {
        Debug.Log("Test");
    }
    public float MultNumbers(float variableA, float variableB)
    {
        float result = variableA * variableB;
        return result;
    }
    public float SubstractNumbers(float variableA, float variableB)
    {
        float result = variableA - variableB;
        return result;
    }

}
