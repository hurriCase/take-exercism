using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores (List<int> list)
{

    public List<int> Scores() =>
        list;

    public int Latest() =>
        list[^1];

    public int PersonalBest() =>
        list.Max();

    public List<int> PersonalTopThree() =>
        list.OrderDescending().Take(3).ToList();
}