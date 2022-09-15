namespace Boards.Dto
{
    /// <summary>
    /// This color class is defined intentionally, to present the usage of <see cref="IValueConverter"/>.
    /// </summary>
    public class Color : DtoBase
    {
        public string Name { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
    }
}
