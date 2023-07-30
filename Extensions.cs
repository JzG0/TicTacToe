using UnityEngine;

public static class Extensions
{
    public static T Singleton<T>(this T target, ref T staticVariable) where T : Object
    {
        if (staticVariable == null)
        {
            staticVariable = target;
        }
        else if(staticVariable!=target)
        {
            GameObject.Destroy(target);
        }
        return staticVariable;
    }
}
