PemrosesData p1 = new PemrosesData();
int tes = p1.DapatkanNilaiTerbesar<int>(10, 30, 22); // akhiran nim 7
Console.WriteLine(tes);

SimpleDatabase<int> sd = new SimpleDatabase<int>();
sd.AddNewData(10);
sd.AddNewData(30);
sd.AddNewData(22);
sd.PrintAllData();

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

public class SimpleDatabase<T>
{
    List<T> storedData;
    List<DateTime> inputDates;

    public SimpleDatabase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData[i] +
                            ", yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}