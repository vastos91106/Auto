namespace Auto
{

    public class Auto
    {
        public string Model { get; set; } = String.Empty;

        public string Type { get; set; } = String.Empty;

        public Guid id { get; } = Guid.NewGuid();

        public string Owner { get; set; } = string.Empty;

        public Auto()
        {
        }

        public Auto(string model, string type, string owner)
        {
            Model = model;
            Type = type;
            Owner = owner;
        }

        public override string ToString()
        {
            return Model;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Auto auto)
            {
                return Owner == auto.Owner;
            }
            
            return false;
        }

        public string GetInfo()
        {
            return $" Идентификационный номер: {id} \n Модель: {Model}\n Тип: {Type}\n Владелец: {Owner}\n";
        }
    }   
}