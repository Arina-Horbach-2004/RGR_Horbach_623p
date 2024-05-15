using Front;

class Program
{
    static void Main(string[] args)
    {
        FrontController frontController = new FrontController();

        frontController.DispatchRequest("menu");
        frontController.DispatchRequest("createorder");
        frontController.DispatchRequest("orderstatus");
        frontController.DispatchRequest("invalidcommand");
    }
}