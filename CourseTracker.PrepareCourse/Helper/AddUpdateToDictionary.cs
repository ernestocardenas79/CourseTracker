namespace CourseTracker.PrepareCourse.Helper;
internal class AddUpdateToDictionary
{
    internal static void Try<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
    {
        if (dictionary.ContainsKey(key))
        {
            dictionary[key] = value;
        }
        else
        {
            dictionary.Add(key, value);
        };
    }
}
