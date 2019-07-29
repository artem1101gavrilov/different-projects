int max_of_four(int a, int b, int c, int d)
{
    return a > b ? c > d? a > c ? a : c : a > d ? a : d : c > d? b > c ? b : c : b > d ? b : d;
    /*if(a < b) a = b;
    if(c < d) c = d;
    if(a > c) return a;
    else return c;*/
}