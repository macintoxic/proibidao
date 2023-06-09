﻿// Copyright (c) Charles Alves - Ceu System - Todos os direitos reservados.

namespace Taboo;

public static class ListExtensions
{
    private static readonly Random Random = new Random();

    public static T GetRandomItem<T>(this List<T> list)
    {
        var index = Random.Next(list.Count);
        return list[index];
    }


    public static void Shuffle<T>(this IList<T> list)
    {
        var n = list.Count;
        while (n > 1)
        {
            n--;
            var k = Random.Next(n + 1);
            (list[k], list[n]) = (list[n], list[k]);
        }
    }
}