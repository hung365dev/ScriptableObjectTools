﻿using UnityEngine;
using System.Collections.Generic;

public class GenericSet<T> : ScriptableObject{
    public List<T> items = new List<T>();

    public void Add(T t) {
        if(!items.Contains(t))
            items.Add(t);
    }

    public void Remove(T t) {
        if (items.Contains(t))
            items.Remove(t);
    }
}
