SimpleDatabase<int> sd = new SimpleDatabase<int>();
sd.AddNewData(10);
sd.AddNewData(30);
sd.AddNewData(22);
sd.PrintAllData();

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
            Console.WriteLine("Data " + (i+1) + " berisi: " + storedData[i] +
                            ", yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}