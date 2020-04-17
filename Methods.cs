using System;
class Methods<M>
{
    public M Pop(ref M[] ar)
    {
        M[] nar = new M[ar.Length - 1];
        for (int x = 0; x < ar.Length - 1; x++)
        {
            nar[x] = ar[x];
        }
        M end = ar[ar.Length - 1];
        ar = nar;
        return end;
    }
    public void Push(ref M[] ar, M ne)
    {
        M[] nar = new M[ar.Length + 1];
        for (int x = 0; x < ar.Length; x++)
        {
            nar[x] = ar[x];
        }
        nar[nar.Length - 1] = ne;
        ar = nar;
    }
    public M Shift(ref M[] ar)
    {
        M[] nar = new M[ar.Length - 1];
        for (int x = 0; x < nar.Length; x++)
        {
            nar[x] = ar[x + 1];
        }
        M fs = ar[0];
        ar = nar;
        return fs;
    }
    public void UnShift(ref M[] ar, M ne)
    {
        M[] nar = new M[ar.Length + 1];
        nar[0] = ne;
        for (int x = 0; x < nar.Length - 1; x++)
        {
            nar[x + 1] = ar[x];
        }
        ar = nar;
    }
    public void Slice(ref M[] arr, int x)
    {
        if (x < 0)
        {
            M[] narr = new M[Math.Abs(x)];
            int cn = 0;
            bool ch = true;
            for (int i = arr.Length - 1; ch; i--)
            {
                ch = !(cn == Math.Abs(x) - 1);
                narr[cn] = arr[i];
                cn++;
            }
            arr = narr;
        }
        else if (x > 0)
        {
            M[] narr = new M[arr.Length - x + 1];
            int cn = 0;
            for (int i = 0; i <= x; i++)
            {
                narr[cn] = arr[i];
                cn++;
            }
            arr = narr;
        }
    }
    public void Slice(ref M[] arr, int x, int y)
    {
        if (x > 0 && y > 0)
        {
            M[] narr = new M[y - x + 1];
            int cn = 0;
            for (int i = x; i <= y; i++)
            {
                narr[cn] = arr[i];
                cn++;
            }
            arr = narr;
        }
        else (x > 0 && y < 0)
        {
            
        }
    }
}