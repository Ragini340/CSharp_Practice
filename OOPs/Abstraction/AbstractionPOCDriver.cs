namespace CSharp_Practice.OOPs.Abstraction
{
    public class AbstractionPOCDriver
    {
        public static void Main(string[] args)
        {
            //Creating reference of shape class which refer to AbstractionPOC class instance
            AbstractionPOC abstractionPOC = new Square(4);  //Which class should be instantiated It decide at run time  so It is called Dynamic polymorphism 
                                                            //var result = abstractionPOC.area();
                                                            //Console.Write("{0}", result);

            ChildAbstract_Implementor childAbstract = new ChildAbstract_Implementor(); //Here reference of child class 
            childAbstract.Area();
            childAbstract.Calculate();

            ChildAbstract obj = new ChildAbstract_Implementor(); //Here reference of Abstract class, so it is calling calculate of Abstract class method
            obj.Calculate();
        }

    }
}