namespace apitest.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public static implicit operator ValueTask<object>(Product v)
        {
            throw new NotImplementedException();
        }
    }
}
