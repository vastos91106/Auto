namespace Auto
{
    public class TestAuto
    {
        static void Main()
        {
            List<Auto> autos = new List<Auto>();

            autos.Add(new Auto {Model = "Нива", Type = "4x4", Owner = "Семен Семеныч"});
            autos.Add(new Auto {Model = "Мазда", Type = "Спорткар", Owner = "Иван Иваныч"});
            autos.Add(new Auto {Model = "Т-182", Type = "Танк", Owner = "Иван Иваныч"});
            autos.Add(new Auto());

            foreach (var auto in autos)
            {
                Console.WriteLine(auto.GetInfo());
            }

            Console.WriteLine($"Имя: {autos[1].Owner}\nМашина : {autos[1].Model}\nПраво владения: {autos[1].Equals(autos[1])}\n");
            Console.WriteLine($"Имя: {autos[1].Owner}\nМашина : {autos[3].Model}\nПраво владения: {autos[1].Equals(autos[3])}\n");
        }
    }
}