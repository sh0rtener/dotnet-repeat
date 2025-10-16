internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddOpenApi();

        var app = builder.Build();

        app.MapGet("xyu", () => "xyui");

        app.UseHttpsRedirection();



        app.Run();
    }
}


// контракт. просто описывает поведение
public interface ITestNullable
{
    // Метод для движения чего то нахуй
    void Begit(); // void - это пустота
}

// public abstract class TestNullableAbstract
// {
//     public abstract void Test();
// }

public class TestNullableParent
{
    public virtual void Test()
    {
        Console.WriteLine("Test");
    }
}

public class TestNullable : TestNullableParent, ITestNullable // наследование, много интерфейсов, но всего наследовать
{
    public int A = 0;
    public Nullable<int> B = null; // int?

    public void Begit()
    {
        throw new NotImplementedException();
    }

    public override void Test() // override - переопределить
    {
        Console.WriteLine("zxc");
    }

    public void Name()  // [модификатор доступа] [возвращаемый тип] [название метода] ([аргументы])
    {

    }
}

