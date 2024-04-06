namespace Paint
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public double Area { get; set; }
        IDraw drawAPI;

        protected Shape(string name, double area , IDraw drawAPI)
        {
            Area = area;
            Name = name;
            this.drawAPI = drawAPI;
        }

        public virtual void Draw()
        {
            drawAPI.Draw(Name);
        }

        public void ChangeDrawAPI(IDraw drawAPI)
        {
            this.drawAPI = drawAPI;
        }
    }
}
