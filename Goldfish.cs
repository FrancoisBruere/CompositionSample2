namespace CompositionSample2
{
    public class Goldfish
    {
        private readonly Animal _animal;
        private readonly Swimmable _swim;

        public Goldfish(Animal animal)
        {
            _animal = animal;
           
        }

        public Goldfish(Animal animal, Swimmable swim)
            :this(animal)
        {
            _swim = swim;
        }

        public void Can()
        {
            _animal.Age = 5;
            _animal.Name = "Fred the glodfish";
            _animal.Eat("I am eating fish food");
            _animal.Sleep("I am sleeping in the water");
            _swim.Swim("Fred the Goldfish can swim");

        }


    }
}
