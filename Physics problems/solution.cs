using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class solution
{
    private double _gravity;

    public solution(double gravity)
    {
        _gravity = gravity;
    }

    public double finaldistance(double time)
    {
        return _gravity * time;
    }
}

