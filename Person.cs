namespace CompositionSample2
{
    public class Person
    {
        private readonly Animal _animal;
        private readonly Walkable _walking;
        private readonly Swimmable _swim;
        private readonly Talkable _talking;


        public Person(Animal animal)
        {
            _animal = animal;
        }

        public Person(Animal animal, Walkable walking)
            :this(animal)
        {
            //_animal = animal;
            _walking = walking;
        }

        public Person(Animal animal, Walkable walking, Swimmable swim)
            :this(animal,walking)
        {
            //_animal = animal;
            //_walking = walking;
            _swim = swim;
        }

        public Person(Animal animal, Walkable walking, Swimmable swim, Talkable talking)
            :this(animal,walking,swim)
        {
            //_animal = animal;
            //_walking = walking;
            //_swim = swim;
            _talking = talking;
            
        }


        public void Can()
        {
            _animal.Age = 12;
            _animal.Name = "John";
            _animal.Eat("I am eating");
            _animal.Sleep("I am Sleeping");
            _walking.Walk("I am a person I can walk!");
            _swim.Swim("I am swimming in the pool");
            _talking.Talking("Hello! I can talk");
        }


    }
}
