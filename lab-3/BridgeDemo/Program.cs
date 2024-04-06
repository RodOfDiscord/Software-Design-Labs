using Paint;

Shape circle = new Circle(10, new RastorDraw());
circle.Draw();

circle.ChangeDrawAPI(new PixelDraw());
circle.Draw();

Square square = new Square(10, new RastorDraw());
square.Draw();