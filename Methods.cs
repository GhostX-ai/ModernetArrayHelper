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
}