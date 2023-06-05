

namespace Lesson_5__2_
{
    internal class DATA
    {
      
            public string typev { get; set; }
            public string namev { get; set; }
            public System.DateTime lastWriteTimev { get; set; }

            internal IEnumerable<DATA> OrderBy(Func<object, object> value)
            {
                throw new NotImplementedException();
            }
        
    }
}
