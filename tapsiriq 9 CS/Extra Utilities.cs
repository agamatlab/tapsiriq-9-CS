﻿static class Extra
{
    public static T?[]? AddElement<T>(T?[]? array, T element) => (array == null) ? new T[] { element } : array.Append(element).ToArray();
}
