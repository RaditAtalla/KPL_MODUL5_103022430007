PemrosesData p1 = new PemrosesData();
int tes = p1.DapatkanNilaiTerbesar<int>(10, 30, 22); // akhiran nim 7
Console.WriteLine(tes);

public class PemrosesData
{
    public T DapatkanNilaiTerbesar<T>(T d1, T d2, T d3)
    {
        dynamic input1 = d1;
        dynamic input2 = d2;
        dynamic input3 = d3;
        dynamic max = input1;

        if(input1 > input2 && input1 > input3)
        {
            return input1;
        } else if (input2 > input1 && input2 > input3)
        {
            return input2;
        } else if (input3 > input1 && input3 > input2)
        {
            return input3;
        }
        else
        {
            return input1;
        }
    }
}