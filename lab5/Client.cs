using Lab5.Interfaces

namespace Lab5
{
    public class Client
    {
        public void Render(шRenderer renderer)
        {
            var result = renderer.Serialize();
            Debug.WriteLine(result);
        }
    }
}