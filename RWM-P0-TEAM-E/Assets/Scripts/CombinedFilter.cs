using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;

public class CombinedFilter
{
    public static int[] combinedFilter(int[] xs)
    {


        return RunningTotalFilter.RunningTotals(Modulo3.modulo3(XOR21Filter.XOR21s(xs)));
    }


}
