namespace CoursWorkAdminsPanel
{
    public class DishProductRequest
    {
        public int ProductID { get; set; }
        public int Weight { get; set; }
    }

    public class AddDishRequest
    {
        public string Action { get; set; }
        public string Name { get; set; }
        public List<DishProductRequest> Products { get; set; }
    }
}
