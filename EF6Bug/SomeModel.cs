using System.ComponentModel.DataAnnotations;

namespace EF6Bug
{
    public class SomeModel
    {
        [Key]
        public int Id { get; set; }

        public int SomethingElse { get; set; }
    }
}
